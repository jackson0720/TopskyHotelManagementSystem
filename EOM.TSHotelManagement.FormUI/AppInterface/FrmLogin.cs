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
using EOM.TSHotelManagement.Common.Core;
using EOM.TSHotelManagement.FormUI.Properties;
using jvncorelib.EntityLib;
using Sunny.UI;
using System.Windows.Forms;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmLogin : Window
    {
        private LoadingProgress _loadingProgress;
        public FrmLogin()
        {
            InitializeComponent();
            _loadingProgress = new LoadingProgress();
            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
        }

        ResponseMsg result = new ResponseMsg();

        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 调用淡出淡入效果函数
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        #endregion

        #region 窗体淡出淡入方法
        //protected static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        ///**********************************************************************************************/
        ////dwflag的取值如下  
        //public const Int32 AW_HOR_POSITIVE = 0x00000001;        //从左到右显示  
        //public const Int32 AW_HOR_NEGATIVE = 0x00000002;        //从右到左显示  
        //public const Int32 AW_VER_POSITIVE = 0x00000004;        //从上到下显示  
        //public const Int32 AW_VER_NEGATIVE = 0x00000008;        //从下到上显示  

        ////若使用了AW_HIDE标志，则使窗口向内重叠，即收缩窗口；否则使窗口向外扩展，即展开窗口  
        //public const Int32 AW_CENTER = 0x00000010;
        //public const Int32 AW_HIDE = 0x00010000;        //隐藏窗口，缺省则显示窗口  
        //public const Int32 AW_ACTIVATE = 0x00020000;        //激活窗口。在使用了AW_HIDE标志后不能使用这个标志  

        ////使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略  
        //public const Int32 AW_SLIDE = 0x00040000;
        //public const Int32 AW_BLEND = 0x00080000;        //透明度从高到低 

        #endregion

        #region 记录移动的窗体坐标
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
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

        #region 最小化窗体事件方法
        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        #endregion

        #region 关闭窗体事件方法
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 窗体打开时淡入效果
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            txtWorkerId.Text = "WK010";
            txtWorkerPwd.Text = "admin";
        }
        #endregion

        #region 窗体关闭时淡出效果
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        #endregion

        #region 检验输入完整性
        /// <summary>
        /// 检验输入完整性
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (txtWorkerId.Text == "")
            {
                UIMessageBox.Show("请输入员工编号！", "输入提示", UIStyle.Red);
                txtWorkerId.Focus();
                return false;
            }
            if (txtWorkerPwd.Text == "")
            {
                UIMessageBox.Show("请输入员工密码！", "输入提示", UIStyle.Red);
                txtWorkerPwd.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 登录图片点击事件
        private void picLogin_Click(object sender, EventArgs e)
        {
            _loadingProgress.Show();
            try
            {
                if (CheckInput())
                {
                    Worker worker = new Worker() { WorkerId = txtWorkerId.Text.Trim(), WorkerPwd = txtWorkerPwd.Text.Trim() };

                    result = HttpHelper.Request("Worker/SelectWorkerInfoByWorkerIdAndWorkerPwd", HttpHelper.ModelToJson(worker));

                    if (result.statusCode != 200)
                    {
                        AntdUI.Modal.open(this, "系统提示", "账号或密码错误！",TType.Error);
                        txtWorkerPwd.Focus();
                        return;
                    }

                    Worker w = HttpHelper.JsonToModel<Worker>(result.message);

                    if (!w.IsNullOrEmpty())
                    {
                        if (w.IsDelete == 1)
                        {
                            AntdUI.Modal.open(this, "系统提示", "账号已禁用，请联系上级解封！", TType.Error);
                            return;
                        }

                        LoginInfo.WorkerNo = w.WorkerId;
                        LoginInfo.WorkerName = w.WorkerName;
                        LoginInfo.WorkerClub = w.ClubName;
                        LoginInfo.WorkerPosition = w.PositionName;
                        LoginInfo.SoftwareVersion = ApplicationUtil.GetApplicationVersion().ToString();
                        LoginInfo.UserToken = w.UserToken;
                        FrmMain frm = new FrmMain(this, _loadingProgress);
                        this.Hide();
                        frm.TopMost = true;
                        frm.ShowDialog(this);
                    }
                    else
                    {
                        AntdUI.Modal.open(this, "系统提示", "密码错误！", TType.Error);
                        txtWorkerPwd.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                AntdUI.Modal.open(this, "系统提示", "服务器维护中，请稍后再试！", TType.Error);
            }
        }
        #endregion

        private void btnLoginBackSystem_Click(object sender, EventArgs e)
        {
            FrmAdminEnter frmAdminEnter = new FrmAdminEnter(this);
            frmAdminEnter.ShowDialog(this);
        }
    }
}
