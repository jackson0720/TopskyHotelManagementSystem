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
using EOM.TSHotelManagement.Shared;
using Sunny.UI;
using System.Transactions;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmChangeRoom : UIForm
    {
        public FrmChangeRoom()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;
        static bool firstLoad = true;

        private void FrmChangeRoom_Load(object sender, EventArgs e)
        {
            result = HttpHelper.Request(ApiConstants.Room_SelectCanUseRoomAll);
            var datas = HttpHelper.JsonToModel<ListOutputDto<ReadRoomOutputDto>>(result.message);
            if (datas.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Room_SelectCanUseRoomAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboRoomList.DataSource = datas;
            cboRoomList.DisplayMember = nameof(ReadRoomOutputDto.RoomNumber);
            cboRoomList.ValueMember = nameof(ReadRoomOutputDto.RoomNumber);
            firstLoad = false;
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            double sum = 0;
            string lbu = LoginInfo.WorkerName;
            string rno = ucRoom.co_RoomNo.ToString();
            string nrno = cboRoomList.Text;

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    #region 发起转房和转移消费以及添加消费的请求

                    dic = new Dictionary<string, string>()
                    {
                        { nameof(ReadRoomInputDto.RoomNumber) , rno }
                    };

                    result = HttpHelper.Request(ApiConstants.Room_SelectRoomByRoomNo, dic);
                    var data = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);
                    if (data.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError($"{ApiConstants.Room_SelectRoomByRoomNo}+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    var room = data.Source;
                    var checkInRoom = new UpdateRoomInputDto()
                    {
                        RoomNumber = nrno,
                        CustomerNumber = ucRoom.co_CustoNo,
                        RoomStateId = (int)RoomState.Occupied,
                        LastCheckInTime = Convert.ToDateTime(DateTime.Now),
                        DataChgUsr = LoginInfo.WorkerNo,
                        DataChgDate = DateTime.Now
                    };
                    result = HttpHelper.Request(ApiConstants.Room_DayByRoomNo, dic);
                    data = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);
                    if (data.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError($"{ApiConstants.Room_DayByRoomNo}+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(data.Source.StayDays) * room.RoomRent));

                    var insertSpend = new CreateSpendInputDto()
                    {
                        RoomNumber = cboRoomList.Text,
                        ProductName = "居住" + rno + "共" + Convert.ToInt32(result.message) + "天",
                        ConsumptionQuantity = Convert.ToInt32(result.message),
                        CustomerNumber = ucRoom.co_CustoNo,
                        ProductPrice = room.RoomRent,
                        ConsumptionAmount = Convert.ToDecimal(sum),
                        ConsumptionTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                        SettlementStatus = SpendConsts.UnSettle,
                    };

                    result = HttpHelper.Request(ApiConstants.Room_UpdateRoomInfo, HttpHelper.ModelToJson(checkInRoom));
                    var httpResult = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                    if (httpResult.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError($"{ApiConstants.Room_UpdateRoomInfo}+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    result = HttpHelper.Request(ApiConstants.Room_UpdateRoomByRoomNo, dic);
                    httpResult = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                    if (httpResult.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError($"{ApiConstants.Room_UpdateRoomByRoomNo}+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    result = HttpHelper.Request(ApiConstants.Spend_SelectSpendByCustoNo, dic);
                    var datas = HttpHelper.JsonToModel<ListOutputDto<ReadSpendOutputDto>>(result.message);
                    if (datas.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError($"{ApiConstants.Spend_SelectSpendByCustoNo}+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    var result3 = datas.listSource;
                    if (result3.Count != 0)
                    {
                        var spend = new UpdateSpendInputDto() { RoomNumber = nrno, CustomerNumber = ucRoom.CustoNo };
                        result = HttpHelper.Request(ApiConstants.Spend_UpdateSpendInfoByRoomNo, HttpHelper.ModelToJson(spend));
                        httpResult = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                        if (httpResult.StatusCode != StatusCodeConstants.Success)
                        {
                            UIMessageBox.ShowError($"{ApiConstants.Spend_UpdateSpendInfoByRoomNo}+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                    }

                    #endregion

                    UIMessageBox.ShowSuccess("转房成功");
                    result = HttpHelper.Request(ApiConstants.Spend_InsertSpendInfo, HttpHelper.ModelToJson(insertSpend));
                    httpResult = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                    if (httpResult.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError($"{ApiConstants.Spend_InsertSpendInfo}+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    FrmRoomManager.Reload("");
                    FrmRoomManager._RefreshRoomCount();
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + ucRoom.CustoNo + "于" + Convert.ToDateTime(DateTime.Now) + "进行了换房！", 2);
                    #endregion
                    scope.Complete();
                    this.Close();
                }
                catch (Exception)
                {
                    UIMessageBox.ShowError("转房失败");
                }
            }
        }

        private void cboRoomList_TextChanged(object sender, EventArgs e)
        {
            string str = firstLoad ? ucRoom.RoomNo.ToString() : cboRoomList.SelectedValue.ToString();
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadRoomTypeInputDto.RoomNumber) , str }
            };
            result = HttpHelper.Request(ApiConstants.RoomType_SelectRoomTypeByRoomNo, dic);
            var data = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomTypeOutputDto>>(result.message);
            if (data.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.RoomType_SelectRoomTypeByRoomNo}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var roomType = data.Source;
            lblRoomType.Text = roomType.RoomTypeName;
        }
    }
}
