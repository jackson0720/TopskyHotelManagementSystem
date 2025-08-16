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
using EOM.TSHotelManagement.Common.Util;
using EOM.TSHotelManagement.FormUI.Properties;
using EOM.TSHotelManagement.Shared;
using jvncorelib.CodeLib;
using jvncorelib.EntityLib;
using System.Diagnostics;
using System.Windows.Forms;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmMain : Window
    {
        private FrmLogin returnForm1 = null;
        private LoadingProgress _loadingProgress;

        public FrmMain(FrmLogin F1)
        {
            InitializeComponent();
            _loadingProgress = new LoadingProgress();

            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
            cpUITheme.ValueChanged += cpUITheme_ValueChanged;
            Control.CheckForIllegalCrossThreadCalls = false;//关闭线程检查
            //Main = this;//储存主窗口实例对象
            // 接受Form1对象
            this.returnForm1 = F1;
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "版本登入了系统！", Common.Core.LogLevel.Critical);
            #endregion
            Stop = StopUseExit;
            Start = StartUseExit;
            CloseMy = CloseMine;
        }

        public delegate void StopUseList();
        //定义委托类型的变量
        public static StopUseList Stop;

        public delegate void StarUseList();
        //定义委托类型的变量
        public static StarUseList Start;

        public static StarUseList CloseMy;

        ResponseMsg result = new ResponseMsg();

        public void StopUseExit()
        {
            notifyIcon1.Visible = false;
            tsmiExitSystem.Enabled = false;
        }

        public void StartUseExit()
        {
            notifyIcon1.Visible = true;
            tsmiExitSystem.Enabled = true;
        }

        public static string wk_WorkerName;
        public static string wk_WorkerNames;


        #region 窗体渐变相关代码
        private bool showing = true;
        #endregion

        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 记录移动的窗体坐标
        private void FrmMain_MouseDown_1(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmMain_MouseMove_1(object sender, MouseEventArgs e)
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

        #region 定时器：获取网络时间
        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm");

            DateTime tmCur = Convert.ToDateTime(DateTime.Now);

            if (tmCur.Hour < 8 || tmCur.Hour > 18)
            {//晚上
                label3.Text = "(*´▽｀)ノノ晚上好," + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.月亮;
            }
            else if (tmCur.Hour > 8 && tmCur.Hour < 12)
            {//上午
                label3.Text = "上午好," + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.早上;
            }
            else
            {//下午
                label3.Text = "下午好," + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.咖啡;
            }
        }
        #endregion

        ListOutputDto<ReadPromotionContentOutputDto> fonts = null;
        int fontn = 0;
        private void LoadFonts()
        {
            #region 从数据库读取文字滚动的内容
            result = HttpHelper.Request(ApiConstants.PromotionContent_SelectPromotionContents);
            var response = HttpHelper.JsonToModel<ListOutputDto<ReadPromotionContentOutputDto>>(result.message);
            if (response.Code != BusinessStatusCode.Success)
            {
                fonts = null;
            }

            fonts = response;
            #endregion
        }

        #region 定时器：文字滚动间隔
        private void tmrFont_Tick(object sender, EventArgs e)
        {
            if (fonts.Data.Items == null || fonts.Data.Items.Count == 0)
            {
                return;
            }
            fontn++;
            if (fontn >= fonts.Data.Items.Count)
            {
                fontn = 0;
            }
            lblScroll.Text = fonts.Data.Items[fontn].PromotionContentMessage;
        }
        #endregion

        #region 退出当前程序
        private void picClose_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
            notifyIcon1.Dispose();
        }
        #endregion

        #region 窗体最小化
        private void picFormSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        /// <summary>
        /// 加载导航控件列表
        /// </summary>
        private void LoadNavBar()
        {
            var listData = new List<ReadNavBarOutputDto>();
            #region 菜单导航代码块
            result = HttpHelper.Request(ApiConstants.NavBar_NavBarList);
            var response = HttpHelper.JsonToModel<ListOutputDto<ReadNavBarOutputDto>>(result.message);
            if (response.Code != BusinessStatusCode.Success)
            {
                AntdUI.Message.error(this, "服务器维护中，请过会再试");
                listData = null;
                return;
            }
            listData = response.Data.Items;
            MenuItem menuItem = null;
            muNavBar.Controls.Clear();
            if (!listData.IsNullOrEmpty())
            {
                foreach (var item in listData)
                {
                    menuItem = new MenuItem
                    {
                        Text = item.NavigationBarName
                    };
                    switch (item.NavigationBarName)
                    {
                        case "客房管理":
                            menuItem.Icon = Resources.picRoom_Image;
                            break;
                        case "客户管理":
                            menuItem.Icon = Resources.picCustomer_Image;
                            break;
                        case "商品消费":
                            menuItem.Icon = Resources.picCommodity_Image;
                            break;
                    }
                    muNavBar.Items.Add(menuItem);
                }
            }
            else
            {
                AntdUI.Message.error(this, "服务器维护中，请过会再试");
                return;
            }
            #endregion
        }

        #region 窗体加载事件方法
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();

            lblSoftName.Text = System.Windows.Forms.Application.ProductName.ToString() + " V" + ApplicationUtil.GetApplicationVersion();

            tmrDate.Enabled = true;

            LoadNavBar();

            LoadFonts();

            lblTime.Text = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm");

            DateTime tmCur = Convert.ToDateTime(DateTime.Now);

            if (tmCur.Hour < 8 || tmCur.Hour > 18)
            {
                label3.Text = "(*´▽｀)ノノ晚上好 " + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.月亮;
            }
            else if (tmCur.Hour > 8 && tmCur.Hour < 12)
            {
                label3.Text = "(*´▽｀)ノノ上午好 " + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.早上;
            }
            else
            {
                label3.Text = "(*´▽｀)ノノ下午好 " + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.咖啡;
            }

            pnlCheckInfo.Visible = false;

            notifyIcon1.Text = "TS酒店管理系统-" + LoginInfo.WorkerName + "-版本号：" + ApplicationUtil.GetApplicationVersion();
            wk_WorkerName = LoginInfo.WorkerName;

            FrmRoomManager frmRoomManager = new FrmRoomManager
            {
                TopLevel = false
            };
            pnlMID.Controls.Add(frmRoomManager);
            frmRoomManager.Show();

            checkEmployeeCheckInfo();
        }
        #endregion

        #region 调用系统锁屏方法
        private void tsmiLockScreen_Click(object sender, EventArgs e)
        {
            var lockForm = new FrmScreenLock();
            lockForm.ShowDialog();
        }
        #endregion

        #region 检查软件更新版本事件方法
        private void tsmiCheckUpdate_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region 切换用户事件方法
        private void tsmiChangeUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 退出酒店管理系统事件方法
        private void tsmiExitSystem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
        #endregion

        #region 关于我们选项的事件方法
        private void tsmiAboutUs_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region 当窗体关闭后的事件方法
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
        }
        #endregion

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose();
            this.returnForm1.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkEmployeeCheckInfo();
        }

        private void checkEmployeeCheckInfo()
        {
            Dictionary<string, string> user = new Dictionary<string, string>()
            {
                { nameof(ReadEmployeeCheckInputDto.EmployeeId), LoginInfo.WorkerNo}
            };

            var result = HttpHelper.Request(ApiConstants.EmployeeCheck_SelectToDayCheckInfoByWorkerNo, user);
            var response = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeeCheckOutputDto>>(result.message);

            if (response.Code != BusinessStatusCode.Success)
            {
                AntdUI.Modal.open(this, UIMessageConstant.Error, $"打卡接口:{ApiConstants.EmployeeCheck_SelectToDayCheckInfoByWorkerNo}异常：{response.Message}");
                return;
            }

            var tmCur = DateTime.Today;
            int currentHour = tmCur.Hour;
            bool isMorningShift = currentHour < 12;

            bool shouldHaveChecked = isMorningShift ? response.Data.MorningChecked : response.Data.EveningChecked;
            string shiftName = isMorningShift ? "早班" : "晚班";

            linkLabel1.Text = shouldHaveChecked ? $"{shiftName}已打卡" : $"{shiftName}未打卡";
            linkLabel1.ForeColor = shouldHaveChecked ? Color.Green : Color.Red;
            linkLabel1.LinkColor = shouldHaveChecked ? Color.Green : Color.Red;

            if (!shouldHaveChecked)
            {
                var dr = AntdUI.Modal.open(new AntdUI.Modal.Config(this, UIMessageConstant.Information, $"你的{shiftName}还未打卡哦，请先打卡吧！", AntdUI.TType.Info)
                {
                    CancelText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_Wait, UIMessageConstant.Chs_Wait),
                    OkText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_Yes, UIMessageConstant.Chs_Yes)
                });
                if (dr == DialogResult.OK)
                {
                    CreateEmployeeCheckInputDto workerCheck = new()
                    {
                        CheckNumber = new UniqueCode().GetNewId("CK"),
                        DataInsDate = DateTime.Now,
                        IsDelete = 0,
                        CheckStatus = isMorningShift ? 0 : 1,
                        EmployeeId = LoginInfo.WorkerNo,
                        CheckMethod = "系统界面",
                        CheckTime = DateTime.Now,
                        DataInsUsr = LoginInfo.WorkerNo
                    };

                    result = HttpHelper.Request(ApiConstants.EmployeeCheck_AddCheckInfo, workerCheck.ModelToJson());
                    var checkResult = HttpHelper.JsonToModel<BaseResponse>(result.message);
                    if (checkResult.Code != BusinessStatusCode.Success)
                    {
                        AntdUI.Modal.open(this, UIMessageConstant.Error, $"打卡接口{ApiConstants.EmployeeCheck_AddCheckInfo}异常：{checkResult.Message}");
                        return;
                    }

                    result = HttpHelper.Request(ApiConstants.EmployeeCheck_SelectWorkerCheckDaySumByEmployeeId, user);
                    response = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeeCheckOutputDto>>(result.message);
                    if (response.Code != BusinessStatusCode.Success)
                    {
                        AntdUI.Modal.open(this, UIMessageConstant.Error, $"打卡天数接口{ApiConstants.EmployeeCheck_SelectWorkerCheckDaySumByEmployeeId}异常：{response.Message}");
                        return;
                    }

                    AntdUI.Modal.open(this, UIMessageConstant.Success, $"{shiftName}打卡成功！你已共打卡" + lblCheckDay.Text + "天");
                    linkLabel1.Text = $"{shiftName}已打卡";
                    linkLabel1.ForeColor = Color.Green;
                    linkLabel1.LinkColor = Color.Green;
                }
            }

            lblCheckDay.Text = Convert.ToString(response.Data.CheckDay);
            pnlCheckInfo.Visible = true;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            pnlCheckInfo.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tsmiMySpace_Click(object sender, EventArgs e)
        {
            FrmMySpace frmMySpace = new FrmMySpace();
            frmMySpace.Text = LoginInfo.WorkerName + "的个人中心";
            frmMySpace.Show();
        }

        public void CloseMine()
        {
            this.Close();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
        }

        private void tsmiLoginBackSystem_Click(object sender, EventArgs e)
        {


        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            cmsMain.Show(Cursor.Position);
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void cpUITheme_ValueChanged(object sender, ColorEventArgs e)
        {
            AntdUI.Style.SetPrimary(e.Value);
            Refresh();
        }

        private void muNavBar_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            switch (e.Value.Text)
            {
                case "客房管理":
                    pnlMID.Controls.Clear();
                    FrmRoomManager frmRoomManager = new()
                    {
                        TopLevel = false
                    };
                    pnlMID.Controls.Add(frmRoomManager);
                    frmRoomManager.Show();
                    break;
                case "客户管理":
                    pnlMID.Controls.Clear();
                    FrmCustomerManager frmCustomerManager = new()
                    {
                        TopLevel = false
                    };
                    pnlMID.Controls.Add(frmCustomerManager);
                    frmCustomerManager.Show();
                    break;
                case "商品消费":
                    pnlMID.Controls.Clear();
                    FrmSellThing frmSellThing = new()
                    {
                        TopLevel = false
                    };
                    pnlMID.Controls.Add(frmSellThing);
                    frmSellThing.Show();
                    break;
            }

        }

        private void tsmiUpdateLog_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(this, LocalizationHelper.GetLocalizedString("Update log", "更新日志"), LoginInfo.SoftwareReleaseLog, TType.Info);
        }

        private void tsmiAccessOfficial_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.oscode.top",
                UseShellExecute = true
            });
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }
    }
}
