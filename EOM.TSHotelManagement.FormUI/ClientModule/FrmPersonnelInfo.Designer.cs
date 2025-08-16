namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmPersonnelInfo
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
            label7 = new Label();
            label5 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label1 = new Label();
            label2 = new Label();
            label16 = new Label();
            txtEmployeeId = new AntdUI.Input();
            txtEmployeeName = new AntdUI.Input();
            txtEmployeeAddress = new AntdUI.Input();
            txtEmployeeTel = new AntdUI.Input();
            cboGender = new AntdUI.Dropdown();
            cboEmployeeDepartment = new AntdUI.Dropdown();
            cboEmployeePosition = new AntdUI.Dropdown();
            cboEmployeeNation = new AntdUI.Dropdown();
            btnUpdate = new AntdUI.Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(12, 171);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 148;
            label7.Text = "联系方式";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(323, 69);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 136;
            label5.Text = "现任职位";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label32.Location = new Point(12, 18);
            label32.Name = "label32";
            label32.Size = new Size(88, 25);
            label32.TabIndex = 132;
            label32.Text = "员工编号";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label31.Location = new Point(12, 69);
            label31.Name = "label31";
            label31.Size = new Size(88, 25);
            label31.TabIndex = 133;
            label31.Text = "员工姓名";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label30.Location = new Point(12, 119);
            label30.Name = "label30";
            label30.Size = new Size(86, 25);
            label30.TabIndex = 134;
            label30.Text = "性      别";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(323, 119);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 145;
            label1.Text = "民      族";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 137;
            label2.Text = "居住地址";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label16.Location = new Point(323, 18);
            label16.Name = "label16";
            label16.Size = new Size(88, 25);
            label16.TabIndex = 135;
            label16.Text = "所在部门";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Noto Sans SC", 12F);
            txtEmployeeId.Location = new Point(109, 8);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Size = new Size(205, 45);
            txtEmployeeId.TabIndex = 149;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Noto Sans SC", 12F);
            txtEmployeeName.Location = new Point(109, 59);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(205, 45);
            txtEmployeeName.TabIndex = 150;
            // 
            // txtEmployeeAddress
            // 
            txtEmployeeAddress.Font = new Font("Noto Sans SC", 12F);
            txtEmployeeAddress.Location = new Point(109, 208);
            txtEmployeeAddress.Name = "txtEmployeeAddress";
            txtEmployeeAddress.Size = new Size(515, 45);
            txtEmployeeAddress.TabIndex = 151;
            // 
            // txtEmployeeTel
            // 
            txtEmployeeTel.Font = new Font("Noto Sans SC", 12F);
            txtEmployeeTel.Location = new Point(110, 159);
            txtEmployeeTel.Name = "txtEmployeeTel";
            txtEmployeeTel.Size = new Size(515, 45);
            txtEmployeeTel.TabIndex = 152;
            // 
            // cboGender
            // 
            cboGender.DropDownArrow = true;
            cboGender.Font = new Font("Noto Sans SC", 12F);
            cboGender.Location = new Point(109, 112);
            cboGender.Name = "cboGender";
            cboGender.Placement = AntdUI.TAlignFrom.Bottom;
            cboGender.Size = new Size(204, 40);
            cboGender.TabIndex = 153;
            cboGender.ToggleType = AntdUI.TTypeMini.Info;
            // 
            // cboEmployeeDepartment
            // 
            cboEmployeeDepartment.DropDownArrow = true;
            cboEmployeeDepartment.Font = new Font("Noto Sans SC", 12F);
            cboEmployeeDepartment.Location = new Point(421, 13);
            cboEmployeeDepartment.Name = "cboEmployeeDepartment";
            cboEmployeeDepartment.Placement = AntdUI.TAlignFrom.Bottom;
            cboEmployeeDepartment.Size = new Size(204, 40);
            cboEmployeeDepartment.TabIndex = 154;
            cboEmployeeDepartment.ToggleType = AntdUI.TTypeMini.Info;
            // 
            // cboEmployeePosition
            // 
            cboEmployeePosition.DropDownArrow = true;
            cboEmployeePosition.Font = new Font("Noto Sans SC", 12F);
            cboEmployeePosition.Location = new Point(421, 64);
            cboEmployeePosition.Name = "cboEmployeePosition";
            cboEmployeePosition.Placement = AntdUI.TAlignFrom.Bottom;
            cboEmployeePosition.Size = new Size(204, 40);
            cboEmployeePosition.TabIndex = 155;
            cboEmployeePosition.ToggleType = AntdUI.TTypeMini.Info;
            // 
            // cboEmployeeNation
            // 
            cboEmployeeNation.DropDownArrow = true;
            cboEmployeeNation.Font = new Font("Noto Sans SC", 12F);
            cboEmployeeNation.Location = new Point(421, 112);
            cboEmployeeNation.Name = "cboEmployeeNation";
            cboEmployeeNation.Placement = AntdUI.TAlignFrom.Bottom;
            cboEmployeeNation.Size = new Size(204, 40);
            cboEmployeeNation.TabIndex = 156;
            cboEmployeeNation.ToggleType = AntdUI.TTypeMini.Info;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Noto Sans SC", 12F);
            btnUpdate.Location = new Point(538, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 43);
            btnUpdate.TabIndex = 157;
            btnUpdate.Text = "修   改";
            btnUpdate.Type = AntdUI.TTypeMini.Info;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmPersonnelInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(637, 312);
            Controls.Add(btnUpdate);
            Controls.Add(cboEmployeeNation);
            Controls.Add(cboEmployeePosition);
            Controls.Add(cboEmployeeDepartment);
            Controls.Add(cboGender);
            Controls.Add(txtEmployeeTel);
            Controls.Add(txtEmployeeAddress);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeId);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label16);
            Name = "FrmPersonnelInfo";
            Text = "FrmPersonnelInfo";
            Load += FrmPersonnelInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label1;
        private Label label2;
        private Label label16;
        private AntdUI.Input txtEmployeeId;
        private AntdUI.Input txtEmployeeName;
        private AntdUI.Input txtEmployeeAddress;
        private AntdUI.Input txtEmployeeTel;
        private AntdUI.Dropdown cboGender;
        private AntdUI.Dropdown cboEmployeeDepartment;
        private AntdUI.Dropdown cboEmployeePosition;
        private AntdUI.Dropdown cboEmployeeNation;
        private AntdUI.Button btnUpdate;
    }
}