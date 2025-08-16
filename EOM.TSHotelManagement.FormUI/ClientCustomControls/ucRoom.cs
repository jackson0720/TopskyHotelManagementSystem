using EOM.TSHotelManagement.Common;
using EOM.TSHotelManagement.Common.Contract;
using EOM.TSHotelManagement.Common.Util;
using EOM.TSHotelManagement.FormUI.Properties;
using EOM.TSHotelManagement.Shared;
using jvncorelib.EntityLib;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class ucRoom : UserControl
    {
        private LoadingProgress _loadingProgress;
        private FrmRoomManager _fromRoomManagement;
        public ucRoom(FrmRoomManager frmRoomManagement)
        {
            InitializeComponent();
            _loadingProgress = new LoadingProgress();
            _fromRoomManagement = frmRoomManagement;
        }


        ResponseMsg result = new ResponseMsg();
        Dictionary<string, string> getParam = new Dictionary<string, string>();
        string postParam = string.Empty;

        #region 存放房间信息类
        //用于结算、转房显示信息用
        public static string? rm_RoomNo;
        public static string? rm_CustoNo;
        public static string? rm_RoomType;
        public static string? rm_RoomMoney;
        public static int rm_RoomStateId;

        public static string? co_RoomNo;
        public static string? co_CustoNo;
        public static DateTime? co_CheckTime;
        public static string? co_RoomPosition;
        public static string? co_RoomState;
        public static string? co_CustoName;
        public static string? co_CustoType;
        #endregion

        #region 存放用户信息类
        //用于房态图、查看用户信息用
        public static string? us_CustoNo;
        public static string? us_RoomNo;
        public static string? us_CustoName;
        public static string? us_CustoBirthday;
        public static string? us_CustoSex;
        public static string? us_CustoTel;
        public static int us_CustoPassportType;
        public static string? us_CustoAddress;
        public static int us_CustoType;
        public static string? us_CustoID;
        #endregion

        #region 实例化房态图的房间信息
        public string romTypeName;
        public ReadRoomOutputDto romRoomInfo { get; set; }
        public ReadCustomerOutputDto romCustoInfo { get; set; }
        #endregion

        public string lblMark { get; set; }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (lblMark == "Mark")
            {
                return;
            }
            LoadRoomInfo();
            FrmRoomManager.ReadInfo();
        }

        #region 房态图圆角代码
        public GraphicsPath GetRoundRectPath(RectangleF rect, float radius)
        {
            return GetRoundRectPath(rect.X, rect.Y, rect.Width, rect.Height, radius);
        }
        public GraphicsPath GetRoundRectPath(float X, float Y, float width, float height, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(X + radius, Y, (X + width) - (radius * 2f), Y);
            path.AddArc((X + width) - (radius * 2f), Y, radius * 2f, radius * 2f, 270f, 100f);
            path.AddLine((float)(X + width), (float)(Y + radius), (float)(X + width), (float)((Y + height) - (radius * 2f)));
            path.AddArc((float)((X + width) - (radius * 2f)), (float)((Y + height) - (radius * 2f)), (float)(radius * 2f), (float)(radius * 2f), 0f, 100f);
            path.AddLine((float)((X + width) - (radius * 2f)), (float)(Y + height), (float)(X + radius), (float)(Y + height));
            path.AddArc(X, (Y + height) - (radius * 2f), radius * 2f, radius * 2f, 100f, 100f);
            path.AddLine(X, (Y + height) - (radius * 2f), X, Y + radius);
            path.AddArc(X, Y, radius * 2f, radius * 2f, 180f, 100f);
            path.CloseFigure();
            return path;
        }

        //窗体圆角代码开始
        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 22, this.Width, this.Height - 22);
            //this.Left-10,this.Top-10,this.Width-10,this.Height-10);                 
            FormPath = GetRoundedRectPath(rect, 30);
            this.Region = new Region(FormPath);
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            //   左上角   
            path.AddArc(arcRect, 180, 90);
            //   右上角   
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            //   右下角   
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            //   左下角   
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(System.EventArgs e)
        {
            this.Region = null;
            SetWindowRegion();
        }
        #endregion

        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
       IntPtr hwnd,
       int nIndex,
       uint dwNewLong
       );
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
       IntPtr hwnd,
       int nIndex
       );
        /// <summary>
        /// 使窗口有鼠标穿透功能
        /// </summary>
        public void CanPenetrate()
        {
            uint intExTemp = GetWindowLong(this.Handle, GWL_EXSTYLE);
            uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }

        public void LoadRoomInfo()
        {
            co_RoomNo = romRoomInfo.RoomNumber;
            co_CustoNo = romCustoInfo.CustomerNumber;
            co_CustoName = romCustoInfo.CustomerName;
            romTypeName = romRoomInfo.RoomName;
            co_CheckTime = romRoomInfo.LastCheckInTime;
            co_RoomPosition = romRoomInfo.RoomLocation;
            co_RoomState = romRoomInfo.RoomState;

        }

        private static List<string>? roomInfo = null;

        private void ucRoom_Load(object sender, EventArgs e)
        {
            this.CanPenetrate();
            this.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.Width, this.Height), 6f));
            if (romCustoInfo != null)
            {
                us_CustoNo = romCustoInfo.CustomerNumber;
                us_CustoName = romCustoInfo.CustomerName;
                us_CustoSex = romCustoInfo.CustomerGender == 1 ? "男" : "女";
                us_CustoTel = romCustoInfo.CustomerPhoneNumber;
                us_CustoID = romCustoInfo.IdCardNumber;
                us_CustoBirthday = romCustoInfo.DateOfBirth == default ? "" : Convert.ToDateTime(romCustoInfo.DateOfBirth).ToString();
                us_CustoPassportType = Convert.ToInt32(romCustoInfo.PassportId);
                us_CustoType = romCustoInfo.CustomerType;
                us_CustoAddress = romCustoInfo.CustomerAddress;
            }
            switch (romRoomInfo.RoomStateId)
            {
                case (int)Common.Core.RoomState.Vacant:
                    btnRoom.BackgroundImage = Resources.可住状态;
                    break;
                case (int)Common.Core.RoomState.Occupied:
                    btnRoom.BackgroundImage = Resources.已住状态;
                    break;
                case (int)Common.Core.RoomState.Maintenance:
                    btnRoom.BackgroundImage = Resources.维修状态;
                    break;
                case (int)Common.Core.RoomState.Dirty:
                    btnRoom.BackgroundImage = Resources.脏房状态;
                    break;
                case (int)Common.Core.RoomState.Reserved:
                    btnRoom.BackgroundImage = Resources.预约状态;
                    break;
            }
            btnRoom.BackgroundImageLayout = AntdUI.TFit.Cover;
        }

        ReadRoomOutputDto r;
        private void tsmiReserRoom_Click(object sender, EventArgs e)
        {
            FrmReserManager frm = new FrmReserManager();
            frm.ShowDialog();
        }
        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {
            if (lblMark == "Mark")
            {
                e.Cancel = true;
                return;
            }
            var roomText = btnRoom.Text?.Split("\n\n");
            if (roomText == null || roomText.Length < 2)
            {
                AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, "房间信息不完整！");
                return;
            }
            getParam = new Dictionary<string, string>
            {
                { nameof(ReadRoomInputDto.RoomNumber), roomText[1] }
            };
            result = HttpHelper.Request(ApiConstants.Room_SelectRoomByRoomNo, getParam);
            var response = HttpHelper.JsonToModel<SingleOutputDto<ReadRoomOutputDto>>(result.message);

            if (response.Code != BusinessStatusCode.Success)
            {
                AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, $"{ApiConstants.Room_SelectRoomByRoomNo}+接口服务异常！");
                return;
            }
            r = response.Data;
            if (r.RoomStateId == (int)Common.Core.RoomState.Vacant)
            {
                tsmiCheckIn.Enabled = true;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = true;
            }
            else if (r.RoomStateId == (int)Common.Core.RoomState.Occupied)
            {
                tsmiCheckIn.Enabled = false;
                tsmiCheckOut.Enabled = true;
                tsmiSelectUserInfo.Enabled = true;
                tsmiChangeState.Enabled = false;
                tsmiChangeRoom.Enabled = true;
                tsmiReserRoom.Enabled = false;
            }
            else if (r.RoomStateId == (int)Common.Core.RoomState.Dirty || r.RoomStateId == (int)Common.Core.RoomState.Maintenance)
            {
                tsmiCheckIn.Enabled = false;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = false;
            }
            else
            {
                tsmiCheckIn.Enabled = true;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = false;
            }
        }

        private void tsmiCheckIn_Click(object sender, EventArgs e)
        {
            if (romCustoInfo != null && romRoomInfo != null)
            {
                if (r.RoomStateId == new EnumHelper().GetEnumValue(Common.Core.RoomState.Reserved))
                {
                    rm_CustoNo = romCustoInfo.CustomerNumber;
                    rm_RoomNo = romRoomInfo.RoomNumber;
                    rm_RoomType = romRoomInfo.RoomName;
                    rm_RoomMoney = Convert.ToDecimal(romRoomInfo.RoomRent).ToString();
                    rm_RoomStateId = (int)Common.Core.RoomState.Reserved;
                    AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, "欢迎入住，请先注册客户信息！");
                    FrmReserList frm = new FrmReserList();
                    frm.ShowDialog();
                    return;
                }
                else
                {
                    rm_CustoNo = romCustoInfo.CustomerNumber;
                    rm_RoomNo = romRoomInfo.RoomNumber;
                    rm_RoomType = romRoomInfo.RoomName;
                    rm_RoomMoney = Convert.ToDecimal(romRoomInfo.RoomRent).ToString();
                    FrmCheckIn frm = new FrmCheckIn();
                    frm.ShowDialog();
                }
            }
            else
            {
                AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, "房间信息不完整！");
                return;
            }
        }

        private void tsmiCheckOut_Click(object sender, EventArgs e)
        {
            rm_CustoNo = romRoomInfo.CustomerNumber;
            rm_RoomNo = romRoomInfo.RoomNumber;
            rm_RoomType = romRoomInfo.RoomName;
            FrmCheckOutForm frm = new FrmCheckOutForm(_loadingProgress);
            frm.ShowDialog(this);
        }

        public static string? RoomNo;
        public static string? CustoNo;
        public static string? RoomState;
        private void tsmiChangeRoom_Click(object sender, EventArgs e)
        {
            if (romCustoInfo != null && romRoomInfo != null)
            {
                var dr = AntdUI.Modal.open(new AntdUI.Modal.Config(_fromRoomManagement, UIMessageConstant.Information, "确定要进行转房吗？", AntdUI.TType.Info)
                {
                    CancelText = LocalizationHelper.GetLocalizedString("No", "不了"),
                    OkText = LocalizationHelper.GetLocalizedString("Yes", "是的")
                });
                if (dr == DialogResult.OK)
                {
                    RoomNo = romRoomInfo.RoomNumber;
                    CustoNo = romCustoInfo.CustomerNumber;
                    RoomState = romRoomInfo.RoomState;
                    FrmChangeRoom frm = new FrmChangeRoom();
                    frm.ShowDialog();
                }
            }
            else
            {
                AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, "房间信息不完整！");
                return;
            }
        }

        private void tsmiSelectUserInfo_Click(object sender, EventArgs e)
        {
            rm_CustoNo = romCustoInfo.CustomerNumber;
            FrmCustomerInfo frm = new FrmCustomerInfo();
            frm.ShowDialog();
        }

        private void tsmiChangeState_Click(object sender, EventArgs e)
        {
            if (r.RoomStateId == (int)Common.Core.RoomState.Reserved)
            {
                var dr = AntdUI.Modal.open(new AntdUI.Modal.Config(_fromRoomManagement, UIMessageConstant.Information, "当前房间已被预约，确认更改状态后将会删除原本预约状态及信息，你确定吗？", AntdUI.TType.Info)
                {
                    CancelText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_No, UIMessageConstant.Chs_No),
                    OkText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_Yes, UIMessageConstant.Chs_Yes)
                });
                if (dr == DialogResult.OK)
                {
                    getParam = new Dictionary<string, string>()
                    {
                        { nameof(ReadReserInputDto.ReservationRoomNumber) , r.RoomNumber }
                    };
                    result = HttpHelper.Request(ApiConstants.Reser_SelectReserInfoByRoomNo, getParam);
                    var reserResponse = HttpHelper.JsonToModel<SingleOutputDto<ReadReserOutputDto>>(result.message);
                    if (reserResponse.Code != BusinessStatusCode.Success)
                    {
                        AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, $"{ApiConstants.Reser_SelectReserInfoByRoomNo}+接口服务异常！");
                        return;
                    }
                    else
                    {
                        var reser = new DeleteReserInputDto
                        {
                            ReservationId = reserResponse.Data!.ReservationId
                        };
                        result = HttpHelper.Request(ApiConstants.Reser_DeleteReserInfo, reser.ModelToJson());
                        var reserResult = HttpHelper.JsonToModel<BaseResponse>(result.message);
                        if (reserResult.Code != BusinessStatusCode.Success)
                        {
                            AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, $"{ApiConstants.Reser_DeleteReserInfo}+接口服务异常！");
                            return;
                        }
                    }
                }
            }
            if (romCustoInfo != null && romRoomInfo != null)
            {
                rm_RoomStateId = romRoomInfo.RoomStateId;
                rm_RoomNo = romRoomInfo.RoomNumber;
                FrmRoomStateManager frsm = new FrmRoomStateManager();
                frsm.ShowDialog();
            }
            else
            {
                AntdUI.Modal.open(_fromRoomManagement, UIMessageConstant.Error, "房间信息不完整！");
            }
        }
    }
}
