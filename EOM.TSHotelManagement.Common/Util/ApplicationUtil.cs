﻿using EOM.TSHotelManagement.Common.Contract;
using jvncorelib.EntityLib;
using System.Diagnostics;
using System.Reflection;

namespace EOM.TSHotelManagement.Common
{
    /// <summary>
    /// 静态工具
    /// </summary>
    public static class ApplicationUtil
    {
        /// <summary>
        /// 证件号码归属地查询
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Card SearchCode(string code)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                { nameof(ReadCardCodeInputDto.IdentityCardNumber), code.Substring(0,6) }
            };
            var input = new ReadCardCodeInputDto
            {
                IdentityCardNumber = code.Substring(0, 6)
            };
            ResponseMsg result = HttpHelper.Request(ApiConstants.Utility_SelectCardCode, input.ModelToJson());
            var response = HttpHelper.JsonToModel<SingleOutputDto<ReadCardCodeOutputDto>>(result.message);
            if (response.StatusCode != StatusCodeConstants.Success)
            {
                return new Card { message = "SelectCardCode+接口服务异常，请提交Issue或尝试更新版本！" };
            }

            if (!response.Source.IsNullOrEmpty())
            {
                var address = $"{response.Source.Province}{response.Source.City}{response.Source.District}";
                var birthday = code.Substring(6, 4) + "-" + code.Substring(10, 2) + "-" + code.Substring(12, 2);
                var sex = code.Substring(14, 3);
                //性别代码为偶数是女性奇数为男性
                if (int.Parse(sex) % 2 == 0)
                {
                    sex = "女";
                }
                else
                {
                    sex = "男";
                }
                return new Card { message = string.Empty, sex = sex, address = address, birthday = birthday };
            }
            else
            {
                return new Card() { message = "未配置号码表" };
            }
        }

        /// <summary>
        /// 获取当前程序版本号
        /// </summary>
        /// <returns></returns>
        public static Version GetApplicationVersion()
        {
            StackTrace stackTrace = new StackTrace();

            StackFrame callingFrame = stackTrace.GetFrame(1);
            if (callingFrame != null)
            {
                MethodBase method = callingFrame.GetMethod();
                if (method != null)
                {
                    Assembly callingAssembly = method.DeclaringType.Assembly;
                    Version currentVersion = callingAssembly.GetName().Version;
                    return currentVersion;
                }
            }

            return null;
        }

        /// <summary>
        /// 身份证实体类
        /// </summary>
        public class Card
        {
            /// <summary>
            /// 消息
            /// </summary>
            public string message { get; set; }
            /// <summary>
            /// 性别
            /// </summary>
            public string sex { get; set; }
            /// <summary>
            /// 出生日期
            /// </summary>
            public string birthday { get; set; }
            /// <summary>
            /// 地址
            /// </summary>
            public string address { get; set; }
        }
    }
}
