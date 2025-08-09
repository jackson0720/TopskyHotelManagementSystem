using EOM.TSHotelManagement.Common;
using jvncorelib.EncryptorLib;
using Sunny.UI;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmScreenLock : UIForm
    {
        public FrmScreenLock()
        {
            InitializeComponent();
        }

        private void FrmScreenLock_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == string.Empty)
            {
                UIMessageBox.ShowError("密码不能为空，请重新输入！");
                txtPassword.Focus();
                return;
            }
            var password = new EncryptLib().Decryption(LoginInfo.Password);
            if (password != null && password == txtPassword.Text.Trim())
            {
                this.Close();
            }
            else
            {
                UIMessageBox.ShowError("密码错误，请重新输入！");
                txtPassword.Focus();
                txtPassword.Clear();
            }
        }
    }
}
