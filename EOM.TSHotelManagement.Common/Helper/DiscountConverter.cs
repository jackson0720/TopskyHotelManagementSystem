using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOM.TSHotelManagement.Common
{
    public static class DiscountConverter
    {
        /// <summary>
        /// 将 decimal 类型的折扣转换为中文xx折表示
        /// 例如：0.8m → "八折", 0.85m → "八五折"
        /// </summary>
        public static string ToZheString(this decimal discount)
        {
            int percentage = (int)(discount * 100);

            return percentage switch
            {
                100 => "无折扣",
                var x when x % 10 == 0 => $"{ConvertDigit(x / 10)}折",
                _ => $"{ConvertDigit(percentage / 10)}{ConvertDigit(percentage % 10)}折"
            };
        }

        /// <summary>
        /// 数字转中文大写（0-9）
        /// </summary>
        private static string ConvertDigit(int num) => num switch
        {
            0 => "〇",
            1 => "一",
            2 => "二",
            3 => "三",
            4 => "四",
            5 => "五",
            6 => "六",
            7 => "七",
            8 => "八",
            9 => "九",
            _ => throw new ArgumentOutOfRangeException(nameof(num), "仅支持0-9数字转换")
        };
    }
}
