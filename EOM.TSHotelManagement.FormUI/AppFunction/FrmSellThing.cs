/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */

using AntdUI;
using EOM.TSHotelManagement.Common;
using EOM.TSHotelManagement.Common.Contract;
using EOM.TSHotelManagement.Common.Core;
using EOM.TSHotelManagement.Shared;
using jvncorelib.CodeLib;
using jvncorelib.EntityLib;
using Sunny.UI;
using System.Transactions;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmSellThing : Sunny.UI.UIForm
    {
        static string roomNo;

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;
        ReadRoomOutputDto r = null;

        private static ReadSpendOutputDto spend = null;

        private LoadingProgress loadingProgress;
        public FrmSellThing()
        {
            InitializeComponent();
            loadingProgress = new LoadingProgress();
        }

        #region 窗体加载事件
        private void FrmSellThing_Load(object sender, EventArgs e)
        {
            loadingProgress.Show();
            LoadSellThingInfo();
            loadingProgress.Close();

        }
        #endregion

        #region 查询事件
        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadThingByName(txtFind.Text);
        }
        #endregion

        #region 查询文本框更改事件

        private void LoadThingByName(string sellthing)
        {
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadSellThingInputDto.ProductNumber) , sellthing.Trim() },
                { nameof(ReadSellThingInputDto.ProductName) , sellthing.Trim() },
                { nameof(ReadSellThingInputDto.Specification) , sellthing.Trim() }
            };
            result = HttpHelper.Request("Sellthing/SelectSellThingAll", dic);
            var response = HttpHelper.JsonToModel<ListOutputDto<ReadSellThingOutputDto>>(result.message);
            if (response.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }

            var listTableSource = new List<AntdUI.AntItem[]>();

            List<ReadSellThingOutputDto> lstSource = response.listSource;

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(lstSource);

            dgvSellthing.Spin("正在加载中...", config =>
            {
                this.dgvSellthing.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<ReadSellThingOutputDto>());
                this.dgvSellthing.DataSource = listTableSource;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }
        #endregion

        #region 根据客户编号加载消费信息的方法
        private void LoadSpendInfoByRoomNo(string room)
        {
            dgvRoomSell.Spin("正在加载中...", config =>
            {
                dic = new Dictionary<string, string>()
                {
                    { nameof(ReadSpendInputDto.RoomNumber), room }
                };
                result = HttpHelper.Request("Spend/SelectSpendByRoomNo",dic);
                var response = HttpHelper.JsonToModel<ListOutputDto<ReadSpendOutputDto>>(result.message);
                if (response.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError("SelectSpendByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                List<ReadSpendOutputDto> lstSource = response.listSource;
                TableComHelper tableComHelper = new TableComHelper();
                dgvRoomSell.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<ReadSpendOutputDto>());
                dgvRoomSell.DataSource = tableComHelper.ConvertToAntdItems(lstSource);
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }
        #endregion

        #region 商品加载事件方法
        public void LoadSellThingInfo()
        {
            var dataCount = 0;
            btnPg.PageSizeOptions = new int[] { 15, 30, 50, 100 };
            dgvSellthing.Spin("正在加载中...", config =>
            {
                TableComHelper tableComHelper = new TableComHelper();
                dgvSellthing.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<ReadSellThingOutputDto>());
                dgvSellthing.DataSource = GetPageData(btnPg.Current, btnPg.PageSize, ref dataCount);
                btnPg.PageSize = 15;
                btnPg.Current = 1;
                btnPg.Total = dataCount;
            });

        }

        object GetPageData(int current, int pageSize, ref int totalCount)
        {
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadSellThingInputDto.Page), current.ToString() },
                { nameof(ReadSellThingInputDto.PageSize), pageSize.ToString() },
                { nameof(ReadSellThingInputDto.IsDelete), "0"}
            };
            result = HttpHelper.Request("Sellthing/SelectSellThingAll", dic);
            var response = HttpHelper.JsonToModel<ListOutputDto<ReadSellThingOutputDto>>(result.message);
            if (response.StatusCode != StatusCodeConstants.Success)
            {
                AntdUI.Message.error(this, "SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                return null!;
            }
            List<ReadSellThingOutputDto> lstSource = response.listSource;
            totalCount = lstSource.Count;
            var listTableSource = new List<AntdUI.AntItem[]>();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(lstSource);

            return listTableSource;
        }

        #endregion

        #region 判断输入的完整性的方法
        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtRoomNo.Text))
            {
                UIMessageBox.Show("消费房间不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtRoomNo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSellNo.Text))
            {
                UIMessageBox.Show("商品编号不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtSellNo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSellName.Text))
            {
                UIMessageBox.Show("商品名称不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtSellName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                UIMessageBox.Show("商品单价不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtPrice.Focus();
                return false;
            }
            if (nudNum.Value <= 0)
            {
                UIMessageBox.Show("数量不能小于或等于0", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtPrice.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 添加消费事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblState.Visible == false)
            {
                UIMessageBox.Show("请先输入消费的房间！", "提示信息", UIStyle.Red);
                return;
            }
            if (nudNum.Value <= 0)
            {
                UIMessageBox.Show("请输入消费数量！", "提示信息", UIStyle.Red);
                return;
            }
            if (lblState.Text == "该房间可消费")//判断房间编号是否可消费
            {
                if (CheckInput())
                {
                    dic = new Dictionary<string, string>()
                    {
                        { nameof(ReadSellThingInputDto.ProductNumber) , txtSellNo.Text.Trim()}
                    };
                    result = HttpHelper.Request("Sellthing/SelectSellThingAll", dic);
                    var sellthings = HttpHelper.JsonToModel<ListOutputDto<ReadSellThingOutputDto>>(result.message);
                    if (sellthings.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError("SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    List<ReadSellThingOutputDto> st = sellthings.listSource;
                    dic = new Dictionary<string, string>()
                    {
                        { nameof(ReadRoomInputDto.RoomNumber) , txtRoomNo.Text.Trim()}
                    };
                    result = HttpHelper.Request("Room/SelectRoomByRoomNo", dic);
                    var room = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);
                    if (room.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    r = room.Source;
                    dic = new Dictionary<string, string>()
                    {
                        { nameof(ReadSpendInputDto.RoomNumber) , txtRoomNo.Text.Trim() },
                        { nameof(ReadSpendInputDto.IsDelete) , "0" },
                        { nameof(ReadSpendInputDto.IgnorePaging) , "true" }
                    };
                    result = HttpHelper.Request("Spend/SelectSpendInfoRoomNo", dic);
                    var spends = HttpHelper.JsonToModel<ListOutputDto<ReadSpendOutputDto>>(result.message);
                    if (spends.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError("SelectSpendInfoRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    var listSource = spends.listSource;
                    if (!listSource.IsNullOrEmpty())
                    {
                        var sellthing = listSource.SingleOrDefault(a => a.ProductNumber.Equals(txtSellNo.Text));
                        if (!sellthing.IsNullOrEmpty())
                        {
                            using (TransactionScope scope = new TransactionScope())
                            {
                                var updateSpend = new UpdateSpendInputDto()
                                {
                                    SpendNumber = sellthing.SpendNumber,
                                    RoomNumber = txtRoomNo.Text,
                                    ProductName = txtSellName.Text,
                                    ConsumptionQuantity = (int)nudNum.Value + sellthing.ConsumptionQuantity,
                                    CustomerNumber = r.CustomerNumber,
                                    ProductPrice = Convert.ToDecimal(txtPrice.Text),
                                    ConsumptionAmount = Convert.ToDecimal(Convert.ToDouble(txtPrice.Text) * nudNum.Value) + sellthing.ConsumptionAmount,
                                    ConsumptionTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                                    SettlementStatus = SpendConsts.UnSettle,
                                    IsDelete = 0,
                                    DataChgUsr = LoginInfo.WorkerNo
                                };
                                result = HttpHelper.Request("Spend/UpdSpenInfo", HttpHelper.ModelToJson(updateSpend));
                                var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                                if (response.StatusCode != StatusCodeConstants.Success)
                                {
                                    UIMessageBox.ShowError("UpdSpenInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                    return;
                                }
                                var stock = (st.First().Stock - (decimal)nudNum.Value);
                                var sellThing = new UpdateSellThingInputDto { ProductName = st.First().ProductName, ProductPrice = st.First().ProductPrice, Stock = stock, ProductNumber = st.First().ProductNumber, Specification = st.First().Specification };
                                result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                                response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                                if (response.StatusCode != StatusCodeConstants.Success)
                                {
                                    UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                    return;
                                }
                                UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK, true);
                                LoadSpendInfoByRoomNo(r.RoomNumber);
                                LoadSellThingInfo();
                                #region 获取添加操作日志所需的信息
                                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + updateSpend.CustomerNumber + "进行了消费商品:" + txtSellName.Text + "操作！", 2);
                                #endregion

                                scope.Complete();
                            }
                        }
                        else
                        {
                            using (TransactionScope scope = new TransactionScope())
                            {
                                var insertSpend = new CreateSpendInputDto()
                                {
                                    SpendNumber = new UniqueCode().GetNewId("SP-"),
                                    RoomNumber = txtRoomNo.Text,
                                    ProductName = txtSellName.Text,
                                    ConsumptionQuantity = (int)nudNum.Value,
                                    CustomerNumber = r.CustomerNumber,
                                    ProductPrice = Convert.ToDecimal(txtPrice.Text),
                                    ConsumptionAmount = Convert.ToDecimal(Convert.ToDouble(txtPrice.Text) * nudNum.Value),
                                    ConsumptionTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                                    SettlementStatus = SpendConsts.UnSettle,
                                    DataInsUsr = LoginInfo.WorkerNo,
                                    DataInsDate = DateTime.Now,
                                };
                                result = HttpHelper.Request("Spend​/InsertSpendInfo", HttpHelper.ModelToJson(insertSpend));
                                var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                                if (response.StatusCode != StatusCodeConstants.Success)
                                {
                                    UIMessageBox.ShowError("InsertSpendInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                    return;
                                }
                                var stock = (st.First().Stock - (decimal)nudNum.Value);
                                var sellThing = new UpdateSellThingInputDto { ProductName = st.First().ProductName, ProductPrice = st.First().ProductPrice, Stock = stock, ProductNumber = st.First().ProductNumber, Specification = st.First().Specification };
                                result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                                response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                                if (response.StatusCode != StatusCodeConstants.Success)
                                {
                                    UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                    return;
                                }
                                UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK, true);
                                LoadSpendInfoByRoomNo(r.RoomNumber);
                                LoadSellThingInfo();
                                #region 获取添加操作日志所需的信息
                                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + insertSpend.CustomerNumber + "进行了消费商品:" + txtSellName.Text + "操作！", 2);
                                #endregion
                                nudNum.Value = 0;

                                scope.Complete();
                            }
                        }
                    }
                    else
                    {
                        using (TransactionScope scope = new TransactionScope())
                        {
                            var spend = new CreateSpendInputDto()
                            {
                                DataInsDate = DateTime.Now,
                                DataInsUsr = LoginInfo.WorkerNo,
                                RoomNumber = txtRoomNo.Text,
                                ProductName = txtSellName.Text,
                                ConsumptionQuantity = (int)nudNum.Value,
                                CustomerNumber = r.CustomerNumber,
                                ProductPrice = Convert.ToDecimal(txtPrice.Text),
                                ConsumptionAmount = Convert.ToDecimal(Convert.ToDouble(txtPrice.Text) * nudNum.Value),
                                ConsumptionTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                                SettlementStatus = SpendConsts.UnSettle,
                            };
                            result = HttpHelper.Request("Spend​/InsertSpendInfo", HttpHelper.ModelToJson(spend));
                            var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                            if (response.StatusCode != StatusCodeConstants.Success)
                            {
                                UIMessageBox.ShowError("InsertSpendInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                return;
                            }
                            var stock = (st.First().Stock - (decimal)nudNum.Value);
                            var sellThing = new UpdateSellThingInputDto { ProductName = st.First().ProductName, ProductPrice = st.First().ProductPrice, Stock = stock, ProductNumber = st.First().ProductNumber, Specification = st.First().Specification };
                            result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                            response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                            if (response.StatusCode != StatusCodeConstants.Success)
                            {
                                UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                return;
                            }
                            UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK, true);
                            LoadSpendInfoByRoomNo(r.RoomNumber);
                            LoadSellThingInfo();
                            #region 获取添加操作日志所需的信息
                            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + spend.CustomerNumber + "进行了消费商品:" + txtSellName.Text + "操作！", 2);
                            #endregion
                            nudNum.Value = 0;
                            return;

                            scope.Complete();
                        }
                    }
                }
            }
        }
        #endregion

        #region 撤回消费事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lblState.Visible == false)
            {
                UIMessageBox.Show("请先输入消费的房间！", "提示信息", UIStyle.Red);
                return;
            }
            if (dgvRoomSell.SelectedIndex > 0)
            {
                if (spend.ProductName.Contains("居住"))
                {
                    UIMessageBox.Show("此条消费记录为住房记录，无法删除！", "提示信息", UIStyle.Red);
                    return;
                }
                if (UIMessageDialog.ShowMessageDialog("你确定要撤回该消费记录吗？", UILocalize.WarningTitle, true, Style))
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        dic = new Dictionary<string, string>()
                        {
                            { nameof(ReadSellThingInputDto.ProductNumber) , spend.ProductNumber },
                            { nameof(ReadSellThingInputDto.ProductName) , spend.ProductName },
                            { nameof(ReadSellThingInputDto.ProductPrice) , Decimal.Parse(spend.ProductPrice.ToString()).ToString("#,##0.00").ToString() }
                        };
                        result = HttpHelper.Request("Sellthing/SelectSellThingByNameAndPrice", dic);
                        var response = HttpHelper.JsonToModel<SingleOutputDto<ReadSellThingOutputDto>>(result.message);
                        if (response.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError("SelectSellThingByNameAndPrice+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        ReadSellThingOutputDto s = response.Source;
                        decimal num = Convert.ToDecimal(spend.ConsumptionQuantity);
                        decimal inboundStock = (s.Stock + num);
                        result = HttpHelper.Request("Spend/UndoCustomerSpend", HttpHelper.ModelToJson(new UpdateSpendInputDto { SpendNumber = spend.SpendNumber }));
                        var undoSpendResponse = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (undoSpendResponse.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError("UndoCustomerSpend+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        var sellThing = new UpdateSellThingInputDto { ProductName = s.ProductName, ProductPrice = s.ProductPrice, Stock = inboundStock, ProductNumber = s.ProductNumber, Specification = s.Specification };
                        result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                        var updateResponse = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (updateResponse.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageTip.ShowError("撤销失败！", 1000);
                            RecordHelper.Record($"接口异常。Message：\n{updateResponse.Message}", 3);
                            UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        UIMessageTip.ShowOk("撤销成功！", 1000);
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + spend.CustomerNumber + "撤销了消费商品:" + txtSellName.Text + "操作！", 2);
                        #endregion
                        LoadSpendInfoByRoomNo(txtRoomNo.Text);
                        LoadSellThingInfo();
                        nudNum.Value = 0;
                        scope.Complete();
                    }
                }
                else
                {
                    UIMessageTip.ShowError("操作取消！", 1000);
                }
            }
            else
            {
                UIMessageBox.Show("请选择要删除的消费记录！", "提示信息", UIStyle.Red);
            }
        }
        #endregion

        private void nudNum_ValueChanged(object sender, double value)
        {
            if (nudNum.Value < 0)
            {
                nudNum.Value = 0;
            }
        }

        private void txtRoomNo_Validated(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string room = txtRoomNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(room) == true)
            {
                UIMessageTip.ShowWarning("请输入消费房间号！", 1000);
                return;
            }
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadRoomInputDto.RoomNumber) , room}
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomNo", dic);
            var checkResponse = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);
            if (checkResponse.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            ReadRoomOutputDto r = checkResponse.Source;
            if (txtRoomNo.Text == "")
            {
                lblState.Text = "";
            }
            else if (r == null)
            {
                lblState.Visible = true;
                lblState.Text = "该房间不存在";
                lblState.ForeColor = Color.Red;
            }
            else if (!r.IsNullOrEmpty())
            {
                if (r.RoomStateId == new EnumHelper().GetEnumValue(RoomState.Occupied))
                {
                    lblState.Visible = true;
                    lblState.Text = "该房间可消费";
                    lblState.ForeColor = Color.Black;
                    LoadSpendInfoByRoomNo(room);
                }
                else
                {
                    lblState.Visible = true;
                    lblState.Text = "该房间不可消费";
                    lblState.ForeColor = Color.Red;
                }
            }
        }

        TableComHelper helper = new TableComHelper();
        private void dgvSellthing_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (lblState.Visible == false)
            {
                UIMessageBox.Show("请先输入消费的房间！", "提示信息", UIStyle.Red);
                return;
            }
            if (e.Record is IList<AntdUI.AntItem> data)
            {
                txtSellNo.Text = helper.GetValue(data, nameof(ReadSellThingOutputDto.ProductNumber));
                txtSellName.Text = helper.GetValue(data, nameof(ReadSellThingOutputDto.ProductName));
                txtPrice.Text = helper.GetValue(data, nameof(ReadSellThingOutputDto.ProductPrice));
            }
        }

        private void dgvRoomSell_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Record is IList<AntdUI.AntItem> data)
            {
                spend = new ReadSpendOutputDto();
                spend.RoomNumber = helper.GetValue(data, nameof(ReadSpendOutputDto.RoomNumber));
                spend.CustomerNumber = helper.GetValue(data, nameof(ReadSpendOutputDto.CustomerNumber));
                spend.ProductName = helper.GetValue(data, nameof(ReadSpendOutputDto.ProductName));
                spend.ConsumptionQuantity = Convert.ToInt32(helper.GetValue(data, nameof(ReadSpendOutputDto.ConsumptionQuantity)));
                spend.ProductPrice = Convert.ToDecimal(helper.GetValue(data, nameof(ReadSpendOutputDto.ProductPrice)));
                spend.ConsumptionAmount = Convert.ToDecimal(helper.GetValue(data, nameof(ReadSpendOutputDto.ConsumptionAmount)));
                spend.ConsumptionTime = Convert.ToDateTime(helper.GetValue(data, nameof(ReadSpendOutputDto.ConsumptionTime)));
            }
        }
    }
}
