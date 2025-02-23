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
using jvncorelib.EncryptorLib;
using jvncorelib.EntityLib;
using Sunny.UI;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmMySpace : UIForm
    {
        public FrmMySpace()
        {
            InitializeComponent();
        }

        EncryptLib encryptLib = new EncryptLib();
        private void FrmMySpace_Load(object sender, EventArgs e)
        {
            //加载民族信息
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("IsDelete", "0");
            var result = HttpHelper.Request("SystemInformation/SelectNationAll", dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNationAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cbWorkerNation.DataSource = HttpHelper.JsonToList<Nation>(result.message);
            cbWorkerNation.DisplayMember = "nation_name";
            cbWorkerNation.ValueMember = "nation_no";
            //加载性别信息
            dic = new Dictionary<string, string>();
            dic.Add("IsDelete", "0");
            result = HttpHelper.Request("SystemInformation/SelectSexTypeAll", dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboSex.DataSource = HttpHelper.JsonToList<GenderType>(result.message);
            cboSex.DisplayMember = "sexName";
            cboSex.ValueMember = "sexId";
            //加载部门信息
            result = HttpHelper.Request("SystemInformation/SelectDeptAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectDeptAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboWorkerClub.DataSource = HttpHelper.JsonToList<Department>(result.message);
            cboWorkerClub.DisplayMember = "dept_name";
            cboWorkerClub.ValueMember = "dept_no";
            //加载职位信息
            dic = new Dictionary<string, string>();
            dic.Add("IsDelete", "0");
            result = HttpHelper.Request("SystemInformation/SelectPositionAll", dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectPositionAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboWorkerPosition.DataSource = HttpHelper.JsonToList<Position>(result.message);
            cboWorkerPosition.DisplayMember = "position_name";
            cboWorkerPosition.ValueMember = "position_no";
            LoadData();
        }

        private void tpSecurity_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("workerId", LoginInfo.WorkerNo);
            var result = HttpHelper.Request("Employee/SelectWorkerInfoByWorkerId", dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectWorkerInfoByWorkerId+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            Employee worker = HttpHelper.JsonToModel<Employee>(result.message);
            if (!worker.IsNullOrEmpty())
            {
                txtWorkerNo.Text = worker.EmployeeId;
                txtWorkerName.Text = worker.EmployeeName;
                cboSex.SelectedIndex = worker.Gender;
                cboWorkerPosition.Text = worker.PositionName;
                cboWorkerPosition.SelectedValue = worker.Position;
                cboWorkerClub.Text = worker.DepartmentName;
                cboWorkerClub.SelectedValue = worker.Department;
                cbWorkerNation.Text = worker.EthnicityName;
                cbWorkerNation.SelectedValue = worker.Ethnicity;
                txtAddress.Text = worker.Address;
                txtTel.Text = worker.PhoneNumber;
            }
            dic = new Dictionary<string, string>();
            dic.Add("WorkerId", LoginInfo.WorkerNo);
            result = HttpHelper.Request("WorkerPicture/EmployeePhoto", dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("EmployeePhoto+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var workerPicSource = HttpHelper.JsonToModel<EmployeePhoto>(result.message);
            if (workerPicSource != null && !string.IsNullOrEmpty(workerPicSource.PhotoPath))
            {
                EncryptLib encryptLib = new EncryptLib();
                picWorkerPic.BackgroundImage = null;
                picWorkerPic.LoadAsync(encryptLib.Decryption(HttpHelper.baseUrl) + workerPicSource.PhotoPath);
            }
        }

        private void txtOldPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPwd.TextLength < 6)
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Red;
            }
        }

        private void txtOldPwd_Validated(object sender, EventArgs e)
        {
            //校验旧密码是否正确
            Employee worker = new Employee() { EmployeeId = LoginInfo.WorkerNo, Password = txtOldPwd.Text.Trim() };
            var result = HttpHelper.Request("Employee/SelectWorkerInfoByWorkerIdAndWorkerPwd", HttpHelper.ModelToJson(worker));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectWorkerInfoByWorkerIdAndWorkerPwd+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            worker = HttpHelper.JsonToModel<Employee>(result.message);
            if (worker != null)
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Green;
                lblOldMsg.ForeColor = Color.Green;
                lblOldMsg.Text = "旧密码符合，请继续填写新密码！";
                txtNewPwd.ReadOnly = false;
                txtNewPwd.Validated += new EventHandler(txtNewPwd_Validated);
            }
            else
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Red;
                lblOldMsg.ForeColor = Color.Red;
                lblOldMsg.Text = "旧密码有误，请重试！";
                txtNewPwd.ReadOnly = true;
                txtNewPwd.Validated -= new EventHandler(txtNewPwd_Validated);

            }
        }

        private void txtNewPwd_Validated(object sender, EventArgs e)
        {
            string pattern = @"^[A-Za-z0-9]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtNewPwd.Text.Trim()) && txtNewPwd.TextLength > 8)
            {
                lblNewMsg.ForeColor = Color.Green;
                lblNewMsg.Text = "密码长度及格式符合要求！";
                lgCheckNewPwd.Visible = true;
                lgCheckNewPwd.OnColor = Color.Green;
                return;

            }
            else
            {
                lblNewMsg.ForeColor = Color.Red;
                lblNewMsg.Text = "密码长度及格式不符合要求，请检查！";
                lgCheckNewPwd.Visible = true;
                txtNewPwd.Focus();
                lgCheckNewPwd.OnColor = Color.Red;
                return;
            }
        }

        private void btnUpdPwd_Click(object sender, EventArgs e)
        {
            var result = HttpHelper.Request("Employee/UpdWorkerPwdByWorkNo", HttpHelper.ModelToJson(new Employee { EmployeeId = LoginInfo.WorkerNo, Password = txtNewPwd.Text.Trim() }));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("UpdWorkerPwdByWorkNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            bool tf = result.message.ToString().Equals("true") ? true : false;
            if (!tf)
            {
                UIMessageBox.Show("服务器繁忙，修改失败！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }

            UIMessageBox.Show("修改成功，系统将在稍后退出，请使用新密码进行登录系统！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "修改密码操作！", 2);
            #endregion
            FrmMain.CloseMy();
            this.Close();
            return;
        }

        public bool CheckInput(Employee worker)
        {
            if (string.IsNullOrWhiteSpace(worker.EmployeeId))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.EmployeeName))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.Gender + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.Ethnicity))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.PhoneNumber))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.Address))
            {
                return false;
            }
            return true;
        }
        ResponseMsg result = new ResponseMsg();
        private void btnUpdWorker_Click(object sender, EventArgs e)
        {
            Employee worker = new Employee()
            {
                EmployeeId = txtWorkerNo.Text.Trim(),
                EmployeeName = txtWorkerName.Text.Trim(),
                Gender = cboSex.Text == "男" ? 1 : 0,
                Ethnicity = cbWorkerNation.SelectedValue.ToString(),
                PhoneNumber = txtTel.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                DataChgUsr = LoginInfo.WorkerNo
            };

            if (CheckInput(worker))
            {
                result = HttpHelper.Request("Employee/UpdateWorker", HttpHelper.ModelToJson(worker));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdateWorker+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true") ? true : false;
                if (!tf)
                {
                    UIMessageBox.Show("修改失败！服务器处于繁忙，请稍后再试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("修改成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "修改个人信息操作！", 2);
                #endregion
                LoadData();
                return;
            }
        }

        private void cbWorkerNation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void picWorkerPic_Click(object sender, EventArgs e)
        {
            openPic.ShowDialog();
        }

        private void openPic_FileOk(object sender, CancelEventArgs e)
        {
            EmployeePhoto workerPic = null;
            //查询当前账号是否已存在对应的图片，如果已存在则移除旧图片
            workerPic = new EmployeePhoto
            {
                EmployeeId = txtWorkerNo.Text.Trim(),
            };
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("WorkerId", txtWorkerNo.Text.Trim());
            result = HttpHelper.Request("WorkerPicture/EmployeePhoto", dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("EmployeePhoto+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var source = HttpHelper.JsonToModel<EmployeePhoto>(result.message);
            if (!source.IsNullOrEmpty())
            {
                result = HttpHelper.Request("WorkerPicture/DeleteWorkerPic", HttpHelper.ModelToJson(workerPic));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("DeleteWorkerPic+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                if (result.message.ToString().Equals("true"))
                {
                    PicHandler();
                }
            }
            else
            {
                PicHandler();
            }

        }

        public void PicHandler()
        {
            var serverPath = encryptLib.Decryption(HttpHelper.postUrl);
            //var serverPath = ConfigurationManager.AppSettings["post"].ToString();
            var result = HttpHelper.UpLoadFile(openPic.FileName, serverPath);
            var workerPic = new EmployeePhoto
            {
                EmployeeId = txtWorkerNo.Text.Trim(),
                PhotoPath = result.Trim(),
            };
            var requestResult = HttpHelper.Request("WorkerPicture/InsertWorkerPic", HttpHelper.ModelToJson(workerPic));
            if (requestResult.statusCode != 200)
            {
                UIMessageBox.ShowError("InsertWorkerPic+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            picWorkerPic.BackgroundImage = null;
            picWorkerPic.LoadAsync(encryptLib.Decryption(HttpHelper.baseUrl) + result.Trim());
            UIMessageTip.ShowOk("头像上传成功！稍等将会加载头像哦..");
            //picWorkerPic.LoadAsync(ConfigurationManager.AppSettings["FileSite"] + result.Trim());
        }

    }
}
