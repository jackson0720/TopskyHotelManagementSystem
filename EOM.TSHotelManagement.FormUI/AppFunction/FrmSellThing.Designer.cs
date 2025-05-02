namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmSellThing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSellThing));
            groupBox2 = new GroupBox();
            txtPrice = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            nudNum = new Sunny.UI.UIDoubleUpDown();
            uiLabel5 = new Sunny.UI.UILabel();
            txtSellName = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            txtSellNo = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            label1 = new AntdUI.Label();
            txtFind = new AntdUI.Input();
            btnFind = new AntdUI.Button();
            label2 = new AntdUI.Label();
            txtRoomNo = new AntdUI.Input();
            btnCheck = new AntdUI.Button();
            lblState = new AntdUI.Label();
            dgvSellthing = new AntdUI.Table();
            btnPg = new AntdUI.Pagination();
            btnAdd = new AntdUI.Button();
            btnCancel = new AntdUI.Button();
            dgvRoomSell = new AntdUI.Table();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(uiLabel6);
            groupBox2.Controls.Add(nudNum);
            groupBox2.Controls.Add(uiLabel5);
            groupBox2.Controls.Add(txtSellName);
            groupBox2.Controls.Add(uiLabel4);
            groupBox2.Controls.Add(txtSellNo);
            groupBox2.Controls.Add(uiLabel3);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(617, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 123);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "订购中心";
            // 
            // txtPrice
            // 
            txtPrice.Cursor = Cursors.IBeam;
            txtPrice.Font = new Font("微软雅黑", 12F);
            txtPrice.Location = new Point(310, 74);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.MinimumSize = new Size(1, 1);
            txtPrice.Name = "txtPrice";
            txtPrice.Padding = new Padding(5);
            txtPrice.Radius = 20;
            txtPrice.ReadOnly = true;
            txtPrice.ShowText = false;
            txtPrice.Size = new Size(116, 29);
            txtPrice.Style = Sunny.UI.UIStyle.Custom;
            txtPrice.TabIndex = 30;
            txtPrice.TextAlignment = ContentAlignment.MiddleLeft;
            txtPrice.Watermark = "";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("微软雅黑", 12F);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(258, 74);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(61, 29);
            uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            uiLabel6.TabIndex = 29;
            uiLabel6.Text = "单价：";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudNum
            // 
            nudNum.AutoValidate = AutoValidate.Disable;
            nudNum.Font = new Font("新宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            nudNum.Location = new Point(310, 30);
            nudNum.Margin = new Padding(4, 5, 4, 5);
            nudNum.Maximum = 9999D;
            nudNum.Minimum = 0D;
            nudNum.MinimumSize = new Size(100, 0);
            nudNum.Name = "nudNum";
            nudNum.Radius = 20;
            nudNum.ShowText = false;
            nudNum.Size = new Size(116, 29);
            nudNum.Step = 1D;
            nudNum.Style = Sunny.UI.UIStyle.Custom;
            nudNum.StyleCustomMode = true;
            nudNum.TabIndex = 25;
            nudNum.Text = null;
            nudNum.TextAlignment = ContentAlignment.MiddleCenter;
            nudNum.ValueChanged += nudNum_ValueChanged;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("微软雅黑", 12F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(258, 30);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(61, 29);
            uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            uiLabel5.TabIndex = 28;
            uiLabel5.Text = "数量：";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSellName
            // 
            txtSellName.Cursor = Cursors.IBeam;
            txtSellName.Font = new Font("微软雅黑", 12F);
            txtSellName.Location = new Point(107, 74);
            txtSellName.Margin = new Padding(4, 5, 4, 5);
            txtSellName.MinimumSize = new Size(1, 1);
            txtSellName.Name = "txtSellName";
            txtSellName.Padding = new Padding(5);
            txtSellName.Radius = 20;
            txtSellName.ReadOnly = true;
            txtSellName.ShowText = false;
            txtSellName.Size = new Size(145, 29);
            txtSellName.Style = Sunny.UI.UIStyle.Custom;
            txtSellName.TabIndex = 27;
            txtSellName.TextAlignment = ContentAlignment.MiddleLeft;
            txtSellName.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("微软雅黑", 12F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(26, 73);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(92, 29);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.TabIndex = 26;
            uiLabel4.Text = "商品名称：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSellNo
            // 
            txtSellNo.Cursor = Cursors.IBeam;
            txtSellNo.Font = new Font("微软雅黑", 12F);
            txtSellNo.Location = new Point(107, 30);
            txtSellNo.Margin = new Padding(4, 5, 4, 5);
            txtSellNo.MinimumSize = new Size(1, 1);
            txtSellNo.Name = "txtSellNo";
            txtSellNo.Padding = new Padding(5);
            txtSellNo.Radius = 20;
            txtSellNo.ReadOnly = true;
            txtSellNo.ShowText = false;
            txtSellNo.Size = new Size(145, 29);
            txtSellNo.Style = Sunny.UI.UIStyle.Custom;
            txtSellNo.TabIndex = 25;
            txtSellNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtSellNo.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(26, 29);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(92, 29);
            uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            uiLabel3.TabIndex = 23;
            uiLabel3.Text = "商品编号：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("微软雅黑", 12F);
            label1.Location = new Point(65, 51);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 26;
            label1.Text = "要查找的商品：";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFind
            // 
            txtFind.Font = new Font("微软雅黑", 12F);
            txtFind.Location = new Point(200, 44);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(197, 38);
            txtFind.TabIndex = 27;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("微软雅黑", 12F);
            btnFind.Location = new Point(407, 44);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(101, 38);
            btnFind.TabIndex = 28;
            btnFind.Text = "查     找";
            btnFind.Type = AntdUI.TTypeMini.Primary;
            btnFind.Click += btnFind_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 12F);
            label2.Location = new Point(518, 51);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 29;
            label2.Text = "消费房号：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("微软雅黑", 12F);
            txtRoomNo.Location = new Point(620, 44);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(134, 38);
            txtRoomNo.TabIndex = 30;
            txtRoomNo.TextChanged += txtRoomNo_TextChanged;
            txtRoomNo.Validated += txtRoomNo_Validated;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("微软雅黑", 12F);
            btnCheck.Location = new Point(764, 44);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(101, 38);
            btnCheck.TabIndex = 31;
            btnCheck.Text = "可否消费";
            btnCheck.Type = AntdUI.TTypeMini.Primary;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblState
            // 
            lblState.BackColor = Color.Transparent;
            lblState.Font = new Font("微软雅黑", 12F);
            lblState.Location = new Point(875, 51);
            lblState.Name = "lblState";
            lblState.Size = new Size(130, 23);
            lblState.TabIndex = 32;
            lblState.Text = "";
            lblState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSellthing
            // 
            dgvSellthing.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            dgvSellthing.Bordered = true;
            dgvSellthing.Font = new Font("Microsoft YaHei UI", 9F);
            dgvSellthing.Location = new Point(4, 88);
            dgvSellthing.Name = "dgvSellthing";
            dgvSellthing.Size = new Size(487, 351);
            dgvSellthing.TabIndex = 131;
            dgvSellthing.CellClick += dgvSellthing_CellClick;
            // 
            // btnPg
            // 
            btnPg.Current = 0;
            btnPg.Font = new Font("微软雅黑", 12F);
            btnPg.Location = new Point(4, 448);
            btnPg.Name = "btnPg";
            btnPg.PageSize = 15;
            btnPg.ShowSizeChanger = true;
            btnPg.Size = new Size(487, 31);
            btnPg.TabIndex = 135;
            btnPg.Total = 1000000;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("微软雅黑", 12F);
            btnAdd.Location = new Point(496, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 38);
            btnAdd.TabIndex = 136;
            btnAdd.Text = "确定添加";
            btnAdd.Type = AntdUI.TTypeMini.Primary;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("微软雅黑", 12F);
            btnCancel.Location = new Point(496, 174);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 38);
            btnCancel.TabIndex = 137;
            btnCancel.Text = "撤回添加";
            btnCancel.Type = AntdUI.TTypeMini.Primary;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvRoomSell
            // 
            dgvRoomSell.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            dgvRoomSell.Bordered = true;
            dgvRoomSell.Font = new Font("Microsoft YaHei UI", 9F);
            dgvRoomSell.Location = new Point(497, 217);
            dgvRoomSell.Name = "dgvRoomSell";
            dgvRoomSell.Size = new Size(572, 262);
            dgvRoomSell.TabIndex = 138;
            dgvRoomSell.CellClick += dgvRoomSell_CellClick;
            // 
            // FrmSellThing
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(1072, 486);
            Controls.Add(dgvRoomSell);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(btnPg);
            Controls.Add(dgvSellthing);
            Controls.Add(lblState);
            Controls.Add(btnCheck);
            Controls.Add(txtRoomNo);
            Controls.Add(label2);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsForbidAltF4 = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSellThing";
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "商品消费";
            ZoomScaleRect = new Rectangle(15, 15, 1072, 490);
            Load += FrmSellThing_Load;
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        //private Sunny.UI.UIDataGridView dgvRoomSell;
        private Sunny.UI.UITextBox txtPrice;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIDoubleUpDown nudNum;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtSellName;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtSellNo;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStock;
        private AntdUI.Label label1;
        private AntdUI.Input txtFind;
        private AntdUI.Button btnFind;
        private AntdUI.Label label2;
        private AntdUI.Input txtRoomNo;
        private AntdUI.Button btnCheck;
        private AntdUI.Label lblState;
        private AntdUI.Table dgvSellthing;
        private AntdUI.Pagination btnPg;
        private AntdUI.Button btnAdd;
        private AntdUI.Button btnCancel;
        private AntdUI.Table dgvRoomSell;
    }
}