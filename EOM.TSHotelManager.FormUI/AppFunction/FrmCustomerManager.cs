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

using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmCustomerManager : Form
    {
        public static string cm_CustoNo;
        public static string cm_CustoName;
        public static int cm_CustoSex;
        public static string cm_CustoTel;
        public static int cm_PassportType;
        public static string cm_CustoID;
        public static string cm_CustoAddress;
        public static DateTime cm_CustoBirth;
        public static int cm_CustoType;

        public delegate void ReloadCustomerList(bool onlyVip);


        //定义委托类型的变量
        public static ReloadCustomerList ReloadCustomer;

        private LoadingProgress _loadingProgress;
        public FrmCustomerManager()
        {
            InitializeComponent();
            _loadingProgress = new LoadingProgress();
            ReloadCustomer = LoadCustomer;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        #region 用户管理界面加载事件方法
        private void FrmCustomerManager_Load(object sender, EventArgs e)
        {
            AntdUI.Spin.open(this, config =>
            {
                this.btnPg.PageSize = 15;
                LoadCustomer();
            });
        }
        #endregion

        private static bool? onlyVip = null;

        #region 加载用户信息列表
        private void LoadCustomer(bool onlyVip = false)
        {
            var dataCount = 0;
            btnPg.PageSizeOptions = new int[] { 15, 30, 50, 100 };
            dgvCustomerList.Spin("正在加载中...", config =>
            {
                TableComHelper tableComHelper = new TableComHelper();
                dgvCustomerList.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<Custo>());
                dgvCustomerList.DataSource = GetPageData(btnPg.Current, btnPg.PageSize, ref dataCount, onlyVip);
                btnPg.PageSize = 15;
                btnPg.Current = 1;
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }


        object GetPageData(int current, int pageSize, ref int totalCount, bool onlyVip = false)
        {
            dic = new Dictionary<string, string>()
            {
                { "pageIndex",current <= 0 ? "1":current.ToString()},
                { "pageSize",pageSize.ToString()}
            };
            if (onlyVip)
            {
                dic.Add("onlyVip", onlyVip.ToString());
            }
            result = HttpHelper.Request("Custo/SelectCustoAll", dic);
            if (result.statusCode != 200)
            {
                AntdUI.Message.error(this, "SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                return null!;
            }
            OSelectAllDto<Custo> custos = HttpHelper.JsonToModel<OSelectAllDto<Custo>>(result.message);
            totalCount = custos.total;
            var listTableSource = new List<AntdUI.AntItem[]>();

            custos.listSource = custos.listSource.OrderBy(a => a.CustoNo).ThenBy(a => a.CustoName).ToList();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(custos.listSource);

            return listTableSource;
        }

        #endregion

        int count = 0;
        private void btnSerach_BtnClick(object sender, EventArgs e)
        {
            OSelectAllDto<Custo> custos = new OSelectAllDto<Custo>();
            if (!txtCustoNo.Text.IsNullOrEmpty() || !txtCustoName.Text.IsNullOrEmpty())
            {
                if (!txtCustoNo.Text.IsNullOrEmpty())
                {
                    dic = new Dictionary<string, string>
                    {
                        { "CustoNo", txtCustoNo.Text.Trim() }
                    };
                }
                if (!txtCustoName.Text.IsNullOrEmpty())
                {
                    dic = new Dictionary<string, string>
                    {
                        { "CustoName",  txtCustoName.Text.Trim() }
                    };
                }
                result = HttpHelper.Request("Custo/SelectCustoByInfo", dic);
                if (result.statusCode != 200)
                {
                    AntdUI.Message.error(this, "SelectCustoByInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
            }
            else
            {
                result = HttpHelper.Request("Custo/SelectCustoAll?pageIndex=1&pageSize=15");
                if (result.statusCode != 200)
                {
                    AntdUI.Message.error(this, "SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
            }

            custos = HttpHelper.JsonToModel<OSelectAllDto<Custo>>(result.message);

            var listTableSource = new List<AntdUI.AntItem[]>();

            custos.listSource = custos.listSource.OrderBy(a => a.CustoNo).ThenBy(a => a.CustoName).ToList();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(custos.listSource);

            dgvCustomerList.Spin("正在加载中...", config =>
            {
                dgvCustomerList.DataSource = listTableSource;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });

            dgvCustomerList.DataSource = custos;
        }

        private void btnAddCusto_BtnClick(object sender, EventArgs e)
        {
            FrmEditInputs frmInputs = new FrmEditInputs();
            frmInputs.ShowDialog();
        }

        private void btnUpdCustomer_Click(object sender, EventArgs e)
        {

            if (dgvCustomerList.SelectedIndex < 0)
            {
                AntdUI.Message.error(this, "未选中客户，无法继续操作！");
                return;
            }
            FrmCustoManager.cm_CustoNo = cm_CustoNo;
            FrmCustoManager.cm_CustoName = cm_CustoName;
            FrmCustoManager.cm_CustoAddress = cm_CustoAddress.IsNullOrEmpty() ? "" : cm_CustoAddress.ToString();
            FrmCustoManager.cm_CustoType = Convert.ToInt32(cm_CustoType);
            FrmCustoManager.cm_CustoSex = Convert.ToInt32(cm_CustoSex);
            FrmCustoManager.cm_PassportType = Convert.ToInt32(cm_PassportType);
            FrmCustoManager.cm_CustoBirth = Convert.ToDateTime(cm_CustoBirth);
            FrmCustoManager.cm_CustoID = cm_CustoID;
            FrmCustoManager.cm_CustoTel = cm_CustoTel;
            FrmEditInputs frmInputs = new FrmEditInputs();
            frmInputs.Text = "修改客户信息";
            frmInputs.ShowDialog();
        }

        private void tsmiCustoNo_Click(object sender, EventArgs e)
        {
            if (!cm_CustoNo.IsNullOrEmpty())
            {
                Clipboard.SetText(cm_CustoNo);
                AntdUI.Message.success(this, "复制完成！");
            }
        }

        private void dgvCustomerList_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Record is IList<AntdUI.AntItem> data)
            {
                cm_CustoNo = data[0].value.ToString();
                cm_CustoName = data[1].value.ToString();
                cm_CustoSex = Convert.ToInt32(SexConstant.GetCodeByDescription(data[2].value.ToString()));
                cm_CustoTel = data[3].value.ToString();
                cm_CustoBirth = Convert.ToDateTime(data[4].value.ToString());
                cm_CustoType = Convert.ToInt32(CustomTypeConstant.GetCodeByDescription(data[5].value.ToString()));
                cm_PassportType = Convert.ToInt32(PassportConstant.GetCodeByDescription(data[6].value.ToString()));
                cm_CustoID = data[7].value.ToString();
                cm_CustoAddress = data[8].value.ToString();
                btnUpdCustomer.Enabled = true;
            }
        }

        private void cbOnlyVip_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            LoadCustomer(e.Value);
        }

        private string btnPg_ShowTotalChanged(object sender, AntdUI.PagePageEventArgs e)
        {
            return $"{e.PageSize} / {e.Total}条 共{e.PageTotal}页";
        }

        private void btnPg_ValueChanged(object sender, AntdUI.PagePageEventArgs e)
        {
            var dataCount = 0;
            dgvCustomerList.Spin("正在加载中...", config =>
            {
                dgvCustomerList.DataSource = GetPageData(e.Current, e.PageSize, ref dataCount,cbOnlyVip.Checked);
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }

        private void dgvCustomerList_CellDoubleClick(object sender, AntdUI.TableClickEventArgs e)
        {
            _loadingProgress.Show();
            if (e.Record is IList<AntdUI.AntItem> data)
            {
                FrmCustoManager.cm_CustoNo = data[0].value.ToString();
                FrmCustoManager.cm_CustoName = data[1].value.ToString();
                FrmCustoManager.cm_CustoSex = Convert.ToInt32(SexConstant.GetCodeByDescription(data[2].value.ToString()));
                FrmCustoManager.cm_CustoTel = data[3].value.ToString();
                FrmCustoManager.cm_CustoBirth = Convert.ToDateTime(data[4].value.ToString());
                FrmCustoManager.cm_CustoType = Convert.ToInt32(CustomTypeConstant.GetCodeByDescription(data[5].value.ToString()));
                FrmCustoManager.cm_PassportType = Convert.ToInt32(PassportConstant.GetCodeByDescription(data[6].value.ToString()));
                FrmCustoManager.cm_CustoID = data[7].value.ToString();
                FrmCustoManager.cm_CustoAddress = data[8].value.ToString();

                FrmEditInputs frmInputs = new FrmEditInputs(_loadingProgress);
                frmInputs.Text = "修改客户信息";
                frmInputs.ShowDialog();
            }
        }
    }

}
