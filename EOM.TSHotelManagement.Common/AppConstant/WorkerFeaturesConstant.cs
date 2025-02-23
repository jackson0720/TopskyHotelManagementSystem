using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOM.TSHotelManagement.Common
{
    public class WorkerFeaturesConstant : Constant<WorkerFeaturesConstant>
    {
        // 群众
        public static readonly WorkerFeaturesConstant TheMasses = new WorkerFeaturesConstant("群众", "群众");
        // 团员
        public static readonly WorkerFeaturesConstant GroupMember = new WorkerFeaturesConstant("团员", "团员");
        // 党员
        public static readonly WorkerFeaturesConstant PoliticalPartyMember = new WorkerFeaturesConstant("党员", "党员");
        // 预备党员
        public static readonly WorkerFeaturesConstant PoliticalPartyReserveMember = new WorkerFeaturesConstant("预备党员", "预备党员");

        private WorkerFeaturesConstant(string code, string description) : base(code, description)
        {
        }
    }

    public class WorkerFeatures
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
