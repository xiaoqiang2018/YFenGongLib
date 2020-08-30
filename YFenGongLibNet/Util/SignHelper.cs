using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YFenGongLibNet.Dto.Sign;
using Newtonsoft.Json;
namespace YFenGongLibNet.Util
{
    /// <summary>
    /// 签名方法 --author zbq
    /// </summary>
    public static class SignHelper
    {
        /// <summary>
        /// 待加密队列字典
        /// </summary>
        public static SortedDictionary<string, object> WaitEncryptionQueue { get; set; }
        /// <summary>
        /// 传入的json参数字符
        /// </summary>
        public static dynamic RequestValueJson { get; set; }
        /// <summary>
        /// 签名成功参数
        /// </summary>
        public static dynamic SignRequestValue { get; set; }

        public static string AppSecret { get; set; }

        public static string BulidSignResult()
        {
            //1.排列
            //2.ASCII 码进行升序
            //3.sha256
            //4.Base64
            WaitEncryptionQueue = JsonConvert.DeserializeObject<SortedDictionary<string,object>>(RequestValueJson);
            WaitEncryptionQueue.OrderBy(s=>s.Key);
            string TrimSourtedJson = "";
            foreach (var VALUE in WaitEncryptionQueue)
            {
                TrimSourtedJson += VALUE.Key+"="+VALUE.Value+"&";
            }
            TrimSourtedJson = TrimSourtedJson.Remove(TrimSourtedJson.Length-1,1);
            SignRequestValue = ToBase64hmac(TrimSourtedJson, AppSecret);
            return SignRequestValue;
        }

        public static string ToBase64hmac(string strText, string strKey)
        {
            HMACSHA256 myHMACSHA256 = new HMACSHA256(Encoding.UTF8.GetBytes(strKey));

            byte[] byteText = myHMACSHA256.ComputeHash(Encoding.UTF8.GetBytes(strText));

            return System.Convert.ToBase64String(byteText);

        }


    }
}
