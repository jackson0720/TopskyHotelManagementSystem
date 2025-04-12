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
using Sunny.UI;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmSelectCustoInfo : UIForm
    {
        public FrmSelectCustoInfo()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        #region 存放客户信息类
        public static string co_CustoNo;
        public static string co_RoomNo;
        public static string co_CustoName;
        public static string co_CustoBirthday;
        public static string co_CustoSex;
        public static string co_CustoTel;
        public static string co_CustoPassportType;
        public static string co_CustoAddress;
        public static string co_CustoType;
        public static string co_CustoID;
        #endregion

        private void FrmSelectCustoInfo_Load(object sender, EventArgs e)
        {
            #region 加载客户类型信息
            result = HttpHelper.Request("Base/SelectCustoTypeAllCanUse");
            var customerTypes = HttpHelper.JsonToModel<ListOutputDto<ReadCustoTypeOutputDto>>(result.message);
            if (customerTypes.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectCustoTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            this.cbCustoType.DataSource = customerTypes.listSource;
            this.cbCustoType.DisplayMember = nameof(ReadCustoTypeOutputDto.CustomerTypeName);
            this.cbCustoType.ValueMember = nameof(ReadCustoTypeOutputDto.CustomerType);
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            result = HttpHelper.Request("Base/SelectPassPortTypeAllCanUse");
            var passportTypes = HttpHelper.JsonToModel<ListOutputDto<ReadPassportTypeOutputDto>>(result.message);
            if (passportTypes.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectPassPortTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            this.cbPassportType.DataSource = passportTypes.listSource;
            this.cbPassportType.DisplayMember = nameof(ReadPassportTypeOutputDto.PassportName);
            this.cbPassportType.ValueMember = nameof(ReadPassportTypeOutputDto.PassportId);
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadGenderTypeInputDto.IsDelete),"0" },
                { nameof(ReadGenderTypeInputDto.IgnorePaging), "true" }
            };
            result = HttpHelper.Request("Base/SelectSexTypeAll", dic);
            var dataSources = HttpHelper.JsonToModel<ListOutputDto<ReadGenderTypeOutputDto>>(result.message);
            if (dataSources.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            this.cbSex.DataSource = dataSources.listSource;
            this.cbSex.DisplayMember = nameof(ReadGenderTypeOutputDto.GenderName);
            this.cbSex.ValueMember = nameof(ReadGenderTypeOutputDto.GenderId);
            this.cbSex.SelectedIndex = 0;
            #endregion

            txtCustoNo.Text = ucRoom.rm_CustoNo;
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadCustomerInputDto.CustomerNumber),txtCustoNo.Text.ToString() }
            };
            result = HttpHelper.Request("Customer/SelectCustoByInfo", dic);
            var c = HttpHelper.JsonToModel<SingleOutputDto<ReadCustomerOutputDto>>(result.message);
            if (c.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError("SelectCustoByInfo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            txtCustoAdress.Text = c.Source.CustomerAddress;
            txtCustoName.Text = c.Source.CustomerName;
            txtCardID.Text = c.Source.IdCardNumber;
            txtCustoTel.Text = c.Source.CustomerPhoneNumber;
            cbSex.Text = c.Source.CustomerGender == 1 ? "男" : "女";
            cbCustoType.SelectedValue = c.Source.CustomerType;
            cbPassportType.SelectedValue = c.Source.PassportId;
            dtpBirthday.Value = Convert.ToDateTime(c.Source.DateOfBirth);
        }
    }
}
