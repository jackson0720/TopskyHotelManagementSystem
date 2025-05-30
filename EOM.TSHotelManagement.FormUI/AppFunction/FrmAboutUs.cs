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
using EOM.TSHotelManagement.Common.Util;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmAboutUs : Window
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }

        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 记录移动的窗体坐标
        private void FrmAboutUs_MouseDown(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmAboutUs_MouseMove(object sender, MouseEventArgs e)
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

        private void FrmAboutUs_Load(object sender, EventArgs e)
        {
            rtbAboutUs.Text = LocalizationHelper.GetLocalizedString("Our team has always been committed to creating a user-friendly and easy-to-use management software. Our vision is to use technology to create easy-to-use open source software/components and to create software with a vision in mind. Our team is full of vitality and passion!\r\n     Regarding our team, you can browse: https://www.oscode.top Learn more!  \r\n     For detailed information about this software, you can browse: https://gitee.com/java-and-net/TopskyHotelManagerSystem Learn more! In addition, we will still provide support for future version upgrades!",
                "     我们团队一直都致力于打造一款人机交互方便，操作简单的管理软件，我们的愿景是“用技术创造易用的开源软件/组件”，一路心怀愿景去制作软件，我们的团队充满活力、激情！\r\n     关于我们团队，您可以浏览：https://www.oscode.top了解更多！  \r\n     关于本软件的详细信息，您可以浏览：https://gitee.com/java-and-net/TopskyHotelManagerSystem 了解更多！另外仍会提供后续的版本升级支持！");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
