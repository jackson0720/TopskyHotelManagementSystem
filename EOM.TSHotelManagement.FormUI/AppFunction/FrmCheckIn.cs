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
using jvncorelib.EntityLib;
using Sunny.UI;
using System.Transactions;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmCheckIn : UIEditForm
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        ResponseMsg result = new ResponseMsg();

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            txtRoomNo.Text = ucRoom.rm_RoomNo;
            Dictionary<string, string> pairs = new Dictionary<string, string>
            {
                { nameof(ReadRoomInputDto.RoomNumber), txtRoomNo.Text.Trim()! }
            };
            result = HttpHelper.Request(ApiConstants.Room_SelectRoomByRoomNo, pairs);
            var response = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message!);
            if (response.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageTip.ShowError($"{ApiConstants.Room_SelectRoomByRoomNo}+接口服务异常，请提交issue");
                return;
            }
            ReadRoomOutputDto r = response.Source;
            result = HttpHelper.Request(ApiConstants.RoomType_SelectRoomTypeByRoomNo, pairs);
            var roomTypeResponse = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomTypeOutputDto>>(result.message!);
            if (roomTypeResponse.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageTip.ShowError($"{ApiConstants.RoomType_SelectRoomTypeByRoomNo}+接口服务异常，请提交issue");
                return;
            }
            ReadRoomTypeOutputDto t = roomTypeResponse.Source;
            txtType.Text = t.RoomTypeName;
            txtMoney.Text = r.RoomRent.ToString();
            txtRoomPosition.Text = r.RoomLocation;
            txtState.Text = r.RoomState;
            txtDeposit.Text = r.RoomDeposit.ToString();
            pairs = new Dictionary<string, string>
            {
                { nameof(ReadCustomerInputDto.IgnorePaging) , "true" },
                { nameof(ReadCustomerInputDto.IsDelete) , "0" }
            };
            result = HttpHelper.Request(ApiConstants.Customer_SelectCustomers, pairs);
            var customerResponse = HttpHelper.JsonToModel<ListOutputDto<ReadCustomerOutputDto>>(result.message!);
            if (customerResponse.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageTip.ShowError($"{ApiConstants.Customer_SelectCustomers}+接口服务异常，请提交issue");
                return;
            }
            var custoList = customerResponse.listSource;
            if (custoList != null && custoList != null)
            {
                var ctos = custoList.Select(custo => custo.CustomerNumber).ToArray();
                txtCustoNo.AutoCompleteCustomSource.AddRange(ctos);
            }
            try
            {
                txtCustoNo.Text = "";
            }
            catch
            {
                txtCustoNo.Text = ucRoom.rm_CustoNo;
            }
        }

        private void txtCustoNo_Validated(object sender, EventArgs e)
        {
            try
            {
                ValidateAndUpdateCustomerInfo();
            }
            catch (Exception ex)
            {
                UIMessageTip.ShowError($"接口服务异常，请提交issue: {ex.Message}", 3000);
            }
        }

        private void ValidateAndUpdateCustomerInfo()
        {
            // 获取会员规则列表
            var dic = new Dictionary<string, string>
            {
                { nameof(ReadVipLevelRuleInputDto.IgnorePaging), "true" },
                { nameof(ReadVipLevelRuleInputDto.IsDelete), "0" }
            };
            var result = HttpHelper.Request(ApiConstants.VipLevelRule_SelectVipRuleList, dic);
            var response = HttpHelper.JsonToModel<ListOutputDto<ReadVipLevelRuleOutputDto>>(result.message!);
            if (response.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageTip.ShowError($"{ApiConstants.VipLevelRule_SelectVipRuleList}+接口服务异常，请提交issue: {response.Message}", 3000);
            }

            var listVipRule = response.listSource
                .OrderBy(a => a.RuleValue)
                .Distinct()
                .ToList();

            // 查询用户消费记录
            var user = new Dictionary<string, string> { { nameof(ReadSpendInputDto.CustomerNumber), txtCustoNo.Text.Trim() } };
            result = HttpHelper.Request(ApiConstants.Spend_SeletHistorySpendInfoAll, user);
            var customerSpends = HttpHelper.JsonToModel<ListOutputDto<ReadSpendOutputDto>>(result.message!);
            if (customerSpends.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageTip.ShowError($"{ApiConstants.Spend_SeletHistorySpendInfoAll}+接口服务异常，请提交issue: {response.Message}", 3000);
            }

            var listCustoSpend = customerSpends.listSource;
            if (!listCustoSpend.IsNullOrEmpty())
            {
                var spendAmount = listCustoSpend.Sum(a => a.ConsumptionAmount);
                var new_type = listVipRule
                    .Where(vipRule => spendAmount >= vipRule.RuleValue)
                    .OrderByDescending(vipRule => vipRule.RuleValue)
                    .FirstOrDefault()?.VipLevelId ?? 0;

                // 如果会员等级有变，更新会员等级
                if (new_type != 0)
                {
                    result = HttpHelper.Request(ApiConstants.Customer_UpdCustomerTypeByCustoNo, HttpHelper.ModelToJson(new UpdateCustomerInputDto { CustomerNumber = txtCustoNo.Text.Trim(), CustomerType = new_type }));
                    var updateResponse = HttpHelper.JsonToModel<BaseOutputDto>(result.message!);
                    if (updateResponse.StatusCode != StatusCodeConstants.Success)
                    {
                        throw new Exception($"{ApiConstants.Customer_UpdCustomerTypeByCustoNo}+接口服务异常");
                    }
                }
            }

            // 获取用户卡片信息
            if (!string.IsNullOrEmpty(txtCustoNo.Text))
            {
                user = new Dictionary<string, string> { { nameof(ReadCustomerInputDto.CustomerNumber), txtCustoNo.Text.Trim() } };
                result = HttpHelper.Request(ApiConstants.Customer_SelectCustoByInfo, user);
                var customerResponse = HttpHelper.JsonToModel<SingleOutputDto<ReadCustomerOutputDto>>(result.message!);
                if (customerResponse.StatusCode != StatusCodeConstants.Success)
                {
                    throw new Exception($"{ApiConstants.Customer_SelectCustoByInfo}+接口服务异常");
                }

                var custo = customerResponse.Source;
                txtCustoName.Text = custo?.CustomerNumber ?? "";
                txtCustoTel.Text = custo?.CustomerPhoneNumber ?? "";
                txtCustoType.Text = custo?.CustomerTypeName ?? "";
            }
        }

        private void FrmCheckIn_ButtonOkClick(object sender, EventArgs e)
        {
            var user = new Dictionary<string, string> { { nameof(ReadCustomerInputDto.CustomerNumber), txtCustoNo.Text.Trim() } };
            result = HttpHelper.Request(ApiConstants.Customer_SelectCustoByInfo, user);
            var customerResponse = HttpHelper.JsonToModel<SingleOutputDto<ReadCustomerOutputDto>>(result.message!);
            if (customerResponse.StatusCode != StatusCodeConstants.Success)
            {
                throw new Exception($"{ApiConstants.Customer_SelectCustoByInfo}+接口服务异常");
            }

            var custo = customerResponse.Source;
            if (!custo.IsNullOrEmpty())
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    UpdateRoomInputDto r = new UpdateRoomInputDto()
                    {
                        LastCheckInTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                        CustomerNumber = txtCustoNo.Text,
                        RoomStateId = (int)RoomState.Occupied,
                        RoomNumber = txtRoomNo.Text,
                        DataChgUsr = LoginInfo.WorkerNo
                    };
                    result = HttpHelper.Request(ApiConstants.Room_UpdateRoomInfo, HttpHelper.ModelToJson(r));
                    var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message!);
                    if (response.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageTip.ShowError($"{ApiConstants.Room_UpdateRoomInfo}+接口服务异常，请提交issue");
                        UIMessageBox.Show("登记入住失败！", "登记提示", UIStyle.Red);
                        return;
                    }
                    UIMessageBox.Show("登记入住成功！", "登记提示", UIStyle.Green);
                    txtCustoNo.Text = "";
                    FrmRoomManager.Reload("");
                    FrmRoomManager._RefreshRoomCount();
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "帮助" + r.CustomerNumber + "进行了入住操作！", 1);
                    #endregion
                    scope.Complete();
                    this.Close();
                    return;
                }
            }
            else
            {
                UIMessageBox.Show("所选客户不存在！", "系统提示", UIStyle.Red);
            }
        }

        private void FrmCheckIn_ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
