using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YFenGongLibCore.Dto.Http;
namespace YFenGongLibCore.Util
{
    /// <summary>
    /// 中间响应集合转化层
    /// </summary>
    public class ResponseConversion
    {
        public static Response<ResponseEntity> Conversion<ResponseEntity>(object DataResult,bool IsSuccess)
        {
            Response<ResponseEntity> response = new Response<ResponseEntity>();
            response.IsSuccess = IsSuccess;
            if (IsSuccess)
            {
                response.Result = JsonConvert.DeserializeObject<ResponseEntity>(DataResult.ToString());
            }
            else
            {
                response.Message = JsonConvert.DeserializeObject<ErrorResponseDto>(DataResult.ToString());
            }
            return response;
        }
    }
}