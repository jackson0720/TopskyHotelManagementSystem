namespace EOM.TSHotelManager.FormUI
{
    partial class FrmCustomerManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            cmsCustoManager = new Sunny.UI.UIContextMenuStrip();
            tsmiCustoNo = new ToolStripMenuItem();
            uiLine1 = new Sunny.UI.UILine();
            btnSerach = new AntdUI.Button();
            btnAddCusto = new AntdUI.Button();
            btnUpdCustomer = new AntdUI.Button();
            dgvCustomerList = new AntdUI.Table();
            btnPg = new AntdUI.Pagination();
            cbOnlyVip = new AntdUI.Checkbox();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            txtCustoName = new AntdUI.Input();
            txtCustoNo = new AntdUI.Input();
            cmsCustoManager.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "获取账号";
            // 
            // cmsCustoManager
            // 
            cmsCustoManager.BackColor = Color.FromArgb(243, 249, 255);
            cmsCustoManager.Font = new Font("微软雅黑", 12F);
            cmsCustoManager.Items.AddRange(new ToolStripItem[] { tsmiCustoNo });
            cmsCustoManager.Name = "cmsCustoManager";
            cmsCustoManager.Size = new Size(177, 30);
            // 
            // tsmiCustoNo
            // 
            tsmiCustoNo.Image = Properties.Resources.复制;
            tsmiCustoNo.Name = "tsmiCustoNo";
            tsmiCustoNo.Size = new Size(176, 26);
            tsmiCustoNo.Text = "复制用户编号";
            tsmiCustoNo.Click += tsmiCustoNo_Click;
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("微软雅黑", 12F);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.Location = new Point(772, 411);
            uiLine1.Margin = new Padding(4);
            uiLine1.MinimumSize = new Size(2, 3);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(291, 24);
            uiLine1.TabIndex = 124;
            uiLine1.Text = "右键可复制快速客户编号";
            // 
            // btnSerach
            // 
            btnSerach.Font = new Font("Microsoft YaHei UI", 12F);
            btnSerach.Location = new Point(602, 441);
            btnSerach.Name = "btnSerach";
            btnSerach.Size = new Size(93, 47);
            btnSerach.TabIndex = 127;
            btnSerach.Text = "搜    索";
            btnSerach.Type = AntdUI.TTypeMini.Primary;
            btnSerach.Click += btnSerach_BtnClick;
            // 
            // btnAddCusto
            // 
            btnAddCusto.Font = new Font("Microsoft YaHei UI", 12F);
            btnAddCusto.Location = new Point(772, 441);
            btnAddCusto.Name = "btnAddCusto";
            btnAddCusto.Size = new Size(93, 47);
            btnAddCusto.TabIndex = 128;
            btnAddCusto.Text = "添加客户";
            btnAddCusto.Type = AntdUI.TTypeMini.Primary;
            btnAddCusto.Click += btnAddCusto_BtnClick;
            // 
            // btnUpdCustomer
            // 
            btnUpdCustomer.Enabled = false;
            btnUpdCustomer.Font = new Font("Microsoft YaHei UI", 12F);
            btnUpdCustomer.Location = new Point(942, 441);
            btnUpdCustomer.Name = "btnUpdCustomer";
            btnUpdCustomer.Size = new Size(93, 47);
            btnUpdCustomer.TabIndex = 129;
            btnUpdCustomer.Text = "修改客户";
            btnUpdCustomer.Type = AntdUI.TTypeMini.Primary;
            btnUpdCustomer.Click += btnUpdCustomer_Click;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.Bordered = true;
            dgvCustomerList.ContextMenuStrip = cmsCustoManager;
            dgvCustomerList.Location = new Point(10, 7);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.Size = new Size(1053, 391);
            dgvCustomerList.TabIndex = 130;
            dgvCustomerList.CellClick += dgvCustomerList_CellClick;
            dgvCustomerList.CellDoubleClick += dgvCustomerList_CellDoubleClick;
            // 
            // btnPg
            // 
            btnPg.Current = 0;
            btnPg.Location = new Point(10, 404);
            btnPg.Name = "btnPg";
            btnPg.PageSize = 15;
            btnPg.ShowSizeChanger = true;
            btnPg.Size = new Size(636, 31);
            btnPg.TabIndex = 134;
            btnPg.Total = 1000000;
            btnPg.ValueChanged += btnPg_ValueChanged;
            btnPg.ShowTotalChanged += btnPg_ShowTotalChanged;
            // 
            // cbOnlyVip
            // 
            cbOnlyVip.AutoCheck = true;
            cbOnlyVip.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbOnlyVip.Location = new Point(630, 412);
            cbOnlyVip.Name = "cbOnlyVip";
            cbOnlyVip.Size = new Size(120, 23);
            cbOnlyVip.TabIndex = 148;
            cbOnlyVip.Text = "仅查看会员";
            cbOnlyVip.CheckedChanged += cbOnlyVip_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 12.5F);
            label1.Location = new Point(283, 453);
            label1.Name = "label1";
            label1.Size = new Size(86, 26);
            label1.TabIndex = 152;
            label1.Text = "客户姓名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.TooltipConfig = null;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12.5F);
            label2.Location = new Point(12, 453);
            label2.Name = "label2";
            label2.Size = new Size(86, 26);
            label2.TabIndex = 151;
            label2.Text = "客户编号";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.TooltipConfig = null;
            // 
            // txtCustoName
            // 
            txtCustoName.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoName.Location = new Point(375, 444);
            txtCustoName.Name = "txtCustoName";
            txtCustoName.PlaceholderText = "请输入客户姓名...";
            txtCustoName.Size = new Size(173, 42);
            txtCustoName.TabIndex = 150;
            // 
            // txtCustoNo
            // 
            txtCustoNo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoNo.Location = new Point(104, 444);
            txtCustoNo.Name = "txtCustoNo";
            txtCustoNo.PlaceholderText = "请输入客户编号...";
            txtCustoNo.Size = new Size(173, 42);
            txtCustoNo.TabIndex = 149;
            // 
            // FrmCustomerManager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(1072, 490);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtCustoName);
            Controls.Add(txtCustoNo);
            Controls.Add(cbOnlyVip);
            Controls.Add(btnPg);
            Controls.Add(dgvCustomerList);
            Controls.Add(btnUpdCustomer);
            Controls.Add(btnAddCusto);
            Controls.Add(btnSerach);
            Controls.Add(uiLine1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmCustomerManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TS酒店管理系统";
            Load += FrmCustomerManager_Load;
            cmsCustoManager.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private Sunny.UI.UIContextMenuStrip cmsCustoManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustoNo;
        private Sunny.UI.UILine uiLine1;
        private AntdUI.Button btnSerach;
        private AntdUI.Button btnAddCusto;
        private AntdUI.Button btnUpdCustomer;
        private AntdUI.Table dgvCustomerList;
        private AntdUI.Pagination btnPg;
        private AntdUI.Checkbox cbOnlyVip;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input txtCustoName;
        private AntdUI.Input txtCustoNo;
    }
}