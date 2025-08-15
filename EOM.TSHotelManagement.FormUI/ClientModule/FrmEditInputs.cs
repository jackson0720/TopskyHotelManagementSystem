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
using jvncorelib.CodeLib;
using Sunny.UI;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmEditInputs : UIEditForm
    {
        private LoadingProgress? _loadingProgress;
        public FrmEditInputs(LoadingProgress? loadingProgress = null)
        {
            InitializeComponent();
            _loadingProgress = loadingProgress;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void FrmEditInputs_Load(object sender, EventArgs e)
        {
            string cardId = new UniqueCode().GetNewId("TS");
            txtCustoNo.Text = cardId;

            #region 加载客户类型信息
            var result = HttpHelper.Request(ApiConstants.Base_SelectCustoTypeAllCanUse);
            var customerTypes = HttpHelper.JsonToModel<ListOutputDto<ReadCustoTypeOutputDto>>(result.message);
            if (customerTypes.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectCustoTypeAllCanUse}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var lstDataGrid = customerTypes.Data.Items;
            this.cbCustoType.DataSource = lstDataGrid;
            this.cbCustoType.DisplayMember = nameof(ReadCustoTypeOutputDto.CustomerTypeName);
            this.cbCustoType.ValueMember = nameof(ReadCustoTypeOutputDto.CustomerType);
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            result = HttpHelper.Request(ApiConstants.Base_SelectPassPortTypeAllCanUse);
            var passportTypes = HttpHelper.JsonToModel<ListOutputDto<ReadPassportTypeOutputDto>>(result.message);
            if (passportTypes.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectPassPortTypeAllCanUse}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var passPorts = passportTypes.Data.Items;
            this.cbPassportType.DataSource = passPorts;
            this.cbPassportType.DisplayMember = nameof(ReadPassportTypeOutputDto.PassportName);
            this.cbPassportType.ValueMember = nameof(ReadPassportTypeOutputDto.PassportId);
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
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
            var listSexType = genderTypes.Data.Items;
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = nameof(ReadGenderTypeOutputDto.Description);
            this.cbSex.ValueMember = nameof(ReadGenderTypeOutputDto.Id);
            this.cbSex.SelectedIndex = 0;
            #endregion

            if (this.Text.Equals("修改客户信息"))
            {
                txtCustoNo.Text = FrmCustomerManager.cm_CustoNo;
                txtCustoName.Text = FrmCustomerManager.cm_CustoName;
                txtCustoAdress.Text = FrmCustomerManager.cm_CustoAddress;
                cbCustoType.SelectedValue = FrmCustomerManager.cm_CustoType;
                cbSex.SelectedValue = FrmCustomerManager.cm_CustoSex;
                cbPassportType.SelectedValue = FrmCustomerManager.cm_PassportType;
                dtpBirthday.Value = FrmCustomerManager.cm_CustoBirth;
                txtCardID.Text = FrmCustomerManager.cm_CustoIdCardNumber;
                txtCustoAdress.Text = FrmCustomerManager.cm_CustoAddress;
                txtTel.Text = FrmCustomerManager.cm_CustoTel;
                btnOK.Text = "修改";

                this.ButtonOkClick -= new EventHandler(FrmEditInputs_ButtonOkClick);
                this.ButtonOkClick += new EventHandler(btnOK_UpdClick);

                if (!cbPassportType.SelectedText.ToString().Contains("身份证"))
                {
                    dtpBirthday.Enabled = true;
                    dtpBirthday.ReadOnly = false;
                    return;
                }

            }
        }

        private void btnOK_UpdClick(object sender, EventArgs e)
        {
            UpdateCustomerInputDto custo = new UpdateCustomerInputDto()
            {
                Id = FrmCustomerManager.cm_CustoId,
                CustomerNumber = txtCustoNo.Text,
                CustomerName = txtCustoName.Text,
                CustomerGender = Convert.ToInt32(cbSex.SelectedValue.ToString()),
                DateOfBirth = DateOnly.FromDateTime(dtpBirthday.Value.Date),
                CustomerType = Convert.ToInt32(cbCustoType.SelectedValue.ToString()),
                PassportId = Convert.ToInt32(cbPassportType.SelectedValue),
                IdCardNumber = txtCardID.Text,
                CustomerPhoneNumber = txtTel.Text,
                CustomerAddress = txtCustoAdress.Text,
                IsDelete = 0,
                DataChgUsr = LoginInfo.WorkerNo,
            };

            result = HttpHelper.Request(ApiConstants.Customer_UpdCustomerInfo, HttpHelper.ModelToJson(custo));
            var response = HttpHelper.JsonToModel<BaseResponse>(result.message);
            if (response.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.Show("修改失败", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }

            UIMessageBox.Show("修改成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "修改了一名客户信息，客户编号为：" + custo.CustomerNumber, Common.Core.LogLevel.Critical);
            #endregion
            this.Close();
            FrmCustomerManager.ReloadCustomer(false);

            foreach (Control Ctrol in this.Controls)
            {
                if (Ctrol is Sunny.UI.UITextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is Sunny.UI.UIComboBox)
                {
                    this.cbSex.SelectedIndex = 0;
                    this.cbCustoType.SelectedIndex = 0;
                    this.cbPassportType.SelectedIndex = 0;
                }
            }
        }

        private void FrmEditInputs_ButtonOkClick(object sender, EventArgs e)
        {
            CreateCustomerInputDto custo = new CreateCustomerInputDto()
            {
                DataInsDate = DateTime.Now,
                CustomerNumber = txtCustoNo.Text,
                CustomerName = txtCustoName.Text,
                CustomerGender = Convert.ToInt32(cbSex.SelectedValue.ToString()),
                DateOfBirth = dtpBirthday.Value.Date,
                CustomerType = Convert.ToInt32(cbCustoType.SelectedValue.ToString()),
                PassportId = Convert.ToInt32(cbPassportType.SelectedValue.ToString()),
                IdCardNumber = txtCardID.Text,
                CustomerPhoneNumber = txtTel.Text,
                CustomerAddress = txtCustoAdress.Text,
                DataInsUsr = LoginInfo.WorkerNo,
                IsDelete = 0
            };

            result = HttpHelper.Request(ApiConstants.Customer_InsertCustomerInfo, HttpHelper.ModelToJson(custo));
            var response = HttpHelper.JsonToModel<BaseResponse>(result.message);
            if (response.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.Show($"添加失败\n{response.Message}", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }
            UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
            FrmCustomerManager.ReloadCustomer(false);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "添加了一名客户，客户编号为：" + custo.CustomerNumber, Common.Core.LogLevel.Critical);
            #endregion
            this.Close();


            foreach (Control Ctrol in this.Controls)
            {
                if (Ctrol is Sunny.UI.UITextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is Sunny.UI.UIComboBox)
                {
                    this.cbSex.SelectedIndex = 0;
                    this.cbCustoType.SelectedIndex = 0;
                    this.cbPassportType.SelectedIndex = 0;
                }
            }
        }


        private void FrmEditInputs_ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = txtCardID.Text.Trim();

            if (!cbPassportType.Text.ToString().Contains("身份证"))
            {
                dtpBirthday.Enabled = true;
                dtpBirthday.ReadOnly = false;
                return;
            }
            if (string.IsNullOrEmpty(identityCard))
            {
                //身份证号码不能为空，如果为空返回
                UIMessageBox.ShowError("身份证号码不能为空！");
                if (txtCardID.CanFocus)
                {
                    txtCardID.Focus();//设置当前输入焦点为txtCardID_identityCard
                }
                return;
            }
            else
            {
                //身份证号码只能为15位或18位其它不合法
                if (identityCard.Length != 15 && identityCard.Length != 18)
                {
                    UIMessageBox.ShowWarning("身份证号码为15位或18位，请检查！");
                    if (txtCardID.CanFocus)
                    {
                        txtCardID.Focus();
                    }
                    return;
                }
            }

            if (identityCard.Length == 18)
            {
                var result = ApplicationUtil.SearchCode(identityCard);
                if (result.message.IsNullOrEmpty()) //如果没有错误消息输出，则代表成功
                {
                    try
                    {
                        cbSex.Text = result.sex ?? string.Empty;
                        txtCustoAdress.Text = result.address ?? string.Empty;

                        if (DateTime.TryParse(result.birthday, out DateTime parsedDate))
                        {
                            dtpBirthday.Value = parsedDate;
                        }
                        else
                        {
                            UIMessageBox.ShowError("请正确输入证件号码！");
                            return;
                        }
                    }
                    catch
                    {
                        UIMessageBox.ShowError("请正确输入证件号码！");
                        return;
                    }
                    finally
                    {
                        cbPassportType.SelectedIndex = 0;
                    }
                }
                else
                {
                    UIMessageBox.ShowError(result.message);
                    return;
                }
            }
            return;
        }
    }
}
