using jvncorelib.EncryptorLib;
using jvncorelib.EntityLib;
using jvncorelib.HttpLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Input;

namespace EOM.TSHotelManager.Common
{
    /// <summary>
    /// 文件上传帮助类
    /// </summary>
    public static class HttpHelper
    {
        static EncryptLib encrypt = new EncryptLib();

        #region 受限于打包插件的限制才放在这，个人开发时建议统一在App.Config进行配置

        /// <summary>
        /// 数据库配置连接
        /// </summary>
        public const string mysqlString = "server = localhost; user id = softuser; password = .; database = tshoteldb;";
        /// <summary>
        /// 照片文件配置URL
        /// </summary>
        public const string baseUrl = "";
        /// <summary>
        /// 上传照片URL
        /// </summary>
        public const string postUrl = "";
        /// <summary>
        /// WebApi URL(release)
        /// </summary>
        public const string apiUrl = "";
        /// <summary>
        /// WebApi URL(debug)
        /// </summary>
        //public const string apiUrl = "1/F8hHIvdiAzWpBv3RqANkv1On8CAw01xgL+WewjgIA=·0*%#^f<a#$^b;d>*a0d?d*#0<<b$^<a^";

        #endregion

        public class IgnoreNullValuesConverter : JsonConverter
        {
            private readonly bool _convertEmptyStringToNull;

            public IgnoreNullValuesConverter(bool convertEmptyStringToNull = false)
            {
                _convertEmptyStringToNull = convertEmptyStringToNull;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                JObject obj = JObject.FromObject(value, serializer);

                foreach (var prop in obj.Properties().ToList())
                {
                    if (prop.Value == null || string.IsNullOrEmpty(prop.Value.ToString()))
                    {
                        if (_convertEmptyStringToNull && prop.Value?.Type == JTokenType.String)
                        {
                            prop.Value = JValue.CreateNull();
                        }
                        else
                        {
                            prop.Remove();
                        }
                    }
                }

                obj.WriteTo(writer);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(JObject);
            }

            public override bool CanRead => false;
        }

        /// <summary>
        /// WebClient上传文件至服务器
        /// </summary>
        /// <param name="fileNamePath">文件名，全路径格式</param>
        /// <param name="uriString">服务器文件夹路径</param>
        public static string UpLoadFile(string fileNamePath, string uriString)
        {
            // 创建WebClient实例
            WebClient myWebClient = new WebClient();
            byte[] responseData = myWebClient.UploadFile(uriString, "POST", fileNamePath);//得到返回的内容
            String str = Encoding.UTF8.GetString(responseData);//得到的目的字符串

            return str.Replace('\"', ' ');
        }

