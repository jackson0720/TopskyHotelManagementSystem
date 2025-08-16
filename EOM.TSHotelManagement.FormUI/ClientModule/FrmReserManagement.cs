﻿/*
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
using jvncorelib.CodeLib;
using jvncorelib.EntityLib;
using System.Transactions;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmReserManager : Window
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserManager));
        public FrmReserManager()
        {
            InitializeComponent();
            whReserRoomManagement = new ucWindowHeader("房间预约管理", string.Empty, (Image)resources.GetObject("FrmReserManager.Icon")!);
            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void btnReser_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                string reserid = new UniqueCode().GetNewId("R-");
                CreateReserInputDto reser = new CreateReserInputDto()
                {
                    ReservationId = reserid,
                    CustomerName = txtCustoName.Text.Trim(),
                    ReservationPhoneNumber = txtCustoTel.Text.Trim(),
                    ReservationChannel = cboReserWay.Text,
                    ReservationRoomNumber = cboReserRoomNo.Text,
                    ReservationStartDate = dtpStartDate.Value ?? dtpStartDate.Value.GetValueOrDefault(),
                    ReservationEndDate = dtpEndDate.Value ?? dtpEndDate.Value.GetValueOrDefault(),
                    DataInsUsr = LoginInfo.WorkerNo,
                    DataInsDate = DateTime.Now
                };
                UpdateRoomInputDto room = new UpdateRoomInputDto()
                {
                    RoomNumber = cboReserRoomNo.Text,
                    RoomStateId = (int)RoomState.Reserved,
                    DataInsDate = DateTime.Now,
                    DataInsUsr = LoginInfo.WorkerNo
                };
                result = HttpHelper.Request(ApiConstants.Reser_InsertReserInfo, reser.ModelToJson());
                var response = HttpHelper.JsonToModel<BaseResponse>(result.message);
                if (response.Code != BusinessStatusCode.Success)
                {
                    AntdUI.Modal.open(this, UIMessageConstant.Error, $"{ApiConstants.Reser_InsertReserInfo}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                result = HttpHelper.Request(ApiConstants.Room_UpdateRoomInfoWithReser, room.ModelToJson());
                response = HttpHelper.JsonToModel<BaseResponse>(result.message);
                if (response.Code != BusinessStatusCode.Success)
                {
                    AntdUI.Modal.open(this, UIMessageConstant.Error, $"{ApiConstants.Room_UpdateRoomInfoWithReser}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                AntdUI.Modal.open(this, UIMessageConstant.Success, "预约成功！请在指定时间内进行登记入住");
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "帮助" + txtCustoTel.Text + "进行了预订房间操作！", Common.Core.LogLevel.Normal);
                #endregion
                scope.Complete();
                FrmRoomManager.Reload("");
                this.Close();
            }
        }

        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            result = HttpHelper.Request(ApiConstants.Room_SelectCanUseRoomAll);
            var response = HttpHelper.JsonToModel<ListOutputDto<ReadRoomOutputDto>>(result.message);
            if (response.Code != BusinessStatusCode.Success)
            {
                AntdUI.Modal.open(this, UIMessageConstant.Error, $"{ApiConstants.Room_SelectCanUseRoomAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboReserRoomNo.Items.AddRange(response.Data.Items.Select(item => new AntdUI.SelectItem(item.RoomNumber)).ToArray());
            cboReserRoomNo.Text = ucRoom.co_RoomNo;
            dtpStartDate.Value = Convert.ToDateTime(DateTime.Now);
        }

        private void btnReserList_Click(object sender, EventArgs e)
        {
            FrmReserList frm = new FrmReserList();
            frm.Show();
        }

        private void phReserRoomManagement_Click(object sender, EventArgs e)
        {

        }
    }
}