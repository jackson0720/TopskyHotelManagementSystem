using AntdUI;
using EOM.TSHotelManagement.Common;
using EOM.TSHotelManagement.Common.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM.TSHotelManagement.FormUI
{
    public static class NotificationService
    {
        public static void ShowSuccess(string message)
        {
            Modal.open(new Modal.Config(null, UIMessageConstant.Success, message, TType.Success)
            {
                Draggable = true,
                CancelText = null, 
                OkText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_Ok, UIMessageConstant.Chs_Ok)
            });
        }

        public static void ShowError(string message)
        {
            Modal.open(new Modal.Config(null, UIMessageConstant.Error, message, TType.Error)
            {
                Draggable = true,
                CancelText = null,
                OkText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_Ok, UIMessageConstant.Chs_Ok)
            });
        }

        public static void ShowInfo(string message)
        {
            Modal.open(new Modal.Config(null, UIMessageConstant.Information, message, TType.Info)
            {
                Draggable = true,
                CancelText = null,
                OkText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_Ok, UIMessageConstant.Chs_Ok)
            });
        }

        public static void ShowWarning(string message)
        {
            Modal.open(new Modal.Config(null, UIMessageConstant.Warning, message, TType.Warn)
            {
                Draggable = true,
                CancelText = null,
                OkText = LocalizationHelper.GetLocalizedString(UIMessageConstant.Eng_Ok, UIMessageConstant.Chs_Ok)
            });
        }
    }
}
