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
using EOM.TSHotelManagement.Common;
using EOM.TSHotelManagement.Common.Contract;
using EOM.TSHotelManagement.Common.Util;
using jvncorelib.EncryptorLib;
using jvncorelib.EntityLib;
using Sunny.UI;
using System.ComponentModel;

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
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { nameof(ReadNationInputDto.IsDelete), "0" },
                { nameof(ReadNationInputDto.IgnorePaging), "true" }
            };
            var result = HttpHelper.Request(ApiConstants.Base_SelectNationAll, dic);
            var nations = HttpHelper.JsonToModel<ListOutputDto<ReadNationOutputDto>>(result.message);
            if (nations.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectNationAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cbWorkerNation.DataSource = nations.Data.Items;
            cbWorkerNation.DisplayMember = nameof(ReadNationOutputDto.NationName);
            cbWorkerNation.ValueMember = nameof(ReadNationOutputDto.NationNumber);
            //加载性别信息
            dic = new Dictionary<string, string>
            {
                { nameof(ReadGenderTypeInputDto.IsDelete) , "0" },
                { nameof(ReadGenderTypeInputDto.IgnorePaging) , "true" }
            };
            result = HttpHelper.Request(ApiConstants.Base_SelectGenderTypeAll, dic);
            var genderTypes = HttpHelper.JsonToModel<ListOutputDto<EnumDto>>(result.message);
            if (genderTypes.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectGenderTypeAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboSex.DataSource = genderTypes.Data.Items;
            cboSex.DisplayMember = nameof(ReadGenderTypeOutputDto.Description);
            cboSex.ValueMember = nameof(ReadGenderTypeOutputDto.Id);
            //加载部门信息
            result = HttpHelper.Request(ApiConstants.Base_SelectDeptAllCanUse);
            var depts = HttpHelper.JsonToModel<ListOutputDto<ReadDepartmentOutputDto>>(result.message);
            if (depts.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectDeptAllCanUse}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboWorkerClub.DataSource = depts.Data.Items;
            cboWorkerClub.DisplayMember = nameof(ReadDepartmentOutputDto.DepartmentName);
            cboWorkerClub.ValueMember = nameof(ReadDepartmentOutputDto.DepartmentNumber);
            //加载职位信息
            dic = new Dictionary<string, string>
            {
                { nameof(ReadPositionInputDto.IsDelete), "0" },
                { nameof(ReadPositionInputDto.IgnorePaging), "true" }
            };
            result = HttpHelper.Request(ApiConstants.Base_SelectPositionAll, dic);
            var positions = HttpHelper.JsonToModel<ListOutputDto<ReadPositionOutputDto>>(result.message);
            if (positions.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectPositionAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboWorkerPosition.DataSource = positions.Data.Items;
            cboWorkerPosition.DisplayMember = nameof(ReadPositionOutputDto.PositionName);
            cboWorkerPosition.ValueMember = nameof(ReadPositionOutputDto.PositionNumber);

            lblEmployeeId.Text = LoginInfo.WorkerNo;
            txtOldPassword.PlaceholderText = LocalizationHelper.GetLocalizedString("Please input old password", "请输入旧密码");
            txtNewPassword.PlaceholderText = LocalizationHelper.GetLocalizedString("Please input new password", "请输入新密码");

            LoadData();
        }

        public void LoadData()
        {
            var dic = new Dictionary<string, string>
            {
                { nameof(ReadEmployeeInputDto.EmployeeId) , LoginInfo.WorkerNo }
            };
            var result = HttpHelper.Request(ApiConstants.Employee_SelectEmployeeInfoByEmployeeId, dic);
            var employees = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeeOutputDto>>(result.message);
            if (employees.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Employee_SelectEmployeeInfoByEmployeeId}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            ReadEmployeeOutputDto worker = employees.Data;
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
            dic = new Dictionary<string, string>
            {
                { nameof(ReadEmployeePhotoInputDto.EmployeeId) , LoginInfo.WorkerNo }
            };
            result = HttpHelper.Request(ApiConstants.EmployeePhoto_EmployeePhoto, dic);
            var workerPic = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeePhotoOutputDto>>(result.message);
            if (workerPic.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.EmployeePhoto_EmployeePhoto}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var workerPicData = workerPic.Data;
            if (workerPicData != null && !string.IsNullOrEmpty(workerPicData.PhotoPath))
            {
                picWorkerPic.BackgroundImage = null;
                if (!string.IsNullOrEmpty(workerPicData.PhotoPath)) picWorkerPic.Load(workerPicData.PhotoPath);
            }
        }

        public bool CheckInput(UpdateEmployeeInputDto worker)
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
            UpdateEmployeeInputDto worker = new UpdateEmployeeInputDto()
            {
                EmployeeId = txtWorkerNo.Text.Trim(),
                EmployeeName = txtWorkerName.Text.Trim(),
                Gender = cboSex.Text == "男" ? 1 : 0,
                Ethnicity = cbWorkerNation.SelectedValue.ToString(),
                PhoneNumber = txtTel.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                DataChgUsr = LoginInfo.WorkerNo,
                DataChgDate = DateTime.Now
            };

            if (CheckInput(worker))
            {
                result = HttpHelper.Request(ApiConstants.Employee_UpdateEmployee, HttpHelper.ModelToJson(worker));
                var response = HttpHelper.JsonToModel<BaseResponse>(result.message);
                if (response.Code != BusinessStatusCode.Success)
                {
                    UIMessageBox.ShowError($"{ApiConstants.Employee_UpdateEmployee}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                UIMessageBox.Show("修改成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "修改个人信息操作！", Common.Core.LogLevel.Warning);
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
            var dic = new Dictionary<string, string>
            {
                { nameof(ReadEmployeePhotoInputDto.EmployeeId) , LoginInfo.WorkerNo }
            };
            result = HttpHelper.Request(ApiConstants.EmployeePhoto_EmployeePhoto, dic);
            var workerPic = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeePhotoOutputDto>>(result.message);
            if (workerPic.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.EmployeePhoto_EmployeePhoto}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var workerPicData = workerPic.Data;
            if (!workerPicData.IsNullOrEmpty() && !string.IsNullOrEmpty(workerPicData.PhotoPath))
            {
                result = HttpHelper.Request(ApiConstants.EmployeePhoto_DeleteWorkerPhoto, HttpHelper.ModelToJson(workerPic));
                var response = HttpHelper.JsonToModel<BaseResponse>(result.message);
                if (response.Code != BusinessStatusCode.Success)
                {
                    UIMessageBox.ShowError($"{ApiConstants.EmployeePhoto_DeleteWorkerPhoto}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                PicHandler();
            }
            else
            {
                PicHandler();
            }

        }

        public void PicHandler()
        {
            Dictionary<string, string> additionalParams = new Dictionary<string, string>
            {
                { nameof(CreateEmployeePhotoInputDto.EmployeeId), txtWorkerNo.Text.Trim() }
            };

            var workerPic = new CreateEmployeePhotoInputDto
            {
                EmployeeId = txtWorkerNo.Text.Trim(),
                PhotoUrl = null,
            };
            var requestResult = HttpHelper.UploadFile(ApiConstants.EmployeePhoto_InsertWorkerPhoto, openPic.FileName, additionalParams);
            var response = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeePhotoOutputDto>>(requestResult.message);
            if (response.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{response.Message}:{ApiConstants.EmployeePhoto_InsertWorkerPhoto}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            UIMessageTip.ShowOk("头像上传成功！稍等将会加载头像哦..");
            picWorkerPic.Load(response.Data.PhotoPath);
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text))
            {
                AntdUI.Modal.open(this, LocalizationHelper.GetLocalizedString("System prompt", "系统提示"), LocalizationHelper.GetLocalizedString("Please input new password or old password", "请输入旧密码或新密码"), TType.Error);
                return;
            }

            var request = HttpHelper.Request(ApiConstants.Employee_UpdateEmployeeAccountPassword, HttpHelper.ModelToJson(new UpdateEmployeeInputDto
            {
                EmployeeId = LoginInfo.WorkerNo,
                OldPassword = txtOldPassword.Text.Trim(),
                Password = txtNewPassword.Text.Trim(),
                DataChgDate = DateTime.Now,
                DataChgUsr = LoginInfo.WorkerNo
            }));
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
