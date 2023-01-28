/*
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
using Sunny.UI;
using SYS.Application;
using SYS.Common;
using SYS.Core;
using SYS.FormUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmNation : UIForm
    {

        public delegate void OperationInfo();

        public static OperationInfo reload;

        public FrmNation()
        {
            InitializeComponent();
            reload = ReloadNationList;
        }

        List<Nation> nations = null;
        public static string info = null;
        private void FrmNation_Load(object sender, EventArgs e)
        {
            ReloadNationList();
        }

        ResponseMsg result = new ResponseMsg();
        Dictionary<string, string> dic = null;

        public void ReloadNationList()
        {
            txtNationNo.Text = Util.GetListNewId("N", 3, 1, "-").FirstOrDefault();
            result = HttpHelper.Request("Base/SelectNationAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNationAll+接口服务异常，请提交Issue！");
                return;
            }
            nations = HttpHelper.JsonToList<Nation>(result.message);
            dgvNationList.AutoGenerateColumns = false;
            dgvNationList.DataSource = nations;
        }

        private void dgvNationList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNationNo.Text = dgvNationList.Rows[0].Cells["clNationNo"].Value.ToString();
            txtNationName.Text = dgvNationList.Rows[0].Cells["clNationName"].Value.ToString();
        }

        private void btnAddNation_Click(object sender, EventArgs e)
        {
            if (txtNationName.Text.Trim().IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("民族名称为空，请检查", 1500);
                txtNationName.Focus();
                return;
            }
            var nat = new Nation()
            {
                nation_no = txtNationNo.Text.Trim(),
                nation_name = txtNationName.Text.Trim(),
                delete_mk = 0,
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            result = HttpHelper.Request("Base​/AddNation", HttpHelper.ModelToJson(nat));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("AddNation+接口服务异常，请提交Issue！", 1500);
                return;
            }
            UIMessageTip.ShowOk("添加民族成功！", 1500);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增民族类型操作！新增值为：" + nat.nation_no, 2);
            #endregion
            ReloadNationList();
            return;
        }

        private void btnUpdateNation_Click(object sender, EventArgs e)
        {
            if (dgvNationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的民族数据，请检查", 1500);
                return;
            }
            var nat = new Nation()
            {
                nation_no = txtNationNo.Text.Trim(),
                nation_name = txtNationName.Text.Trim(),
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            };
            result = HttpHelper.Request("Base​/UpdNation", HttpHelper.ModelToJson(nat));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("UpdNation+接口服务异常，请提交Issue！", 1500);
                return;
            }
        }

        private void btnDeleteNation_Click(object sender, EventArgs e)
        {
            if (dgvNationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的民族数据，请检查", 1500);
                return;
            }
            var nat = new Nation()
            {
                nation_no = txtNationNo.Text.Trim(),
                nation_name = txtNationName.Text.Trim(),
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            };
            result = HttpHelper.Request("Base​/DelNation", HttpHelper.ModelToJson(nat));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("DelNation+接口服务异常，请提交Issue！", 1500);
                return;
            }
        }
    }
}
