using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOM.TSHotelManager.Common
{
    public class AdminConstant : Constant<AdminConstant>
    {
        // 超级管理员
        public static readonly AdminConstant Admin = new AdminConstant("Admin", "超级管理员");
        // 财务经理
        public static readonly AdminConstant FinanceManager = new AdminConstant("FinanceManager", "财务经理");
        // 总经理
        public static readonly AdminConstant GeneralManager = new AdminConstant("GeneralManager", "总经理");
        // 酒店经理
        public static readonly AdminConstant HotelManager = new AdminConstant("HotelManager", "酒店经理");
        // 人力资源经理
        public static readonly AdminConstant HRManager = new AdminConstant("HRManager", "人力资源经理");
        // 后勤经理
        public static readonly AdminConstant LogisticsManager = new AdminConstant("LogisticsManager", "后勤经理");
        // 监管小组
        public static readonly AdminConstant CheckGroup = new AdminConstant("CheckGroup", "监管小组");

        private AdminConstant(string code, string description) : base(code, description)
        {
        }
    }
}
