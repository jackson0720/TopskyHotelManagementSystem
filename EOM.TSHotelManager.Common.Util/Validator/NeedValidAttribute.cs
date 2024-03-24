using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOM.TSHotelManager.Common.Util
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NeedValidAttribute : Attribute
    {
    }
}
