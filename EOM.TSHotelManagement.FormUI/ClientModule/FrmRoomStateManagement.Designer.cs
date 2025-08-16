namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmRoomStateManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomStateManager));
            label2 = new Label();
            label1 = new Label();
            txtRoomNo = new AntdUI.Input();
            cboRoomState = new AntdUI.Dropdown();
            btnOk = new AntdUI.Button();
            ucWindowHeader1 = new ucWindowHeader();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(7, 54);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 132;
            label2.Text = "客户编号";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(7, 106);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 134;
            label1.Text = "房间状态";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("Noto Sans SC", 12F);
            txtRoomNo.Location = new Point(99, 44);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(203, 45);
            txtRoomNo.TabIndex = 137;
            // 
            // cboRoomState
            // 
            cboRoomState.DropDownArrow = true;
            cboRoomState.Font = new Font("Noto Sans SC", 12F);
            cboRoomState.Location = new Point(99, 98);
            cboRoomState.Name = "cboRoomState";
            cboRoomState.Placement = AntdUI.TAlignFrom.Bottom;
            cboRoomState.Size = new Size(200, 40);
            cboRoomState.TabIndex = 138;
            cboRoomState.ToggleType = AntdUI.TTypeMini.Info;
            cboRoomState.SelectedValueChanged += cboRoomState_SelectedValueChanged;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Noto Sans SC", 12F);
            btnOk.Location = new Point(215, 147);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(87, 43);
            btnOk.TabIndex = 140;
            btnOk.Text = "修   改";
            btnOk.Type = AntdUI.TTypeMini.Info;
            btnOk.Click += btnOk_Click;
            // 
            // ucWindowHeader1
            // 
            ucWindowHeader1.Location = new Point(0, 0);
            ucWindowHeader1.Name = "ucWindowHeader1";
            ucWindowHeader1.Size = new Size(309, 35);
            ucWindowHeader1.TabIndex = 141;
            // 
            // FrmRoomStateManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(308, 196);
            Controls.Add(ucWindowHeader1);
            Controls.Add(btnOk);
            Controls.Add(cboRoomState);
            Controls.Add(txtRoomNo);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRoomStateManager";
            Text = "修改房间状态";
            Load += FrmRoomStateManager_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AntdUI.Input txtRoomNo;
        private AntdUI.Dropdown cboRoomState;
        private AntdUI.Button btnOk;
        private ucWindowHeader ucWindowHeader1;
    }
}