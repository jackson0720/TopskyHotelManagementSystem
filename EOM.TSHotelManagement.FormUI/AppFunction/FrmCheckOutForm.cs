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
using EOM.TSHotelManagement.Common.Core;
using jvncorelib.CodeLib;
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
            this.cboCustoType.DataSource = lstSourceGrid;
            this.cboCustoType.DisplayMember = nameof(ReadCustoTypeOutputDto.CustomerTypeName);
            this.cboCustoType.ValueMember = nameof(ReadCustoTypeOutputDto.CustomerType);
            this.cboCustoType.SelectedIndex = 0;
            this.cboCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            result = HttpHelper.Request(ApiConstants.Base_SelectPassPortTypeAllCanUse);
            var passportTypes = HttpHelper.JsonToModel<ListOutputDto<ReadPassportTypeOutputDto>>(result.message);
            if (passportTypes.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectPassPortTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<ReadPassportTypeOutputDto> passPorts = passportTypes.listSource;
            this.cboPassportType.DataSource = passPorts;
            this.cboPassportType.DisplayMember = nameof(ReadPassportTypeOutputDto.PassportName);
            this.cboPassportType.ValueMember = nameof(ReadPassportTypeOutputDto.PassportId);
            this.cboPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            dic = new Dictionary<string, string>
            {
                { nameof(ReadGenderTypeInputDto.IsDelete) , "0" },
                { nameof(ReadGenderTypeInputDto.IgnorePaging) , "true" }
            };
            result = HttpHelper.Request(ApiConstants.Base_SelectGenderTypeAll, dic);
            var genderTypes = HttpHelper.JsonToModel<ListOutputDto<EnumDto>>(result.message);
            if (genderTypes.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectGenderTypeAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listSexType = genderTypes.listSource;
            this.cboCustoSex.DataSource = listSexType;
            this.cboCustoSex.DisplayMember = nameof(EnumDto.Description);
            this.cboCustoSex.ValueMember = nameof(EnumDto.Id);
            this.cboCustoSex.SelectedIndex = 0;
            #endregion

            double sum = 0;
            txtCustoNo.Text = ucRoom.rm_CustoNo;
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

            sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(stayDays.Source.StayDays) * room.RoomRent));

            lblDay.Text = Convert.ToString(Convert.ToInt32(stayDays.Source.StayDays));

            w = new CreateEnergyManagementInputDto()
            {
                InformationNumber = new UniqueCode().GetNewId("EM-"),
                IsDelete = 0,
                DataInsUsr = LoginInfo.WorkerNo,
                DataInsDate = DateTime.Now,
                CustomerNumber = txtCustoNo.Text,
                EndDate = Convert.ToDateTime(DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"))),
                PowerUsage = Convert.ToDecimal(Convert.ToInt32(stayDays.Source.StayDays) * 3 * 1),
                WaterUsage = Convert.ToDecimal(Convert.ToDouble(stayDays.Source.StayDays) * 80 * 0.002),
                RoomNumber = txtRoomNo.Text,
                Recorder = LoginInfo.WorkerNo,
                StartDate = Convert.ToDateTime(DateTime.Parse(dtpCheckTime.Text))
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
                txtCustoName.Text = customer?.Source.CustomerName;
                txtTel.Text = customer?.Source.CustomerPhoneNumber;
                cboCustoSex.SelectedValue = customer?.Source.CustomerGender ?? 0;
                cboCustoType.SelectedValue = customer.Source.CustomerType;
                cboPassportType.SelectedValue = customer.Source.PassportId;
                dtpBirth.Value = Convert.ToDateTime(customer.Source.DateOfBirth);
                txtPassportNum.Text = customer.Source.IdCardNumber;
            }
            catch
            {


            }


            #endregion

            #region 加载消费信息
            string RoomNo = txtRoomNo.Text;
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadSpendInputDto.RoomNumber) , RoomNo }
            };
            result = HttpHelper.Request(ApiConstants.Spend_SelectSpendByRoomNo, dic);
            var spendInfo = HttpHelper.JsonToModel<ListOutputDto<ReadSpendOutputDto>>(result.message);
            if (spendInfo.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Spend_SelectSpendByRoomNo}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvSpendList.AutoGenerateColumns = false;
            dgvSpendList.DataSource = spendInfo.listSource;
            double total = 0;
            if (dgvSpendList.Rows.Count == 0)
            {
                total = 0;
            }
            else
            {
                dic = new Dictionary<string, string>()
                {
                    { nameof(ReadSpendInputDto.RoomNumber) , RoomNo },
                    { nameof(ReadSpendInputDto.CustomerNumber) , CustoNo.Text.ToString() }
                };
                result = HttpHelper.Request(ApiConstants.Spend_SumConsumptionAmount, dic);
                var consumptionAmount = HttpHelper.JsonToModel<SingleOutputDto<ReadSpendOutputDto>>(result.message);
                if (consumptionAmount.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError($"{ApiConstants.Spend_SumConsumptionAmount}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                total = Convert.ToDouble(consumptionAmount.Source.ConsumptionAmount);
            }

            #endregion

            #region 加载水电费信息
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadEnergyManagementInputDto.RoomNo),txtRoomNo.Text.Trim()}
            };
            result = HttpHelper.Request(ApiConstants.EnergyManagement_SelectEnergyManagementInfo, dic);
            var energyManagements = HttpHelper.JsonToModel<ListOutputDto<ReadEnergyManagementOutputDto>>(result.message);
            if (energyManagements.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.EnergyManagement_SelectEnergyManagementInfo}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listWti = energyManagements.listSource;
            dgvWti.DataSource = listWti;
            dgvWti.AutoGenerateColumns = false;
            #endregion

            if (cboCustoType.Text == "钻石会员")
            {
                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.80).ToString()).ToString("#,##0.00");
                lblVIP.Text = "八折";
            }
            else if (cboCustoType.Text == "白金会员")
            {

                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.85).ToString()).ToString("#,##0.00");
                lblVIP.Text = "八五折";
            }
            else if (cboCustoType.Text == "黄金会员")
            {
                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.90).ToString()).ToString("#,##0.00");
                lblVIP.Text = "九折";
            }
            else if (cboCustoType.Text == "普通会员")
            {
                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.95).ToString()).ToString("#,##0.00");
                lblVIP.Text = "九五折";
            }
            else if (cboCustoType.Text == "普通用户")
            {
                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIP.Text = "不  打  折";

            }

            if (_loadingProgress != null)
            {
                _loadingProgress.Close();
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
            if (!txtReceipts.Text.IsNullOrEmpty() && Convert.ToDecimal(txtReceipts.Text) > Convert.ToDecimal(lblVIPPrice.Text))//判断实收金额是否为空以及是否小于应收金额
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    dic = new Dictionary<string, string>()
                    {
                        { nameof(ReadRoomInputDto.RoomNumber) , txtRoomNo.Text}
                    };
                    result = HttpHelper.Request(ApiConstants.Room_SelectRoomByRoomNo, dic);
                    var roomInfo = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);
                    if (roomInfo.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    ReadRoomOutputDto r = roomInfo.Source;//根据房间编号查询房间信息
                    string checktime = r.LastCheckInTime.ToString();//获取入住时间
                    if (dgvSpendList.Rows.Count == 0)
                    {
                        dic = new Dictionary<string, string>()
                        {
                            { nameof(ReadRoomInputDto.RoomNumber) , txtRoomNo.Text }
                        };
                        result = HttpHelper.Request(ApiConstants.Room_UpdateRoomByRoomNo, dic);
                        var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (response.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError("UpdateRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }

                        result = HttpHelper.Request(ApiConstants.EnergyManagement_InsertEnergyManagementInfo, HttpHelper.ModelToJson(w));
                        response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (response.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError("InsertEnergyManagementInfo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        this.Close();
                        UIMessageBox.Show("结算成功！", "系统提示", UIStyle.Green);
                        FrmRoomManager.Reload("");
                        FrmRoomManager._RefreshRoomCount();

                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "帮助" + txtCustoNo.Text + "进行了退房结算操作！", 3);
                        #endregion
                        scope.Complete();
                    }
                    else
                    {
                        dic = new Dictionary<string, string>()
                        {
                            { nameof(UpdateSpendInputDto.RoomNumber) , txtRoomNo.Text },
                            { nameof(UpdateSpendInputDto.ConsumptionTime) , checktime}
                        };
                        result = HttpHelper.Request(ApiConstants.Spend_UpdateMoneyState, dic);
                        var spendInfo = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (spendInfo.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError("UpdateMoneyState+接口服务异常，请提交Issue或尝试更新版本！");
                            UIMessageBox.Show("结算失败！", "系统提示", UIStyle.Red);
                            return;
                        }
                        dic = new Dictionary<string, string>()
                        {
                            { nameof(ReadRoomInputDto.RoomNumber) , txtRoomNo.Text }
                        };
                        result = HttpHelper.Request(ApiConstants.Room_UpdateRoomByRoomNo, dic);
                        var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (response.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError("UpdateRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        result = HttpHelper.Request(ApiConstants.EnergyManagement_InsertEnergyManagementInfo, HttpHelper.ModelToJson(w));
                        response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (response.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError("InsertEnergyManagementInfo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        UIMessageBox.Show("结算成功！", "系统提示", UIStyle.Green);
                        FrmRoomManager.Reload("");
                        FrmRoomManager._RefreshRoomCount();
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "帮助" + txtCustoNo.Text + "进行了退房结算操作！", 3);
                        #endregion
                        scope.Complete();
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                UIMessageBox.Show("实收金额不能为空或实收金额不能小于折后金额！", "系统提示", UIStyle.Orange);
                return;
            }
        }
        #endregion
    }
}
