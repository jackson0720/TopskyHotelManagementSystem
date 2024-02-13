﻿/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

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
using System;

using System.Windows.Forms;
using SYS.Core;
using SYS.FormUI.Properties;
using System.Collections.Generic;
using SYS.Application;
using Sunny.UI;
using SYS.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SYS.FormUI
{
    public partial class FrmCustoManager : UIForm
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

        public delegate void ReloadCustomerList();


        //定义委托类型的变量
        public static ReloadCustomerList ReloadCusto;

        public FrmCustoManager()
        {
            InitializeComponent();
            ReloadCusto = LoadCustomer;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void FrmCustoManager_Load(object sender, EventArgs e)
        {
            //dgvCustomerList.AutoGenerateColumns = false;
            this.btnPg.PageSize = 15;
            LoadCustomer();
            LoadCustoType();
            //txtCustoNo.ReadOnly = true;
            //cboSex.SelectedIndex = 0;
            //cboCustoType.SelectedIndex = 3;
        }
        #region 加载客户类型事件方法
        public void LoadCustoType()
        {
            //cboCustoType.DataSource = CustoTypeManager.SelectCustoTypesAll();
            //cboCustoType.DisplayMember = "TypeName";//显示的列名
            //cboCustoType.ValueMember = "UserType";//绑定的值
        }
        #endregion

        int count = 0;
        #region 加载用户信息列表
        private void LoadCustomer()
        {
            dic = new Dictionary<string, string>()
            {
                { "pageIndex","1"},
                { "pageSize","15"}
            };
            result = HttpHelper.Request("Custo/SelectCustoAll",null,dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            OSelectCustoAllDto custos = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
            this.btnPg.TotalCount = custos.total;
            this.dgvCustomerList.AutoGenerateColumns = false;
            this.dgvCustomerList.DataSource = custos.listSource;
        }
        #endregion


        #region 添加会员信息事件方法
        private void picAddCusto_Click_1(object sender, EventArgs e)
        {
            FrmEditInputs frmInputs = new FrmEditInputs();
            frmInputs.ShowDialog();
            frmInputs.Text = "添加客户";
        }
        #endregion

        #region 修改会员信息事件方法
        private void picUpdateCusto_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count < 0)
            {
                UIMessageBox.Show("未选中客户，无法继续操作！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }
            cm_CustoNo = dgvCustomerList.SelectedRows[0].Cells["CustoNo"].Value.ToString();
            cm_CustoName = dgvCustomerList.SelectedRows[0].Cells["CustoName"].Value.ToString();
            cm_CustoSex = (int)dgvCustomerList.SelectedRows[0].Cells["Column4"].Value;
            cm_CustoTel = dgvCustomerList.SelectedRows[0].Cells["CustoTel"].Value.ToString();
            cm_PassportType = (int)dgvCustomerList.SelectedRows[0].Cells["Column1"].Value;
            cm_CustoID = dgvCustomerList.SelectedRows[0].Cells["Column3"].Value.ToString();
            cm_CustoAddress = dgvCustomerList.SelectedRows[0].Cells["CustoAdress"].Value.ToString();
            cm_CustoBirth = Convert.ToDateTime(dgvCustomerList.SelectedRows[0].Cells["CustoBirth"].Value);
            cm_CustoType = (int)dgvCustomerList.SelectedRows[0].Cells["Column2"].Value;
            FrmEditInputs frmInputs = new FrmEditInputs();
            frmInputs.Text = "修改客户信息";
            frmInputs.ShowDialog();
        }
        #endregion

        #region 搜索会员信息事件方法
        private void picSearch_Click_1(object sender, EventArgs e)
        {
            dgvCustomerList.ClearRows();
            dgvCustomerList.AutoGenerateColumns = false;
            OSelectCustoAllDto custos = new OSelectCustoAllDto();
            if (!txtCustoNo.Text.IsNullOrEmpty())
            {
                dic = new Dictionary<string, string>
                {
                    { "CustoNo", txtCustoNo.Text.Trim() }
                };
                result = HttpHelper.Request("Custo/SelectCustoByInfo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                custos = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
            }
            else if (!txtCustoName.Text.IsNullOrEmpty())
            {
                dic = new Dictionary<string, string>
                {
                    { "CustoName",  txtCustoName.Text.Trim() }
                };
                result = HttpHelper.Request("Custo/SelectCustoByInfo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectCustoByInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                custos = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
            }
            else
            {
                result = HttpHelper.Request("Custo/SelectCustoAll?pageIndex=1&pageSize=15");
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                custos = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
            }
            dgvCustomerList.DataSource = custos;
        }
        #endregion

        #region 导出事件方法
        private void picLoadOut_Click_1(object sender, EventArgs e)
        {
            //#region 导出信息保存为Excel表
            //bool tf = UIMessageBox.Show("导出信息为敏感操作，确定要继续导出吗？(此步操作将写入操作日志)", "信息提醒",UIStyle.Orange,UIMessageBoxButtons.OKCancel);
            //if (!tf)
            //{

            //    //Response.ContentEncoding = System.Text.Encoding.UTF8;
            //    string fileName = "";
            //    string saveFileName = "";
            //    //fileName.Charset = "GB2312";
            //    SaveFileDialog saveDialog = new SaveFileDialog();
            //    //saveDialog.DefaultExt = "xls";
            //    saveDialog.FileName = fileName;
            //    saveDialog.Filter = "2003~2007工作表*.xls|*.xls|2010及以上版本工作表*.xlsx|*.xlsx";
            //    saveDialog.ShowDialog();
            //    saveFileName = saveDialog.FileName;
            //    if (saveFileName.IndexOf(":") < 0) return;
            //    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //    if (xlApp == null)
            //    {
            //        UIMessageBox.Show("无法创建Excel对象,您的电脑可能未安装Excel！", "来自T仔的提醒",UIStyle.Red);
            //        return;
            //    }
            //    Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            //    Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            //    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            //    for (int i = 0; i < this.dgvCustomerList.Columns.Count; i++)
            //    {
            //        xlApp.Cells[1, i + 1] = dgvCustomerList.Columns[i].HeaderText;
            //    }
            //    for (int i = 0; i < dgvCustomerList.Rows.Count; i++)//添加每一项
            //    {
            //        for (int j = 0; j < dgvCustomerList.Columns.Count; j++)
            //        {
            //            xlApp.Cells[i + 2, j + 1] = dgvCustomerList.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    System.Windows.Forms.Application.DoEvents();
            //    worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            //    UIMessageBox.Show(fileName + "信息导出成功", "来自T仔提示",UIStyle.Green, UIMessageBoxButtons.OK);
            //    #region 获取添加操作日志所需的信息
            //    RecordHelper.Record(LoginInfo.WorkerClub + LoginInfo.WorkerName + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "导出了" + "后台用户信息!", 3);
            //    #endregion
                
            //    System.Diagnostics.Process.Start("Explorer.exe", saveFileName);
            //    if (saveFileName != "")
            //    {
            //        try
            //        {
            //            workbook.Saved = true;
            //            workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
            //        }
            //        catch (Exception ex)
            //        {//fileSaved = false;                      
            //            UIMessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
            //            return;
            //        }
            //    }
            //    xlApp.Quit();
            //    GC.Collect();
            //}
            //#endregion
        }

        #endregion

        private void btnPg_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            dic = new Dictionary<string, string>()
            {
                { "pageIndex",pageIndex.ToString()},
                { "pageSize",count.ToString()}
            };
            result = HttpHelper.Request("Custo/SelectCustoAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            OSelectCustoAllDto custos = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
            btnPg.TotalCount = custos.total;
            this.dgvCustomerList.AutoGenerateColumns = false;
            this.dgvCustomerList.DataSource = custos.listSource;
        }

        private void btnPg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsmiCustoNo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvCustomerList.Rows[0].Cells["CustoNo"].Value as string);
            UIMessageTip.ShowOk("复制完成！", 1500);
        }
    }
}
