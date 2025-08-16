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

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmAvator : Window
    {
        public FrmAvator()
        {
            InitializeComponent();
        }

        private void FrmAvator_Load(object sender, EventArgs e)
        {

        }


        public void PicHandler()
        {
            Dictionary<string, string> additionalParams = new Dictionary<string, string>
            {
                { nameof(CreateEmployeePhotoInputDto.EmployeeId), LoginInfo.WorkerNo }
            };

            var workerPic = new CreateEmployeePhotoInputDto
            {
                EmployeeId = LoginInfo.WorkerNo.Trim(),
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

        private void picWorkerPic_Click(object sender, EventArgs e)
        {
            openPic.ShowDialog();
        }

        ResponseMsg result = new ResponseMsg();
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
                result = HttpHelper.Request(ApiConstants.EmployeePhoto_DeleteWorkerPhoto, workerPic.ModelToJson());
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

    }
}
