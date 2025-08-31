namespace EOM.TSHotelManagement.FormUI
{
    partial class ucWindowHeader
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWindowHeader));
            phCustoHeader = new AntdUI.PageHeader();
            btnMinimize = new AntdUI.Button();
            btnClose = new AntdUI.Button();
            tlpContainer = new TableLayoutPanel();
            phCustoHeader.SuspendLayout();
            SuspendLayout();
            // 
            // phCustoHeader
            // 
            phCustoHeader.BackColor = Color.FromArgb(22, 119, 255);
            phCustoHeader.CloseSize = 40;
            phCustoHeader.Controls.Add(btnMinimize);
            phCustoHeader.Controls.Add(btnClose);
            phCustoHeader.DividerColor = Color.White;
            phCustoHeader.DividerShow = true;
            phCustoHeader.Dock = DockStyle.Fill;
            phCustoHeader.Font = new Font("Noto Sans SC", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phCustoHeader.ForeColor = Color.White;
            phCustoHeader.Icon = (Image)resources.GetObject("phCustoHeader.Icon");
            phCustoHeader.Location = new Point(0, 0);
            phCustoHeader.MaximizeBox = false;
            phCustoHeader.MinimizeBox = false;
            phCustoHeader.Name = "phCustoHeader";
            phCustoHeader.ShowIcon = true;
            phCustoHeader.Size = new Size(391, 35);
            phCustoHeader.TabIndex = 141;
            phCustoHeader.Text = "自定义文字";
            phCustoHeader.UseSystemStyleColor = true;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(22, 119, 255);
            btnMinimize.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnMinimize.Location = new Point(333, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(23, 25);
            btnMinimize.TabIndex = 141;
            btnMinimize.Text = "—";
            btnMinimize.Type = AntdUI.TTypeMini.Info;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(22, 119, 255);
            btnClose.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnClose.Location = new Point(362, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 25);
            btnClose.TabIndex = 140;
            btnClose.Text = "×";
            btnClose.Type = AntdUI.TTypeMini.Info;
            btnClose.Click += btnClose_Click;
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 3;
            tlpContainer.ColumnStyles.Add(new ColumnStyle());
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContainer.ColumnStyles.Add(new ColumnStyle());
            tlpContainer.Dock = DockStyle.Fill;
            tlpContainer.Location = new Point(0, 0);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RowCount = 1;
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContainer.Size = new Size(391, 35);
            tlpContainer.TabIndex = 142;
            // 
            // ucWindowHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(phCustoHeader);
            Controls.Add(tlpContainer);
            Name = "ucWindowHeader";
            Size = new Size(391, 35);
            Load += ucWindowHeader_Load;
            phCustoHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public AntdUI.PageHeader phCustoHeader;
        private AntdUI.Button btnMinimize;
        private AntdUI.Button btnClose;
        private TableLayoutPanel tlpContainer;
    }
}
