using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class ucWindowHeader : UserControl
    {
        public ucWindowHeader()
        {
            InitializeComponent();
            if (!DesignMode) SetDefaults();
        }

        public ucWindowHeader(string title, string subTitle, Image? icon = null,
                              bool showIcon = true, bool showClose = true, bool showMinimize = true)
            : this()
        {
            ApplySettings(title, subTitle, icon, showIcon, showClose, showMinimize);
        }

        private void ApplySettings(string title, string subTitle, Image? icon,
                                  bool showIcon, bool showClose, bool showMinimize)
        {
            phCustoHeader.Text = title;
            phCustoHeader.SubText = subTitle;
            phCustoHeader.ShowIcon = showIcon;
            phCustoHeader.Icon = icon;
            btnClose.Visible = showClose;
            btnMinimize.Visible = showMinimize;
        }

        private void SetDefaults()
        {
            phCustoHeader.Text = string.Empty;
            phCustoHeader.SubText = string.Empty;
        }
    }
}
