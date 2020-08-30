using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibCore.Dto
{
    /// <summary>
    /// 用户注册账号 银行四要素认证
    /// </summary>
    public class UserAuthIdentityRequestDto
    {
        /// <summary>
        /// 必填 姓名。
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 必填 身份证号。
        /// </summary>
        public string idNumber { get; set; }
        /// <summary>
        /// 必填 银行卡号。
        /// </summary>
        public string bankCardNo { get; set; }
        /// <summary>
        /// 必填 银行预留的手机号。
        /// </summary>
        public string mobile { get; set; }

    }
}
