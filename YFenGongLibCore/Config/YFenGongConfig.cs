using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibCore.Config
{
    public class YFenGongConfig
    {
        /// <summary>
        /// AppId为接口账号，申请之后无法修改
        /// </summary>
        public static string AppId { get; set; } = "";
        /// <summary>
        /// AppSecret 是接口密钥
        /// </summary>
        public static string AppSecret { get; set; } = "";
        /// <summary>
        /// 易分工请求域
        /// </summary>
        public static string YFenGongUrl { get; set; } = "https://api.fengong8.com/";
        /// <summary>
        /// 实名认证接口
        /// </summary>
        public static string YFenGongUserAuthUrl { get; set; } = YFenGongUrl + "f/employees";


        /// <summary>
        /// 身份证 OCR 识别 接口
        /// </summary>
        public static string UserIdCardOCRAutoUrl { get; set; } = YFenGongUrl + "f/employees/{employeeId}/verify-v2";
        /// <summary>
        /// 发放给个人（提现）  接口
        /// </summary>
        public static string UserWathdrawPayUrl { get; set; } = YFenGongUrl + "f/pays";



    }
}
