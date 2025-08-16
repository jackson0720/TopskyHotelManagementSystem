using AntdUI;
using EOM.TSHotelManagement.Common;
using EOM.TSHotelManagement.Common.Contract;
using EOM.TSHotelManagement.Common.Util;
using jvncorelib.EntityLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmAccountSecurity : Window
    {
        public FrmAccountSecurity()
        {
            InitializeComponent();
        }

        private void FrmAccountSecurity_Load(object sender, EventArgs e)
        {
            lblEmployeeId.Text = LoginInfo.WorkerNo;
            txtOldPassword.PlaceholderText = LocalizationHelper.GetLocalizedString("Please input old password", "请输入旧密码");
            txtNewPassword.PlaceholderText = LocalizationHelper.GetLocalizedString("Please input new password", "请输入新密码");
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text))
            {
                AntdUI.Modal.open(this, LocalizationHelper.GetLocalizedString("System prompt", "系统提示"), LocalizationHelper.GetLocalizedString("Please input new password or old password", "请输入旧密码或新密码"), TType.Error);
                return;
            }

            var employee = new UpdateEmployeeInputDto
            {
                EmployeeId = LoginInfo.WorkerNo,
                OldPassword = txtOldPassword.Text.Trim(),
                Password = txtNewPassword.Text.Trim(),
                DataChgDate = DateTime.Now,
                DataChgUsr = LoginInfo.WorkerNo
            };
            var request = HttpHelper.Request(ApiConstants.Employee_UpdateEmployeeAccountPassword, employee.ModelToJson());
            var response = HttpHelper.JsonToModel<BaseResponse>(request.message);
            if (response.Code != BusinessStatusCode.Success)
            {
                AntdUI.Modal.open(this, LocalizationHelper.GetLocalizedString("System prompt", "系统提示"), LocalizationHelper.GetLocalizedString($"{ApiConstants.Employee_UpdateEmployeeAccountPassword}+Interface service exception, please submit an issue or try updating the version!", $"{ApiConstants.Employee_UpdateEmployeeAccountPassword}+接口服务异常，请提交Issue或尝试更新版本！"));
                return;
            }
            AntdUI.Modal.open(this, LocalizationHelper.GetLocalizedString("System prompt", "系统提示"), LocalizationHelper.GetLocalizedString("Update password success", "更新密码成功"), TType.Success);
            return;
        }
    }
}
