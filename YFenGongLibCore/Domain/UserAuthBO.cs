using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YFenGongLibCore.Scheduler;
using YFenGongLibCore.Config;
using YFenGongLibCore.Dto;
using YFenGongLibCore.Dto.UserAuth;
using YFenGongLibCore.Dto.Http;
namespace YFenGongLibCore.Domain
{
    /// <summary>
    /// 实名注册 银行四要素认证 业务
    /// </summary>
    public class UserAuthBO
    {
        /// <summary>
        /// 通过银行卡四要素完成用户实名注册 [异步]  [可另外用于银行卡的校验{校验不准确,第一次实名能校验,后期无法校验，都是返回成功}]
        /// </summary>
        public static async Task<Response<UserAuthIdentityResponseDto>> UserAuthIdentityByBackCardNo(UserAuthIdentityRequestDto request)
        {
            return await Task.Run(() =>
             {
                 return
                   CallYFGData.Request<UserAuthIdentityResponseDto>(request, YFenGongConfig.YFenGongUserAuthUrl).Result;
             });
        }

        /// <summary>
        /// 通过银行卡四要素完成用户实名注册 [同步]
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Response<UserAuthIdentityResponseDto> UserAuthIdentityByBackCardNoSync(UserAuthIdentityRequestDto request)
        {
            return
                CallYFGData.RequestSync<UserAuthIdentityResponseDto>(request, YFenGongConfig.YFenGongUserAuthUrl);

        }
    }
}
