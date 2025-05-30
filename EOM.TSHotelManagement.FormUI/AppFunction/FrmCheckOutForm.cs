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

using EOM.TSHotelManagement.Common;
using EOM.TSHotelManagement.Common.Contract;
using jvncorelib.CodeLib;
using jvncorelib.EntityLib;
using Sunny.UI;
using System.Transactions;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmCheckOutForm : UIForm
    {
        public static string co_CustoNo;
        public static string co_RoomNo;
        public static string co_CustoName;
        public static string co_CustoBirthday;
        public static string co_CustoSex;
        public static string co_CustoTel;
        public static string co_CustoPassportType;
        public static string co_CustoAddress;
        public static string co_CustoType;
        public static string co_CustoID;
        public static CreateEnergyManagementInputDto w;
        private LoadingProgress _loadingProgress;

        public FrmCheckOutForm(LoadingProgress loadingProgress)
        {
            InitializeComponent();
            _loadingProgress = loadingProgress;
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 记录移动的窗体坐标
        private void FrmCheckOutForm_MouseDown(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmCheckOutForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseNew = MousePosition;
                int moveX = mouseNew.X - mouseOld.X;
                int moveY = mouseNew.Y - mouseOld.Y;
                this.Location = new Point(formOld.X + moveX, formOld.Y + moveY);
            }
        }
        #endregion

        #region 窗体加载事件
        private void FrmCheckOutForm_Load(object sender, EventArgs e)
        {
            #region 加载客户类型信息
            result = HttpHelper.Request(ApiConstants.Base_SelectCustoTypeAllCanUse);
            var customerTypes = HttpHelper.JsonToModel<ListOutputDto<ReadCustoTypeOutputDto>>(result.message);
            if (customerTypes.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectCustoTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<ReadCustoTypeOutputDto> lstSourceGrid = customerTypes.listSource;
            #endregion

            decimal sum = 0;
            txtCustomerNumber.Text = ucRoom.rm_CustoNo;
            CustoNo.Text = ucRoom.rm_CustoNo;
            txtRoomNo.Text = ucRoom.rm_RoomNo;

            dic = new Dictionary<string, string>()
            {
                { nameof(ReadRoomInputDto.RoomNumber) , txtRoomNo.Text.ToString()}
            };

            result = HttpHelper.Request(ApiConstants.Room_SelectRoomByRoomNo, dic);
            var roomInfo = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);
            if (roomInfo.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }

            ReadRoomOutputDto room = roomInfo.Source;

            if (room.LastCheckInTime == null)
            {
                dtpCheckTime.Text = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            }
            else
            {
                dtpCheckTime.Text = Convert.ToDateTime(room.LastCheckInTime).ToString("yyyy-MM-dd");
            }
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadRoomInputDto.RoomNumber) , txtRoomNo.Text}
            };
            result = HttpHelper.Request(ApiConstants.Room_DayByRoomNo, dic);
            var stayDays = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);
            if (stayDays.StatusCode != 200)
            {
                UIMessageBox.ShowError("DayByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }

            sum = Convert.ToDecimal(Convert.ToString(Convert.ToInt32(stayDays.Source.StayDays) * room.RoomRent));

            lblDay.Text = Convert.ToString(Convert.ToInt32(stayDays.Source.StayDays));

            w = new CreateEnergyManagementInputDto()
            {
                PowerUsage = Convert.ToDecimal(Convert.ToInt32(stayDays.Source.StayDays) * 3 * 1),
                WaterUsage = Convert.ToDecimal(Convert.ToDouble(stayDays.Source.StayDays) * 80 * 0.002)
            };

            #region 加载客户信息
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadCustomerInputDto.CustomerNumber),CustoNo.Text.ToString() }
            };
            result = HttpHelper.Request(ApiConstants.Customer_SelectCustoByInfo, dic);
            SingleOutputDto<ReadCustomerOutputDto> customer = HttpHelper.JsonToModel<SingleOutputDto<ReadCustomerOutputDto>>(result.message);
            if (customer?.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectCustoByInfo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            try
            {
                CustoName.Text = customer?.Source.CustomerName;
                txtCustomerName.Text = customer?.Source.CustomerName;
                txtTel.Text = customer?.Source.CustomerPhoneNumber;
                txtCustomerGender.Text = customer?.Source.GenderName ?? string.Empty;
                txtCustomerType.Text = customer.Source.CustomerTypeName;
                txtPassportName.Text = customer.Source.PassportName;
                txtDateOfBirth.Text = Convert.ToString(customer.Source.DateOfBirth);
                txtIdCardNumber.Text = customer.Source.IdCardNumber;
                txtCustomerAddress.Text = customer.Source.CustomerAddress;
            }
            catch
            {


            }


            #endregion

            #region 加载消费信息

            var dataCount = 0;
            btnPg.PageSizeOptions = new int[] { 15, 30, 50, 100 };
            dgvSpendList.Spin("正在加载中...", config =>
            {
                TableComHelper tableComHelper = new TableComHelper();
                dgvSpendList.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<ReadSpendOutputDto>());
                dgvSpendList.DataSource = GetPageData(btnPg.Current, btnPg.PageSize, ref dataCount);
                btnPg.PageSize = 15;
                btnPg.Current = 1;
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });

            #endregion

            #region 加载水电费信息
            dgvWti.Spin("正在加载中...", config =>
            {
                TableComHelper tableComHelper = new TableComHelper();
                dgvWti.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<ReadEnergyManagementOutputDto>());
                dgvWti.DataSource = GetEnergyPageData();
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
            #endregion

            var customerType = lstSourceGrid.SingleOrDefault(a => a.CustomerTypeName == txtCustomerType.Text);

            //计算消费总额
            dic = new Dictionary<string, string>() 
            {
                { nameof(ReadSpendInputDto.RoomNumber), txtRoomNo.Text.Trim() },
                { nameof(ReadSpendInputDto.CustomerNumber), txtCustomerNumber.Text.Trim() },
            };
            result = HttpHelper.Request(ApiConstants.Spend_SumConsumptionAmount, dic);
            var response = HttpHelper.JsonToModel<SingleOutputDto<ReadSpendOutputDto>>(result.message);
            if (response.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Spend_SumConsumptionAmount}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            decimal total = response.Source.ConsumptionAmount;
            decimal m = total + sum;
            if (!customerType.IsNullOrEmpty() && customerType.Discount != 0)
            {
                lblGetReceipts.Text = m.ToString("#,##0.00");
                lblVIPPrice.Text = (m * customerType.Discount).ToString("#,##0.00");
                lblVIP.Text = customerType.Discount.ToZheString();
                Refresh();
            }
            else
            {
                lblGetReceipts.Text = m.ToString("#,##0.00");
                lblVIPPrice.Text = m.ToString("#,##0.00");
                lblVIP.Text = "折扣未配置或无折扣";
                Refresh();
            }
        }
        #endregion

        #region 实收金额文本框值改变时事件
        private void txtReceipts_TextChanged(object sender, EventArgs e)
        {
            if (txtReceipts.Text != "")
            {
                try
                {
                    double receipt = Convert.ToDouble(Convert.ToDecimal(txtReceipts.Text));
                    double vipPrice = Convert.ToDouble(Convert.ToDecimal(lblVIPPrice.Text));
                    lblChange.Text = Decimal.Parse((receipt - vipPrice).ToString()).ToString("#,##0.00");
                }
                catch
                {
                    UIMessageBox.Show("非法输入，请重新输入！", "系统提示", UIStyle.Orange);
                    txtReceipts.Clear();
                    txtReceipts.Focus();
                    return;
                }
            }
            else
            {
                lblChange.Text = "-" + lblGetReceipts.Text;
                return;
            }
        }
        #endregion

        #region 结算按钮点击事件
        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReceipts.Text) && Convert.ToDecimal(txtReceipts.Text) > Convert.ToDecimal(lblVIPPrice.Text))//判断实收金额是否为空以及是否小于应收金额
            {
                result = HttpHelper.Request(ApiConstants.Room_CheckoutRoom,
                    HttpHelper.ModelToJson(new CheckoutRoomDto
                    {
                        RoomNumber = txtRoomNo.Text.Trim(),
                        CustomerNumber = txtCustomerNumber.Text.Trim(),
                        DataChgDate = DateTime.Now,
                        DataChgUsr = LoginInfo.WorkerNo,
                        ElectricityUsage = w.PowerUsage,
                        WaterUsage = w.WaterUsage
                    }));
                var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                if (response.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError($"{ApiConstants.Room_CheckoutRoom}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                UIMessageBox.Show("结算成功！", "系统提示", UIStyle.Green);
                FrmRoomManager.Reload("");
                FrmRoomManager._RefreshRoomCount();

                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "帮助" + txtCustomerNumber.Text + "进行了退房结算操作！", Common.Core.LogLevel.Critical);
                #endregion
                this.Close();
            }
            else
            {
                UIMessageBox.Show("实收金额不能为空或实收金额不能小于折后金额！", "系统提示", UIStyle.Orange);
                return;
            }
        }
        #endregion

        private string btnPg_ShowTotalChanged(object sender, AntdUI.PagePageEventArgs e)
        {
            return $"{e.PageSize} / {e.Total}条 共{e.PageTotal}页";
        }

        private void btnPg_ValueChanged(object sender, AntdUI.PagePageEventArgs e)
        {
            var dataCount = 0;
            dgvSpendList.Spin("正在加载中...", config =>
            {
                dgvSpendList.DataSource = GetPageData(e.Current, e.PageSize, ref dataCount);
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }

        object GetPageData(int current, int pageSize, ref int totalCount)
        {
            string RoomNo = txtRoomNo.Text;
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadSpendInputDto.RoomNumber) , RoomNo },
                { nameof(ReadAdministratorInputDto.IgnorePaging) , "true" }
            };
            result = HttpHelper.Request(ApiConstants.Spend_SelectSpendByRoomNo, dic);
            var spendInfo = HttpHelper.JsonToModel<ListOutputDto<ReadSpendOutputDto>>(result.message);
            if (spendInfo.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Spend_SelectSpendByRoomNo}+接口服务异常，请提交Issue或尝试更新版本！");
            }

            List<ReadSpendOutputDto> spends = spendInfo.listSource;
            totalCount = spendInfo.total;
            var listTableSource = new List<AntdUI.AntItem[]>();

            spends = spends.OrderBy(a => a.SpendNumber).ToList();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(spends);

            return listTableSource;
        }

        object GetEnergyPageData()
        {
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadEnergyManagementInputDto.RoomNo),txtRoomNo.Text.Trim()}
            };
            result = HttpHelper.Request(ApiConstants.EnergyManagement_SelectEnergyManagementInfo, dic);
            var energyManagements = HttpHelper.JsonToModel<ListOutputDto<ReadEnergyManagementOutputDto>>(result.message);
            if (energyManagements.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.EnergyManagement_SelectEnergyManagementInfo}+接口服务异常，请提交Issue或尝试更新版本！");
            }

            List<ReadEnergyManagementOutputDto> energys = energyManagements.listSource;
            var listTableSource = new List<AntdUI.AntItem[]>();

            energys = energys.OrderByDescending(a => a.StartDate).ToList();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(energys);

            return listTableSource;
        }


    }
}
