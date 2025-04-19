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
using EOM.TSHotelManagement.Common.Core;
using EOM.TSHotelManagement.Shared;
using jvncorelib.CodeLib;
using Sunny.UI;
using System.Transactions;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmReserList : UIForm
    {
        public FrmReserList()
        {
            InitializeComponent();
        }

        ResponseMsg result = new ResponseMsg();
        Dictionary<string, string> dic = null;

        public static string RoomNumber { get; set; } = string.Empty;
        public static string ReservationId { get; set; } = string.Empty;

        TableComHelper helper = new TableComHelper();

        private void LoadReserData()
        {
            var dataCount = 0;
            btnPg.PageSizeOptions = new int[] { 15, 30, 50, 100 };
            dgvReserList.Spin("正在加载中...", config =>
            {
                TableComHelper tableComHelper = new TableComHelper();
                dgvReserList.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<ReadReserOutputDto>());
                dgvReserList.DataSource = GetPageData(btnPg.Current, btnPg.PageSize, ref dataCount);
                btnPg.PageSize = 15;
                btnPg.Current = 1;
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }

        object GetPageData(int current, int pageSize, ref int totalCount)
        {
            dic = new Dictionary<string, string>()
            {
                { nameof(ReadReserInputDto.Page), current <= 0 ? "1":current.ToString() },
                { nameof(ReadReserInputDto.PageSize), pageSize.ToString() },
                { nameof(ReadReserInputDto.IsDelete), "0" }
            };
            result = HttpHelper.Request(ApiConstants.Reser_SelectReserAll, dic);
            var resers = HttpHelper.JsonToModel<ListOutputDto<ReadReserOutputDto>>(result.message);
            if (resers.StatusCode != StatusCodeConstants.Success)
            {
                AntdUI.Message.error(this, $"{ApiConstants.Reser_SelectReserAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return null!;
            }
            List<ReadReserOutputDto> reserDataSource = resers.listSource;
            totalCount = resers.total;
            var listTableSource = new List<AntdUI.AntItem[]>();

            reserDataSource = reserDataSource.OrderBy(a => a.ReservationId).ThenBy(a => a.CustomerName).ToList();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(reserDataSource);

            return listTableSource;
        }

        private string btnPg_ShowTotalChanged(object sender, AntdUI.PagePageEventArgs e)
        {
            return $"{e.PageSize} / {e.Total}条 共{e.PageTotal}页";
        }

        private void btnPg_ValueChanged(object sender, AntdUI.PagePageEventArgs e)
        {
            var dataCount = 0;
            dgvReserList.Spin("正在加载中...", config =>
            {
                dgvReserList.DataSource = GetPageData(e.Current, e.PageSize, ref dataCount);
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }

        private void FrmReserList_Load(object sender, EventArgs e)
        {
            LoadReserData();

            #region 加载客户类型信息
            result = HttpHelper.Request(ApiConstants.Base_SelectCustoTypeAllCanUse);
            var customerTypeDataSource = HttpHelper.JsonToModel<ListOutputDto<ReadCustoTypeOutputDto>>(result.message);
            if (customerTypeDataSource.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectCustoTypeAllCanUse}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<ReadCustoTypeOutputDto> lstSourceGrid = customerTypeDataSource.listSource;
            this.cbCustoType.DataSource = lstSourceGrid;
            this.cbCustoType.DisplayMember = nameof(ReadCustoTypeOutputDto.CustomerTypeName);
            this.cbCustoType.ValueMember = nameof(ReadCustoTypeOutputDto.CustomerType);
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            result = HttpHelper.Request(ApiConstants.Base_SelectPassPortTypeAllCanUse);
            var passportDataSource = HttpHelper.JsonToModel<ListOutputDto<ReadPassportTypeOutputDto>>(result.message);
            if (passportDataSource.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectPassPortTypeAllCanUse}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<ReadPassportTypeOutputDto> passPorts = passportDataSource.listSource;
            this.cbPassportType.DataSource = passPorts;
            this.cbPassportType.DisplayMember = nameof(ReadPassportTypeOutputDto.PassportName);
            this.cbPassportType.ValueMember = nameof(ReadPassportTypeOutputDto.PassportId);
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            dic = new Dictionary<string, string>
            {
                { nameof(ReadGenderTypeInputDto.IsDelete), "0"},
                { nameof(ReadGenderTypeInputDto.IgnorePaging), "true" }
            };
            result = HttpHelper.Request(ApiConstants.Base_SelectGenderTypeAll, dic);
            var genderTypeDataSource = HttpHelper.JsonToModel<ListOutputDto<EnumDto>>(result.message);
            if (genderTypeDataSource.StatusCode != StatusCodeConstants.Success)
            {
                UIMessageBox.ShowError($"{ApiConstants.Base_SelectGenderTypeAll}+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<EnumDto> listSexType = genderTypeDataSource.listSource;
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = nameof(EnumDto.Description);
            this.cbSex.ValueMember = nameof(EnumDto.Id);
            #endregion
        }

        private void dgvReserList_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Record is IList<AntdUI.AntItem> data)
            {
                ReservationId = helper.GetValue(data, nameof(ReadReserOutputDto.ReservationId));
                RoomNumber = helper.GetValue(data, nameof(ReadReserOutputDto.ReservationRoomNumber));
                string custoNo = new UniqueCode().GetNewId("TS-");
                txtCustoNo.Text = custoNo;
                txtCustoName.Text = helper.GetValue(data, nameof(ReadReserOutputDto.CustomerName));
                txtTel.Text = helper.GetValue(data, nameof(ReadReserOutputDto.ReservationPhoneNumber));
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var custo = new CreateCustomerInputDto()
                {
                    CustomerNumber = txtCustoNo.Text.Trim(),
                    CustomerName = txtCustoName.Text.Trim(),
                    CustomerGender = Convert.ToInt32(cbSex.SelectedValue.ToString()),
                    CustomerPhoneNumber = txtTel.Text.Trim(),
                    PassportId = Convert.ToInt32(cbPassportType.SelectedValue.ToString()),
                    IdCardNumber = txtCardID.Text.Trim(),
                    CustomerAddress = txtCustoAdress.Text.Trim(),
                    DateOfBirth = dtpBirthday.Value,
                    CustomerType = Convert.ToInt32(cbCustoType.SelectedValue.ToString()),
                    IsDelete = 0,
                    DataInsUsr = LoginInfo.WorkerNo,
                    DataInsDate = DateTime.Now,
                };
                result = HttpHelper.Request(ApiConstants.Customer_InsertCustomerInfo, HttpHelper.ModelToJson(custo));
                var response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                if (response.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError($"{ApiConstants.Customer_InsertCustomerInfo}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }

                UpdateRoomInputDto r = new UpdateRoomInputDto()
                {
                    LastCheckInTime = DateTime.Now,
                    CustomerNumber = custo.CustomerNumber,
                    RoomStateId = new EnumHelper().GetEnumValue(RoomState.Occupied),
                    RoomNumber = RoomNumber,
                    DataChgDate = DateTime.Now,
                    DataChgUsr = LoginInfo.WorkerNo
                };
                result = HttpHelper.Request(ApiConstants.Room_UpdateRoomInfo, HttpHelper.ModelToJson(r));
                response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                if (response.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError($"{ApiConstants.Room_UpdateRoomInfo}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                var reser = new DeleteReserInputDto
                {
                    ReservationId = ReservationId,
                    IsDelete = 1,
                    DataChgUsr = LoginInfo.WorkerNo,
                    DataChgDate = DateTime.Now
                };
                result = HttpHelper.Request(ApiConstants.Reser_DeleteReserInfo, HttpHelper.ModelToJson(reser));
                response = HttpHelper.JsonToModel<BaseOutputDto>(result.message);
                if (response.StatusCode != StatusCodeConstants.Success)
                {
                    UIMessageBox.ShowError($"{ApiConstants.Reser_DeleteReserInfo}+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }

                UIMessageBox.ShowSuccess("操作成功");
                LoadReserData();
                FrmRoomManager.Reload("");
                FrmRoomManager._RefreshRoomCount();
                scope.Complete();
                this.Close();
            }
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = txtCardID.Text.Trim();

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
                var result = ApplicationUtil.searchCode(identityCard);
                if (result.message.IsNullOrEmpty()) //如果没有错误消息输出，则代表成功
                {
                    try
                    {
                        cbSex.Text = result.sex;
                        txtCustoAdress.Text = result.address;
                        dtpBirthday.Value = Convert.ToDateTime(result.birthday);
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
