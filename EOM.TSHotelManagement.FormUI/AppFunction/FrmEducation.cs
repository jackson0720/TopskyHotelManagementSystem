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
using Sunny.UI;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmEducation : UIForm
    {
        public delegate void OperationEducation();


        //定义委托类型的变量
        public static OperationEducation operation;

        public static OperationEducation reload;

        public FrmEducation()
        {
            InitializeComponent();
            reload = ReloadEducationList;
        }
        List<Education> educations = null;
        public static string info = null;
        private void FrmEducation_Load(object sender, EventArgs e)
        {
            ReloadEducationList();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        public void ReloadEducationList()
        {
            //flpInformation.Controls.Clear();
            txtEducationNo.Text = ApplicationUtil.GetListNewId("E", 3, 1, "-").FirstOrDefault();
            result = HttpHelper.Request("SystemInformation/SelectEducationAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectEducationAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            educations = HttpHelper.JsonToList<Education>(result.message);
            dgvEducationList.AutoGenerateColumns = false;
            dgvEducationList.DataSource = educations;
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (txtEducationName.Text.Trim().IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("学历名称为空，请检查", 1500);
                txtEducationName.Focus();
                return;
            }
            var edu = new Education()
            {
                EducationNumber = txtEducationNo.Text.Trim(),
                EducationName = txtEducationName.Text.Trim(),
                IsDelete = 0,
                DataInsUsr = AdminInfo.Account
            };
            result = HttpHelper.Request("SystemInformation​/AddEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("AddEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
            UIMessageTip.ShowOk("添加学历成功！", 1500);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增学历类型操作！新增值为：" + edu.EducationNumber, 2);
            #endregion
            ReloadEducationList();
            return;

        }

        private void btnUpdateEducation_Click(object sender, EventArgs e)
        {
            if (dgvEducationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的学历数据，请检查", 1500);
                return;
            }
            var edu = new Education()
            {
                EducationNumber = txtEducationNo.Text.Trim(),
                EducationName = txtEducationName.Text.Trim(),
                DataChgUsr = AdminInfo.Account,
            };
            result = HttpHelper.Request("SystemInformation​/UpdEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("UpdEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
            ReloadEducationList();
        }

        private void btnDeleteEducation_Click(object sender, EventArgs e)
        {
            if (dgvEducationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的学历数据，请检查", 1500);
                return;
            }
            var edu = new Education()
            {
                EducationNumber = txtEducationNo.Text.Trim(),
                EducationName = txtEducationName.Text.Trim(),
                IsDelete = 1,
                DataChgUsr = AdminInfo.Account,
            };
            result = HttpHelper.Request("SystemInformation​/DelEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("DelEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
            UIMessageTip.ShowOk("删除成功！");
            ReloadEducationList();
            return;
        }

        private void dgvEducationList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEducationNo.Text = dgvEducationList.SelectedRows[0].Cells["clEducationNo"].Value.ToString();
            txtEducationName.Text = dgvEducationList.SelectedRows[0].Cells["clEducationName"].Value.ToString();
            if (dgvEducationList.SelectedRows[0].Cells["clDeleteMk"].Value.ToString() == "1")
            {
                btnDeleteEducation.Text = "恢复学历";
                btnDeleteEducation.FillColor = Color.Green;
                btnDeleteEducation.Click += btnRecoveryEducation_Click;
            }
        }

        private void btnRecoveryEducation_Click(object sender, EventArgs e)
        {
            if (dgvEducationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的学历数据，请检查", 1500);
                return;
            }
            var edu = new Education()
            {
                EducationNumber = txtEducationNo.Text.Trim(),
                EducationName = txtEducationName.Text.Trim(),
                IsDelete = 0,
                DataChgUsr = AdminInfo.Account,
            };
            result = HttpHelper.Request("SystemInformation​/UpdEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("UpdEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
        }
    }
}
