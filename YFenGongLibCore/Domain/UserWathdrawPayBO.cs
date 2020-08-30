using YFenGongLibCore.Config;
using YFenGongLibCore.Dto.Http;
using YFenGongLibCore.Dto.UserWithDrawPay;
using YFenGongLibCore.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibCore.Domain
{
    /// <summary>
    /// 用户提现发放业务
    /// </summary>
    public class UserWathdrawPayBO
    {
        /// <summary>
        /// 发放给个人（提现） [异步]
        /// 该接口用于发放一定金额给已签约的个人
        /// 此外，有极小的概率（例如超出了当月限额，或者银行卡被冻结等极端情况），该笔发放会失败。由
        /// 于是异步的结果，如果需要进一步确认，可以查询发放明细。
        /// </summary>
        public static async Task<Response<UserWithDrawResponseDto>> UserAuthIdentityByBackCardNo(UserWithDrawRequestDto request)
        {
            return await
            Task.Run(() =>
            {
                Response<UserWithDrawResponseDto> response =
                  CallYFGData.Request<UserWithDrawResponseDto>(request, YFenGongConfig.UserWathdrawPayUrl).Result;
                if (response.IsSuccess)
                {
                    return response;
                }
                else
                {
                    return response;
                }
            });
            //task.Wait();
            //return task;
        }

        /// <summary>
        /// 提现请求 [同步]
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static  Response<UserWithDrawResponseDto> UserAuthIdentityByBackCardNoSync(UserWithDrawRequestDto request)
        {
            return CallYFGData.RequestSync<UserWithDrawResponseDto>(request, YFenGongConfig.UserWathdrawPayUrl);
        }

    }
}