        /// <summary>
        /// 统一请求方法
        /// </summary>
        /// <param name="url"></param>
        /// <param name="json"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static ResponseMsg Request(string url, string json = null, Dictionary<string, string> dic = null)
        {
            ResponseMsg msg = new ResponseMsg();

            //处理url
            var sourceStr = url.Replace("​", string.Empty);

            //解密原始URL
            var api = encrypt.Decryption(apiUrl);

            var requestUrl = api + sourceStr;

            if (!json.IsNullOrEmpty())
            {
                msg = DoPost(requestUrl, json);
            }
            else if (!dic.IsNullOrEmpty())
            {
                msg = DoGet(requestUrl, dic);
            }
            else
            {
                msg = DoGet(requestUrl);
            }

            return msg;
        }
        /// <summary>
        /// GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <param name="contentType"></param>
        /// <param name="referer"></param>
        /// <param name="cookie"></param>
        /// <param name="dicHeaders"></param>
        /// <returns></returns>
        public static ResponseMsg DoGet(string url, IDictionary<string, string> parameters = null, string contentType = null, string referer = null, string cookie = null, Dictionary<string, string> dicHeaders = null)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters);
                }
            }

            var reponse = new RestResponse();
            var client = new RestClient(url);
            var request = new RestRequest();

            string resultContent = "";
            RestResponse rsp = null;

            try
            {
                if (!string.IsNullOrEmpty(referer))
                {
                    request.AddHeader("Referer", referer);
                }

                if (!string.IsNullOrEmpty(cookie))
                {
                    request.AddHeader("Cookie", cookie);
                }

                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36");

                if (dicHeaders != null)
                {
                    foreach (var key in dicHeaders.Keys)
                    {
                        request.AddHeader(key, dicHeaders[key]);
                    }
                }

                var token = LoginInfo.UserToken.IsNullOrEmpty() ? AdminInfo.UserToken : LoginInfo.UserToken;

                request.AddHeader("Authorization", string.Format("Bearer {0}", token));
                rsp = client.ExecuteGet(request);

                resultContent = rsp.Content;
            }
            catch (Exception)
            {
                throw;
            }

            return new ResponseMsg() { statusCode = (int)rsp.StatusCode, message = resultContent };
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonParam"></param>
        /// <param name="contentType"></param>
        /// <param name="referer"></param>
        /// <param name="cookie"></param>
        /// <param name="dicHeaders"></param>
        /// <returns></returns>
        public static ResponseMsg DoPost(string url, string jsonParam = null, string contentType = null, string referer = null, string cookie = null, Dictionary<string, string> dicHeaders = null)
        {
            var reponse = new RestResponse();
            var client = new RestClient(url);
            var request = new RestRequest();
            if (!string.IsNullOrEmpty(contentType))
            {
                request.AddHeader("Content-Type", contentType);
            }
            else
            {
                request.AddHeader("Content-Type", ContentType.Json);
            }

            if (!string.IsNullOrEmpty(referer))
            {
                request.AddHeader("Referer", referer);
            }

            if (!string.IsNullOrEmpty(cookie))
            {
                request.AddHeader("Cookie", cookie);
            }

            if (dicHeaders != null)
            {
                foreach (var key in dicHeaders.Keys)
                {
                    request.AddHeader(key, dicHeaders[key]);
                }
            }

            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36");

            request.AddBody(jsonParam);

            var token = LoginInfo.UserToken.IsNullOrEmpty() ? AdminInfo.UserToken : LoginInfo.UserToken;

            request.AddHeader("Authorization", string.Format("Bearer {0}", token));

            reponse = client.ExecutePost(request);

            var responseString = reponse.Content;

            return new ResponseMsg() { statusCode = (int)reponse.StatusCode, message = responseString };
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> parameters)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }

                    postData.Append(name);
                    postData.Append("=");
                    postData.Append(UrlEncode(value, Encoding.UTF8));
                    hasParam = true;
                }
            }

            return postData.ToString();
        }

        /**
        * C#的URL encoding有两个问题：
        * 1.左右括号没有转移（Java的URLEncoder.encode有）
        * 2.转移符合都是小写的，Java是大写的
        */
        public static string UrlEncode(string str, Encoding e)
        {
            var REG_URL_ENCODING = new Regex(@"%[a-f0-9]{2}");

            if (str == null)
            {
                return null;
            }

            String stringToEncode = HttpUtility.UrlEncode(str, e).Replace("+", "%20").Replace("*", "%2A").Replace("(", "%28").Replace(")", "%29");
            return REG_URL_ENCODING.Replace(stringToEncode, m => m.Value.ToUpperInvariant());
        }

        /// <summary>
        /// Json转数组列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="JsonStr"></param>
        /// <returns></returns>
        public static List<T> JsonToList<T>(string JsonStr)
        {
            return JsonConvert.DeserializeObject<List<T>>(JsonStr);
        }

        /// <summary>
        /// Json转实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T JsonToModel<T>(this string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        /// <summary>
        /// 实体转Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ModelToJson<T>(this T input)
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(input, new JsonSerializerSettings
                {
                    Converters = { new IgnoreNullValuesConverter(true) },
                    Formatting = Formatting.Indented // 如果需要格式化输出
                });
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
