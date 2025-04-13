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

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmRoomStateManager : UIForm
    {
        public FrmRoomStateManager()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        #region 窗体加载事件
        private void FrmRoomStateManager_Load(object sender, EventArgs e)
        {
            txtRoomNo.Text = ucRoom.rm_RoomNo;
            result = HttpHelper.Request("Base/SelectRoomStateAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomStateAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboState.DataSource = HttpHelper.JsonToList<EnumDto>(result.message);
            cboState.DisplayMember = nameof(EnumDto.Description);
            cboState.ValueMember = nameof(EnumDto.Id);
            cboState.SelectedIndex = 0;
        }
        #endregion

        #region 确定按钮点击事件
        private void btnOk_Click(object sender, EventArgs e)
        {
            var helper = new EnumHelper();
            switch (cboState.SelectedValue)
            {
                case (int)RoomState.Occupied:
                    UIMessageBox.Show("不能设置为已住状态！", "来自小T的提示", UIStyle.Orange);
                    break;
                case (int)RoomState.Vacant:
                case (int)RoomState.Maintenance:
                case (int)RoomState.Dirty:
                case (int)RoomState.Reserved:
                    dic = new Dictionary<string, string>()
                    {
                        { nameof(ReadRoomInputDto.RoomNumber) , txtRoomNo.Text },
                        { nameof(ReadRoomInputDto.RoomStateId) , cboState.SelectedValue.ToString() }
                    };
                    result = HttpHelper.Request("Room/UpdateRoomStateByRoomNo", dic);
                    var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                    if (response.StatusCode != StatusCodeConstants.Success)
                    {
                        UIMessageBox.ShowError("UpdateRoomStateByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    UIMessageBox.Show("房间" + txtRoomNo.Text + "成功修改为" + cboState.Text, "修改提示", UIStyle.Green);
                    FrmRoomManager.Reload("");
                    FrmRoomManager._RefreshRoomCount();
                    this.Close();
                    break;
                default:
                    UIMessageBox.Show("请选择房间状态", "来自小T的提示", UIStyle.Orange);
                    break;
            }

        }
        #endregion
    }
}
