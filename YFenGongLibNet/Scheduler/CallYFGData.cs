using YFenGongLibNet.Util;
using YFenGongLibNet.Config;
using System;
using System.ComponentModel;
using System.Net.Cache;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YFenGongLibNet.Dto.Http;
//调度层
namespace YFenGongLibNet.Scheduler
{
    /// <summary>
    /// 易分工接口调度层 author--zbq
    /// </summary>
    public class CallYFGData : HttpPostHelper
    {
        /// <summary>
        /// 易分工请求 异步
        /// </summary>
        /// <returns></returns>
        public static async Task<Response<ResponseEntity>> Request<ResponseEntity>(dynamic RequestValue, string YFenGongUrl) where ResponseEntity : class
        {
            return await Task.Run(() =>
          {
              //加密
              SignHelper.RequestValueJson = JsonConvert.SerializeObject(RequestValue);
              SignHelper.AppSecret = YFenGongConfig.AppSecret;
              SignHelper.BulidSignResult();
              //请求
              bool IsSuccess = false;
              object DataResult =
              HttpPostHelper.HttpPost(YFenGongUrl, YFenGongConfig.AppId, SignHelper.SignRequestValue, SignHelper.RequestValueJson, out IsSuccess, false);
              //预转化
              return ResponseConversion.Conversion<ResponseEntity>(DataResult, IsSuccess);
          });
        }

        /// <summary>
        /// 易分工请求 同步
        /// </summary>
        /// <typeparam name="ResponseEntity"></typeparam>
        /// <param name="RequestValue"></param>
        /// <param name="YFenGongUrl"></param>
        /// <returns></returns>
        public static Response<ResponseEntity> RequestSync<ResponseEntity>(dynamic RequestValue, string YFenGongUrl) where ResponseEntity : class
        {
            //加密
            SignHelper.RequestValueJson = JsonConvert.SerializeObject(RequestValue);
            SignHelper.AppSecret = YFenGongConfig.AppSecret;
            SignHelper.BulidSignResult();
            //请求
            bool IsSuccess = false;
            object DataResult =
            HttpPostHelper.HttpPost(YFenGongUrl, YFenGongConfig.AppId, SignHelper.SignRequestValue, SignHelper.RequestValueJson, out IsSuccess, true);
            //预转化
            return ResponseConversion.Conversion<ResponseEntity>(DataResult, IsSuccess);
        }
    }
}
