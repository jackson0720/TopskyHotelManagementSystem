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
using EOM.TSHotelManager.Common.Util;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;

namespace SYS.FormUI
{
    public partial class FrmAddAdmin : UIForm
    {
        public FrmAddAdmin()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        private Dictionary<string, string> dic = null;

        private void FrmAddAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminType();
            cbAccountType.SelectedIndex = 1;
            LoadAdminList();
        }

        public void LoadAdminList()
        {
            result = HttpHelper.Request("Admin/GetAllAdmin");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvAdminList.AutoGenerateColumns = false;
            dgvAdminList.DataSource = HttpHelper.JsonToList<Admin>(result.message);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var admin = new Admin
            {
                AdminAccount = txtAccount.Text.Trim(),
                AdminPassword = txtPassword.Text.Trim(),
                AdminName = txtName.Text.Trim(),
                AdminType = cbAccountType.SelectedValue.ToString(),
                IsAdmin = cbAccountType.SelectedValue.ToString() == "超级管理员" ? 1 : 0,
                DeleteMk = 0,
                datains_usr = AdminInfo.Account
            };
            if (ValidateHelper.Validate(admin))
            {
                result = HttpHelper.Request("Admin​/AddAdmin", HttpHelper.ModelToJson(admin));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("AddAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (tf)
                {
                    UIMessageBox.ShowSuccess("添加管理员成功！");
                    LoadAdminList();
                    return;
                }
            }
        }

        public void LoadAdminType()
        {
            result = HttpHelper.Request("Admin/GetAllAdminTypes");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllAdminTypes+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cbAccountType.DataSource = HttpHelper.JsonToList<AdminType>(result.message);
            cbAccountType.ValueMember = "type_id";
            cbAccountType.DisplayMember = "type_name";
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountType.Text == "超级管理员")
            {
                UIMessageTip.ShowWarning("警告：赋予当前账号为超级管理员意味着其所作的所有行为将不受系统监管\n并有可能造成系统数据的缺失！", 3000);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        }
    }
}
