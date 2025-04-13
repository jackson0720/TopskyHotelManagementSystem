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
using EOM.TSHotelManagement.Common.Contract;
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
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { nameof(ReadNationInputDto.IsDelete), "0" },
                { nameof(ReadNationInputDto.IgnorePaging), "true" }
            };
            var result = HttpHelper.Request("Base/SelectNationAll", dic);
            var nations = HttpHelper.JsonToModel<ListOutputDto<ReadNationOutputDto>>(result.message);
            if (nations.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectNationAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cbWorkerNation.DataSource = nations.listSource;
            cbWorkerNation.DisplayMember = nameof(ReadNationOutputDto.NationName);
            cbWorkerNation.ValueMember = nameof(ReadNationOutputDto.NationNumber);
            //加载性别信息
            dic = new Dictionary<string, string>
            {
                { nameof(ReadGenderTypeInputDto.IsDelete), "0" },
                { nameof(ReadGenderTypeInputDto.IgnorePaging), "true" }
            };
            result = HttpHelper.Request("Base/SelectSexTypeAll", dic);
            var genderTypes = HttpHelper.JsonToModel<ListOutputDto<ReadGenderTypeOutputDto>>(result.message);
            if (genderTypes.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboSex.DataSource = genderTypes.listSource;
            cboSex.DisplayMember = nameof(ReadGenderTypeOutputDto.GenderName);
            cboSex.ValueMember = nameof(ReadGenderTypeOutputDto.GenderId);
            //加载部门信息
            result = HttpHelper.Request("Base/SelectDeptAllCanUse");
            var depts = HttpHelper.JsonToModel<ListOutputDto<ReadDepartmentOutputDto>>(result.message);
            if (depts.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectDeptAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboWorkerClub.DataSource = depts.listSource;
            cboWorkerClub.DisplayMember = nameof(ReadDepartmentOutputDto.DepartmentName);
            cboWorkerClub.ValueMember = nameof(ReadDepartmentOutputDto.DepartmentNumber);
            //加载职位信息
            dic = new Dictionary<string, string>
            {
                { nameof(ReadPositionInputDto.IsDelete), "0" },
                { nameof(ReadPositionInputDto.IgnorePaging), "true" }
            };
            result = HttpHelper.Request("Base/SelectPositionAll", dic);
            var positions = HttpHelper.JsonToModel<ListOutputDto<ReadPositionOutputDto>>(result.message);
            if (positions.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectPositionAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboWorkerPosition.DataSource = positions.listSource;
            cboWorkerPosition.DisplayMember = nameof(ReadPositionOutputDto.PositionName);
            cboWorkerPosition.ValueMember = nameof(ReadPositionOutputDto.PositionNumber);
            LoadData();
        }

        public void LoadData()
        {
            var dic = new Dictionary<string, string>
            {
                { nameof(ReadEmployeeInputDto.EmployeeId) , LoginInfo.WorkerNo }
            };
            var result = HttpHelper.Request("Employee/SelectEmployeeInfoByEmployeeId", dic);
            var employees = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeeOutputDto>>(result.message);
            if (employees.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectEmployeeInfoByEmployeeId+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            ReadEmployeeOutputDto worker = employees.Source;
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
            result = HttpHelper.Request("EmployeePhoto/EmployeePhoto", dic);
            var workerPic = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeePhotoOutputDto>>(result.message);
            if (workerPic.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("EmployeePhoto+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var workerPicSource = workerPic.Source;
            if (workerPicSource != null && !string.IsNullOrEmpty(workerPicSource.PhotoUrl))
            {
                picWorkerPic.BackgroundImage = null;
                if(!string.IsNullOrEmpty(workerPicSource.PhotoUrl)) picWorkerPic.LoadAsync(workerPicSource.PhotoUrl);
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
                result = HttpHelper.Request("Employee/UpdateEmployee", HttpHelper.ModelToJson(worker));
                var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                if (response.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError("UpdateEmployee+接口服务异常，请提交Issue或尝试更新版本！");
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
            var dic = new Dictionary<string, string>
            {
                { nameof(ReadEmployeePhotoInputDto.EmployeeId) , LoginInfo.WorkerNo }
            };
            result = HttpHelper.Request("EmployeePhoto/EmployeePhoto", dic);
            var workerPic = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeePhotoOutputDto>>(result.message);
            if (workerPic.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("EmployeePhoto+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var workerPicSource = workerPic.Source;
            if (!workerPicSource.IsNullOrEmpty() && !string.IsNullOrEmpty(workerPicSource.PhotoUrl))
            {
                result = HttpHelper.Request("EmployeePhoto/DeleteWorkerPhoto", HttpHelper.ModelToJson(workerPic));
                var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                if (response.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError("DeleteWorkerPhoto+接口服务异常，请提交Issue或尝试更新版本！");
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
            // To do ...
            //var serverPath = encryptLib.Decryption(HttpHelper.postUrl);
            //var result = HttpHelper.UpLoadFile(openPic.FileName, serverPath);
            //var workerPic = new CreateEmployeePhotoInputDto
            //{
            //    EmployeeId = txtWorkerNo.Text.Trim(),
            //    PhotoUrl = null,
            //};
            //var requestResult = HttpHelper.Request("EmployeePhoto/InsertWorkerPhoto", HttpHelper.ModelToJson(workerPic));
            //var response = HttpHelper.JsonToModel<BaseOutputDto>(requestResult.message);
            //if (response.StatusCode != StatusCodeConstants.Success)
            //{
            //    UIMessageBox.ShowError("InsertWorkerPhoto+接口服务异常，请提交Issue或尝试更新版本！");
            //    return;
            //}
            //picWorkerPic.BackgroundImage = null;
            //picWorkerPic.LoadAsync(null);
            //UIMessageTip.ShowOk("头像上传成功！稍等将会加载头像哦..");
        }

    }
}
