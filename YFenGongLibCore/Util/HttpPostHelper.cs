using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace YFenGongLibCore.Util
{
    public class HttpPostHelper
    {
        private static bool RemoteCertificateValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url">请求域</param>
        /// <param name="YFengGongAppId">易分工appid</param>
        /// <param name="YFengGongAppSeret">易分工秘钥</param>
        /// <returns></returns>
        protected static string HttpPost(string Url,string YFengGongAppId,string YFengGongSign,string YFengGongRequestValue, out bool IsSuccess , bool IsSync=true)
        {
            try
            {
                WebClient clicent = new WebClient();
                //https请求
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate;

                clicent.Headers.Add("Content-Type", "application/json");
                clicent.Headers.Set("X-App-Id", YFengGongAppId);
                clicent.Headers.Set("X-App-Sign", YFengGongSign);
                byte[] Result_Byte =
                clicent.UploadData(Url, "Post", Encoding.UTF8.GetBytes(YFengGongRequestValue));
                var data =  Encoding.UTF8.GetString(Result_Byte);
                IsSuccess = true;
                if (IsSync)
                {
                    Debug.DebuglogSync(YFengGongRequestValue);
                    Debug.DebuglogSync(data);
                }
                else
                {
                    Debug.Debuglog(YFengGongRequestValue);
                    Debug.Debuglog(data);
                }

                return data;
            }
            catch (WebException ex)
            {
                using ( HttpWebResponse response = (HttpWebResponse)ex.Response )
                {
                    var Stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(Stream,Encoding.UTF8);
                    var ErrorData =  reader.ReadToEnd();
                    IsSuccess = false;
                    if (IsSync)
                    {
                        Debug.DebuglogSync(YFengGongRequestValue);
                        Debug.DebuglogSync(ErrorData);
                    }
                    else
                    {
                        Debug.Debuglog(YFengGongRequestValue);
                        Debug.Debuglog(ErrorData);
                    }
                    return ErrorData;
                }
            }
        }
    }
}
