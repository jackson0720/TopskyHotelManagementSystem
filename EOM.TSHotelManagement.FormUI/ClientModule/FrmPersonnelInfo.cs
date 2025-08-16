using AntdUI;
using EOM.TSHotelManagement.Common;
using EOM.TSHotelManagement.Common.Contract;
using jvncorelib.EntityLib;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmPersonnelInfo : Window
    {
        public FrmPersonnelInfo()
        {
            InitializeComponent();
        }

        private void FrmPersonnelInfo_Load(object sender, EventArgs e)
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
            cboEmployeeNation.Items.AddRange(nations.Data.Items.Select(item=> new AntdUI.SelectItem(item.NationName,item.NationNumber)).ToArray());
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
            cboGender.Items.AddRange(genderTypes.Data.Items.Select(item => new AntdUI.SelectItem(item.Description, item.Id)).ToArray());
            //加载部门信息
            result = HttpHelper.Request(ApiConstants.Base_SelectDeptAllCanUse);
            var depts = HttpHelper.JsonToModel<ListOutputDto<ReadDepartmentOutputDto>>(result.message);
            if (depts.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectDeptAllCanUse}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboEmployeeDepartment.Items.AddRange(depts.Data.Items.Select(item => new AntdUI.SelectItem(item.DepartmentName, item.DepartmentNumber)).ToArray());
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
            cboEmployeePosition.Items.AddRange(positions.Data.Items.Select(item => new AntdUI.SelectItem(item.PositionName, item.PositionNumber)).ToArray());

            LoadPersonnelInfo();
        }

        private void LoadPersonnelInfo()
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
                txtEmployeeId.Text = worker.EmployeeId;
                txtEmployeeName.Text = worker.EmployeeName;
                cboGender.SelectedValue = worker.Gender;
                cboEmployeePosition.Text = worker.PositionName;
                cboEmployeePosition.SelectedValue = worker.Position;
                cboEmployeeDepartment.Text = worker.DepartmentName;
                cboEmployeeDepartment.SelectedValue = worker.Department;
                cboEmployeeNation.Text = worker.EthnicityName;
                cboEmployeeNation.SelectedValue = worker.Ethnicity;
                txtEmployeeAddress.Text = worker.Address;
                txtEmployeeTel.Text = worker.PhoneNumber;
            }
            //dic = new Dictionary<string, string>
            //{
            //    { nameof(ReadEmployeePhotoInputDto.EmployeeId) , LoginInfo.WorkerNo }
            //};
            //result = HttpHelper.Request(ApiConstants.EmployeePhoto_EmployeePhoto, dic);
            //var workerPic = HttpHelper.JsonToModel<SingleOutputDto<ReadEmployeePhotoOutputDto>>(result.message);
            //if (workerPic.Code != BusinessStatusCode.Success)
            //{
            //    UIMessageBox.ShowError($"{ApiConstants.EmployeePhoto_EmployeePhoto}+接口服务异常，请提交Issue或尝试更新版本！");
            //    return;
            //}
            //var workerPicData = workerPic.Data;
            //if (workerPicData != null && !string.IsNullOrEmpty(workerPicData.PhotoPath))
            //{
            //    picWorkerPic.BackgroundImage = null;
            //    if (!string.IsNullOrEmpty(workerPicData.PhotoPath)) picWorkerPic.Load(workerPicData.PhotoPath);
            //}
            Refresh();
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployeeInputDto worker = new UpdateEmployeeInputDto()
            {
                EmployeeId = txtEmployeeId.Text.Trim(),
                EmployeeName = txtEmployeeName.Text.Trim(),
                Gender = cboGender.Text == "男" ? 1 : 0,
                Ethnicity = cboEmployeeNation.SelectedValue.ToString(),
                PhoneNumber = txtEmployeeTel.Text.Trim(),
                Address = txtEmployeeAddress.Text.Trim(),
                DataChgUsr = LoginInfo.WorkerNo,
                DataChgDate = DateTime.Now
            };

            if (CheckInput(worker))
            {
                result = HttpHelper.Request(ApiConstants.Employee_UpdateEmployee, worker.ModelToJson());
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
                LoadPersonnelInfo();
                return;
            }
        }
    }
}
