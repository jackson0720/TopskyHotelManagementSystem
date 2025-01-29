
namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmAddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAdmin));
            label1 = new AntdUI.Label();
            txtAccount = new AntdUI.Input();
            txtPassword = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            cbAccountType = new AntdUI.Select();
            txtName = new AntdUI.Input();
            label5 = new AntdUI.Label();
            btnAdd = new AntdUI.Button();
            btnReset = new AntdUI.Button();
            dgvAdminList = new AntdUI.Table();
            pgnPageNavigate = new AntdUI.Pagination();
            pageHeader1 = new AntdUI.PageHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 12.5F);
            label1.Location = new Point(174, 96);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 122;
            label1.Text = "账      号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Microsoft YaHei UI", 12F);
            txtAccount.Location = new Point(257, 88);
            txtAccount.Name = "txtAccount";
            txtAccount.PlaceholderText = "请输入管理员账户...";
            txtAccount.Size = new Size(175, 39);
            txtAccount.TabIndex = 123;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft YaHei UI", 12F);
            txtPassword.Location = new Point(535, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PasswordCopy = true;
            txtPassword.PlaceholderText = "请输入管理员密码...";
            txtPassword.Size = new Size(175, 39);
            txtPassword.TabIndex = 125;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12.5F);
            label2.Location = new Point(452, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 124;
            label2.Text = "账号密码";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 12.5F);
            label4.Location = new Point(174, 149);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 126;
            label4.Text = "账户类型";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbAccountType
            // 
            cbAccountType.Font = new Font("Microsoft YaHei UI", 12F);
            cbAccountType.List = true;
            cbAccountType.ListAutoWidth = true;
            cbAccountType.Location = new Point(257, 140);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.PlaceholderText = "请选择管理员类型...";
            cbAccountType.Size = new Size(175, 39);
            cbAccountType.TabIndex = 127;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft YaHei UI", 12F);
            txtName.Location = new Point(535, 141);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "请输入管理员姓名...";
            txtName.Size = new Size(175, 39);
            txtName.TabIndex = 129;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 12.5F);
            label5.Location = new Point(452, 149);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 128;
            label5.Text = "真实姓名";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 12F);
            btnAdd.Location = new Point(734, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 39);
            btnAdd.TabIndex = 130;
            btnAdd.Text = "添     加";
            btnAdd.Type = AntdUI.TTypeMini.Primary;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft YaHei UI", 12F);
            btnReset.Location = new Point(734, 140);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(93, 39);
            btnReset.TabIndex = 131;
            btnReset.Text = "重     置";
            btnReset.Type = AntdUI.TTypeMini.Primary;
            btnReset.Click += btnReset_Click;
            // 
            // dgvAdminList
            // 
            dgvAdminList.Bordered = true;
            dgvAdminList.Location = new Point(12, 198);
            dgvAdminList.Name = "dgvAdminList";
            dgvAdminList.Size = new Size(977, 380);
            dgvAdminList.TabIndex = 0;
            dgvAdminList.Text = "table1";
            // 
            // pgnPageNavigate
            // 
            pgnPageNavigate.Location = new Point(12, 584);
            pgnPageNavigate.Name = "pgnPageNavigate";
            pgnPageNavigate.ShowSizeChanger = true;
            pgnPageNavigate.Size = new Size(977, 27);
            pgnPageNavigate.TabIndex = 132;
            pgnPageNavigate.Total = 100;
            pgnPageNavigate.ValueChanged += pgnPageNavigate_ValueChanged;
            pgnPageNavigate.ShowTotalChanged += pgnPageNavigate_ShowTotalChanged;
            // 
            // pageHeader1
            // 
            pageHeader1.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader1.Location = new Point(0, 3);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowButton = true;
            pageHeader1.ShowIcon = true;
            pageHeader1.Size = new Size(1002, 41);
            pageHeader1.TabIndex = 133;
            pageHeader1.Text = "系统管理员";
            // 
            // FrmAddAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(1001, 623);
            ControlBox = false;
            Controls.Add(pageHeader1);
            Controls.Add(pgnPageNavigate);
            Controls.Add(dgvAdminList);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(cbAccountType);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtAccount);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddAdmin";
            Text = "添加管理员";
            Load += FrmAddAdmin_Load;
            ResumeLayout(false);
        }

        #endregion
        //private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMk;
        private AntdUI.Label label1;
        private AntdUI.Input txtAccount;
        private AntdUI.Input txtPassword;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Select cbAccountType;
        private AntdUI.Input txtName;
        private AntdUI.Label label5;
        private AntdUI.Button btnAdd;
        private AntdUI.Button btnReset;
        private AntdUI.Table dgvAdminList;
        private AntdUI.Pagination pgnPageNavigate;
        private AntdUI.PageHeader pageHeader1;
        //private AntdUI.WindowBar windowBar1;
    }
}