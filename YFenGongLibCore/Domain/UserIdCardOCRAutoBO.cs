using YFenGongLibCore.Config;
using YFenGongLibCore.Dto.Http;
using YFenGongLibCore.Dto.UserIdCardOCR;
using YFenGongLibCore.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibCore.Domain
{
    /// <summary>
    /// 身份证 OCR 识别 业务
    /// </summary>
    public class UserIdCardOCRAutoBO
    {
        /// <summary>
        /// 身份证 OCR 识别（签署）[异步]
        /// </summary>
        public static async  Task<Response<UserOCRResponseDto>> UserAuthIdentityByBackCardNo(UserOCRRequestDto request)
        {
            return await Task.Run(() =>
            {
                Response<UserOCRResponseDto> response =
                  CallYFGData.Request<UserOCRResponseDto>
                  (request, YFenGongConfig.UserIdCardOCRAutoUrl.Replace("{employeeId}", request.employeeId)).Result;
                if (response.IsSuccess)
                {
                    return response;
                }
                else
                {
                    return response;
                }
            });
        }

        /// <summary>
        /// 身份证 OCR 识别（签署） [同步]
        /// </summary>
        public static Response<UserOCRResponseDto> UserAuthIdentityByBackCardNoSync(UserOCRRequestDto request)
        {
            return
              CallYFGData.RequestSync<UserOCRResponseDto>
              (request, YFenGongConfig.UserIdCardOCRAutoUrl.Replace("{employeeId}", request.employeeId));
        }
    }
}
