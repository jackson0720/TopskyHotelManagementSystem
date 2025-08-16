﻿/*
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
using jvncorelib.CodeLib;
using jvncorelib.EntityLib;
using Sunny.UI;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmEditInputs : Window
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
            txtCustomerId.Text = cardId;

            #region 加载客户类型信息
            var result = HttpHelper.Request(ApiConstants.Base_SelectCustoTypeAllCanUse);
            var customerTypes = HttpHelper.JsonToModel<ListOutputDto<ReadCustoTypeOutputDto>>(result.message);
            if (customerTypes.Code != BusinessStatusCode.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectCustoTypeAllCanUse}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var lstDataGrid = customerTypes.Data.Items;
            this.cboCustomerType.Items.AddRange(lstDataGrid.Select(item => new AntdUI.SelectItem(item.CustomerTypeName, item.CustomerType)).ToArray());
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
            this.cboPassportType.Items.AddRange(passPorts.Select(item => new AntdUI.SelectItem(item.PassportName, item.PassportId)).ToArray());
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
            this.cboGender.Items.AddRange(listSexType.Select(item => new AntdUI.SelectItem(item.Description, item.Id)).ToArray());
            #endregion

            if (this.Text.Equals("修改客户信息"))
            {
                txtCustomerId.Text = FrmCustomerManager.cm_CustoNo;
                txtCustomerName.Text = FrmCustomerManager.cm_CustoName;
                txtCustomerAddress.Text = FrmCustomerManager.cm_CustoAddress;
                cboCustomerType.SelectedValue = FrmCustomerManager.cm_CustoType;
                cboGender.SelectedValue = FrmCustomerManager.cm_CustoSex;
                cboPassportType.SelectedValue = FrmCustomerManager.cm_PassportType;
                dtpDateOfBirth.Value = FrmCustomerManager.cm_CustoBirth;
                txtCustomerCardID.Text = FrmCustomerManager.cm_CustoIdCardNumber;
                txtCustomerTel.Text = FrmCustomerManager.cm_CustoTel;
                btnOk.Text = "修改";

                this.btnOk.Click -= new EventHandler(FrmEditInputs_ButtonOkClick);
                this.btnOk.Click += new EventHandler(btnOK_UpdClick);

                //if (!cboPassportType.SelectedValue.ToString().Contains("身份证"))
                //{
                //    dtpBirthday.Enabled = true;
                //    dtpBirthday.ReadOnly = false;
                //    return;
                //}

            }
        }

        private void btnOK_UpdClick(object sender, EventArgs e)
        {
            UpdateCustomerInputDto custo = new UpdateCustomerInputDto()
            {
                Id = FrmCustomerManager.cm_CustoId,
                CustomerNumber = txtCustomerId.Text,
                CustomerName = txtCustomerName.Text,
                CustomerGender = Convert.ToInt32(cboGender.SelectedValue.ToString()),
                DateOfBirth = DateOnly.FromDateTime(Convert.ToDateTime(dtpDateOfBirth.Value).Date),
                CustomerType = Convert.ToInt32(cboCustomerType.SelectedValue.ToString()),
                PassportId = Convert.ToInt32(cboPassportType.SelectedValue),
                IdCardNumber = txtCustomerCardID.Text,
                CustomerPhoneNumber = txtCustomerTel.Text,
                CustomerAddress = txtCustomerAddress.Text,
                IsDelete = 0,
                DataChgUsr = LoginInfo.WorkerNo,
            };

            result = HttpHelper.Request(ApiConstants.Customer_UpdCustomerInfo, custo.ModelToJson());
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
        }

        private void FrmEditInputs_ButtonOkClick(object sender, EventArgs e)
        {
            CreateCustomerInputDto custo = new CreateCustomerInputDto()
            {
                DataInsDate = DateTime.Now,
                CustomerNumber = txtCustomerId.Text,
                CustomerName = txtCustomerName.Text,
                CustomerGender = Convert.ToInt32(cboGender.SelectedValue.ToString()),
                DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value).Date,
                CustomerType = Convert.ToInt32(cboCustomerType.SelectedValue.ToString()),
                PassportId = Convert.ToInt32(cboPassportType.SelectedValue.ToString()),
                IdCardNumber = txtCustomerCardID.Text,
                CustomerPhoneNumber = txtCustomerTel.Text,
                CustomerAddress = txtCustomerAddress.Text,
                DataInsUsr = LoginInfo.WorkerNo,
                IsDelete = 0
            };

            result = HttpHelper.Request(ApiConstants.Customer_InsertCustomerInfo, custo.ModelToJson());
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
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = txtCustomerCardID.Text.Trim();

            if (!cboPassportType.Text.ToString().Contains("身份证"))
            {
                dtpDateOfBirth.Enabled = true;
                dtpDateOfBirth.ReadOnly = false;
                return;
            }
            if (string.IsNullOrEmpty(identityCard))
            {
                //身份证号码不能为空，如果为空返回
                UIMessageBox.ShowError("身份证号码不能为空！");
                if (txtCustomerCardID.CanFocus)
                {
                    txtCustomerCardID.Focus();//设置当前输入焦点为txtCardID_identityCard
                }
                return;
            }
            else
            {
                //身份证号码只能为15位或18位其它不合法
                if (identityCard.Length != 15 && identityCard.Length != 18)
                {
                    UIMessageBox.ShowWarning("身份证号码为15位或18位，请检查！");
                    if (txtCustomerCardID.CanFocus)
                    {
                        txtCustomerCardID.Focus();
                    }
                    return;
                }
            }

            if (identityCard.Length == 18)
            {
                var result = ApplicationUtil.SearchCode(identityCard);
                if (string.IsNullOrEmpty(result.message)) //如果没有错误消息输出，则代表成功
                {
                    try
                    {
                        cboGender.Text = result.sex ?? string.Empty;
                        txtCustomerAddress.Text = result.address ?? string.Empty;

                        if (DateTime.TryParse(result.birthday, out DateTime parsedDate))
                        {
                            dtpDateOfBirth.Value = parsedDate;
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
