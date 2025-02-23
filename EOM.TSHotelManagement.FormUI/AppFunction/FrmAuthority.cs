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
using EOM.TSHotelManagement.Common.Core;
using jvncorelib.EntityLib;
using Sunny.UI;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmAuthority : UIForm
    {
        public FrmAuthority()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void FrmAuthority_Load(object sender, EventArgs e)
        {
        }

        public void LoadAdminInfo()
        {
            dic = new Dictionary<string, string>()
            {
                { "AdminAccount",txtAccount.Text.Trim() }
            };
            result = HttpHelper.Request("Administrator/GetAdminInfoByAdminAccount", dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAdminInfoByAdminAccount+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var adminInfo = HttpHelper.JsonToModel<Administrator>(result.message);
            if (adminInfo.IsNullOrEmpty())
            {
                UIMessageTip.ShowError("找不到对应的管理员，请检查是否输入有误！");
                cbAccountType.Text = "";
                txtName.Text = "";
                txtAccount.Text = "";
                return;
            }
            txtAccount.Text = adminInfo.Account;
            txtName.Text = adminInfo.Name;
            cbAccountType.Text = adminInfo.TypeName;
        }

        public void LoadAllMyModule()
        {
            tfModuleZero.ItemsLeft.Clear();
            var admin = new Administrator
            {
                Account = txtAccount.Text.Trim(),
            };

            result = HttpHelper.Request("Module/GetAllModuleByAdmin", HttpHelper.ModelToJson(admin));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllModuleByAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listMyModule = HttpHelper.JsonToList<Module>(result.message);
            listMyModule.ForEach(myModule =>
            {
                tfModuleZero.ItemsRight.Add(myModule.ModuleName);
            });
            result = HttpHelper.Request("Module/GetAllModule");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllModule+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listModules = HttpHelper.JsonToList<Module>(result.message);
            listModules.ForEach(module =>
            {
                var myModule = listMyModule.FirstOrDefault(a => a.ModuleName.Equals(module.ModuleName));
                if (myModule == null)
                {
                    tfModuleZero.ItemsLeft.Add(module.ModuleName);
                }
            });
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tfModuleZero.ItemsRight.Clear();
            LoadAdminInfo();
            LoadAllMyModule();
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccount.Text.Trim()))
            {
                UIMessageTip.ShowError("账号不能为空，请检查！");
                return;
            }
            dic = new Dictionary<string, string>()
            {
                { "AdminAccount",txtAccount.Text.Trim() }
            };
            var admin = new Administrator { Account = txtAccount.Text.Trim() };
            result = HttpHelper.Request("Module/GetAllModuleByAdmin", HttpHelper.ModelToJson(admin));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllModuleByAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listExsitModule = HttpHelper.JsonToList<Module>(result.message);
            var listAddModule = new List<ModulePermission>();
            if (listExsitModule != null)
            {
                ModulePermission moduleZero = new ModulePermission() { AdministratorAccount = txtAccount.Text.Trim() };
                result = HttpHelper.Request("Module/DelModuleZeroList", HttpHelper.ModelToJson(moduleZero));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("DelModuleZeroList+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                for (int i = 0; i < tfModuleZero.ItemsRight.Count; i++)
                {
                    var newModule = tfModuleZero.ItemsRight[i].ToString();
                    listAddModule.Add(new ModulePermission() { AdministratorAccount = txtAccount.Text.Trim(), ModuleName = newModule, ModuleEnabled = 1 });
                }
            }
            if (!listAddModule.IsNullOrEmpty())
            {
                result = HttpHelper.Request("Module/AddModuleZeroList", HttpHelper.ModelToJson(listAddModule));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("AddModuleZeroList+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (tf)
                {
                    UIMessageBox.ShowSuccess("批量授权成功！");
                    return;
                }
            }
        }
    }
}
