/*
 * MIT License
 *Copyright (c) 2021~2024 易开元(EOM)

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
using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using EOM.TSHotelManager.FormUI.AppUserControls;
using EOM.TSHotelManager.FormUI.Properties;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmRoomManager : Form
    {
        public static string co_CustoNo;
        public static string co_RoomNo;
        public static string co_CustoName;
        public static string co_CheckTime;
        public static string co_Day;

        public delegate void ReLoadRoomList(string typeName);

        public delegate void ReadRoomInfo();

        //定义委托类型的变量
        public static ReadRoomInfo ReadInfo;
        public static ReLoadRoomList Reload;

        public FrmRoomManager()
        {
            InitializeComponent();
            ReadInfo = LoadRoomInfo;
            Reload = LoadData;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        List<Room> romsty = null;
        ucRoom room = null;
        string EmptyCount;
        string OccupiedCount;
        string UnderRepairCount;
        string ReservedCount;
        string DirtyCount;
        #region 房间加载事件方法
        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            LoadRoomInfo();
            LoadRoomCount();
            LoadRoomState();
            LoadRoomTypes();
            LoadData();
        }
        #endregion

        private void LoadRoomState()
        {
            muRoomState.Items.Clear();

            var stateList = RoomStateConstant.GetAll().ToList();
            MenuItem menuItem = null;
            if (!stateList.IsNullOrEmpty())
            {
                foreach (var item in stateList)
                {
                    menuItem = new MenuItem
                    {
                        Text = item.Description
                    };
                    menuItem.Tag = item.Code;

                    var roomState = RoomStateConstant.GetConstantByCode(item.Code);

                    if (roomState != null)
                    {
                        menuItem.Text += roomState.Code switch
                        {
                            var code when code == RoomStateConstant.Empty.Code => "(" + EmptyCount + ")",
                            var code when code == RoomStateConstant.Occupied.Code => "(" + OccupiedCount + ")",
                            var code when code == RoomStateConstant.UnderRepair.Code => "(" + UnderRepairCount + ")",
                            var code when code == RoomStateConstant.Dirty.Code => "(" + DirtyCount + ")",
                            var code when code == RoomStateConstant.Reserved.Code => "(" + ReservedCount + ")",
                            _ => string.Empty
                        };


                        menuItem.Icon = roomState.Code switch
                        {
                            var code when code == RoomStateConstant.Empty.Code => Resources.可住状态,
                            var code when code == RoomStateConstant.Occupied.Code => Resources.已住状态,
                            var code when code == RoomStateConstant.UnderRepair.Code => Resources.维修状态,
                            var code when code == RoomStateConstant.Dirty.Code => Resources.脏房状态,
                            var code when code == RoomStateConstant.Reserved.Code => Resources.预约状态,
                            _ => null
                        };
                    }
                    muRoomState.Items.Add(menuItem);
                }
            }

        }

        private void LoadRoomCount()
        {
            result = HttpHelper.Request("Room/SelectCanUseRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCanUseRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
            }
            EmptyCount = result.message;
            result = HttpHelper.Request("Room/SelectNotUseRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNotUseRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
            }
            OccupiedCount = result.message;
            result = HttpHelper.Request("Room/SelectNotClearRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNotClearRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
            }
            DirtyCount = result.message;
            result = HttpHelper.Request("Room/SelectFixingRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectFixingRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
            }
            UnderRepairCount = result.message;
            result = HttpHelper.Request("Room/SelectReseredRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectReseredRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
            }
            ReservedCount = result.message;
        }

        private void LoadRoomTypes()
        {
            dic = new Dictionary<string, string>()
            {
                { "isDelete","0"}
            };
            result = HttpHelper.Request("RoomType/SelectRoomTypesAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomTypesAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listRoomTypes = HttpHelper.JsonToList<RoomType>(result.message);

            flpRoomTypes.Clear();
            ucRoomType ucRoomType = null;
            ucRoomType = new ucRoomType();
            ucRoomType.btnRoomType.Text = "全部房间";
            ucRoomType.btnRoomType.Name = "btnAll";
            ucRoomType.btnRoomType.Click += btnAll_Click;
            flpRoomTypes.Controls.Add(ucRoomType);
            foreach (var type in listRoomTypes)
            {
                ucRoomType = new ucRoomType();
                ucRoomType.btnRoomType.Text = type.RoomName;
                ucRoomType.btnRoomType.Name = Convert.ToString(type.Roomtype);
                ucRoomType.btnRoomType.Click += btnRoomType_Click;
                flpRoomTypes.Controls.Add(ucRoomType);
            }
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            if (sender is UIButton button)
            {
                string buttonName = button.Text;
                LoadData(buttonName);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadRoomInfo()
        {
            lblRoomNo.Text = ucRoom.co_RoomNo;
            lblCustoName.Text = ucRoom.co_CustoName;
            lblRoomPosition.Text = ucRoom.co_RoomPosition;
            lblCheckTime.Text = ucRoom.co_CheckTime == null ? "" : Convert.ToDateTime(ucRoom.co_CheckTime).ToString("yyyy-MM-dd");
            lblRoomState.Text = ucRoom.co_RoomState;
        }

        private void LoadData(string typeName = "")
        {
            flpRoom.Controls.Clear();
            if (string.IsNullOrEmpty(typeName))
            {
                result = HttpHelper.Request("Room/SelectRoomAll");
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectRoomAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                romsty = HttpHelper.JsonToList<Room>(result.message);
            }
            else
            {
                dic = new Dictionary<string, string>()
                {
                    { "TypeName",typeName}
                };
                result = HttpHelper.Request("Room/SelectRoomByTypeName", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectRoomByTypeName+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                romsty = HttpHelper.JsonToList<Room>(result.message);
            }
            for (int i = 0; i < romsty.Count; i++)
            {
                room = new ucRoom();
                room.btnRoom.Text = string.Format("{0}\n\n{1}\n\n{2}", romsty[i].RoomName, romsty[i].RoomNo, romsty[i].CustoName ?? "      ");
                room.lblMark = string.Empty;
                room.romRoomInfo = romsty[i];
                room.romCustoInfo = new Custo { CustoNo = romsty[i].CustoNo, CustoName = romsty[i].CustoName };
                flpRoom.Controls.Add(room);
            }
            lblRoomNo.Text = "";
            lblRoomPosition.Text = "";
            lblRoomState.Text = "";
            lblCustoName.Text = "";
            lblCheckTime.Text = "";
            LoadRoomInfo();
        }

        private void LoadRoomByState(int stateid)
        {
            flpRoom.Controls.Clear();
            dic = new Dictionary<string, string>()
            {
                { "stateid",stateid.ToString()}
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomState", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            romsty = HttpHelper.JsonToList<Room>(result.message);
            for (int i = 0; i < romsty.Count; i++)
            {
                room = new ucRoom();
                room.btnRoom.Text = string.Format("{0}\n\n{1}\n\n{2}", romsty[i].RoomName, romsty[i].RoomNo, romsty[i].CustoName);
                room.lblMark = string.Empty;
                room.romRoomInfo = romsty[i];
                room.romCustoInfo = new Custo { CustoNo = romsty[i].CustoNo, CustoName = romsty[i].CustoName };
                flpRoom.Controls.Add(room);
            }
            lblRoomNo.Text = "";
            lblRoomPosition.Text = "";
            lblRoomState.Text = "";
            lblCustoName.Text = "";
            lblCheckTime.Text = "";
        }

        private void muRoomState_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            flpRoom.Controls.Clear();

            var roomState = RoomStateConstant.GetConstantByCode(e.Value.Tag as string);

            if (roomState != null)
            {
                switch (roomState.Code)
                {
                    case var code when code == RoomStateConstant.Empty.Code:
                        LoadRoomByState(0);
                        break;
                    case var code when code == RoomStateConstant.Occupied.Code:
                        LoadRoomByState(1);
                        break;
                    case var code when code == RoomStateConstant.UnderRepair.Code:
                        LoadRoomByState(2);
                        break;
                    case var code when code == RoomStateConstant.Dirty.Code:
                        LoadRoomByState(3);
                        break;
                    case var code when code == RoomStateConstant.Reserved.Code:
                        LoadRoomByState(4);
                        break;
                }
            }
        }
    }
}