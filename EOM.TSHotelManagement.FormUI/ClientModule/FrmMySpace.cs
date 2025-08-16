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

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmMySpace : Window
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMySpace));
        public FrmMySpace()
        {
            InitializeComponent();

            ucWindowHeader1 = new ucWindowHeader("个人中心", string.Empty, (Image)resources.GetObject("FrmMySpace.Icon")!);
        }

        private void FrmMySpace_Load(object sender, EventArgs e)
        {

        }

        private void tbPersonnelCenterTabs_TabClick(object sender, TabsItemEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "tbPersonnelInfo":
                    pnlPage.Controls.Clear();
                    FrmPersonnelInfo frmPersonnelInfo = new()
                    {
                        TopLevel = false
                    };
                    pnlPage.Controls.Add(frmPersonnelInfo);
                    frmPersonnelInfo.Show();
                    break;
                case "tbChangePassword":
                    pnlPage.Controls.Clear();
                    FrmAccountSecurity frmAccountSecurity = new()
                    {
                        TopLevel = false
                    };
                    pnlPage.Controls.Add(frmAccountSecurity);
                    frmAccountSecurity.Show();
                    break;
                case "tbAccountAvatar":
                    pnlPage.Controls.Clear();
                    FrmAvator frmAvator = new()
                    {
                        TopLevel = false
                    };
                    pnlPage.Controls.Add(frmAvator);
                    frmAvator.Show();
                    break;
            }
        }
    }
}
