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
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using EOM.TSHotelManager.Common;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI.Win32;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmLoading : UIForm
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            lblSoftwareVersion.Text = ApplicationUtil.GetApplicationVersion().ToString();
            lblDllVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            CheckUpdate();
            //Thread thread2 = new Thread(threadPro);//创建新线程
            //thread2.Start();
        }

        public void threadPro()
        {
            System.Windows.Forms.MethodInvoker MethInvo = new System.Windows.Forms.MethodInvoker(ShowLoginForm);
            BeginInvoke(MethInvo);
        }

        public void ShowLoginForm()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);
            this.Close();
        }

        ResponseMsg result = new ResponseMsg();

        #region 判断版本号
        private void CheckUpdate()
        {
            result = HttpHelper.Request("App/CheckBaseVersion");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("CheckBaseVersion+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var newversion = HttpHelper.JsonToModel<Applicationversion>(result.message);

            var targetVersion = new System.Version(newversion.base_version);
            var assembly = Assembly.GetExecutingAssembly();
            var currentVersion = assembly.GetName().Version;

            if (!currentVersion!.Equals(targetVersion))
            {
                lblTips.Text = "旧版已停止使用，请到github或gitee仓库更新最新发行版！";
                System.Windows.Forms.Application.Exit();
                this.Visible = false;
                //调用系统默认的浏览器
                System.Diagnostics.Process.Start("https://gitee.com/java-and-net/TopskyHotelManagerSystem/releases");
            }
            else
            {
                lblSoftwareNewVersion.Text = newversion.base_version;
                lblTips.Text = "当前已为最新版本，无需更新！";
                Thread thread2 = new Thread(threadPro);//创建新线程
                thread2.Start();
            }
        }
        #endregion

    }
}
