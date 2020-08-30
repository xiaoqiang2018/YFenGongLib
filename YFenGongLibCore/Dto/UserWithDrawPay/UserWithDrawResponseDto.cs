using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibCore.Dto.UserWithDrawPay
{
    public class UserWithDrawResponseDto
    {
        /// <summary>
        /// 提现是否成功
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// 发放单号
        /// </summary>
        public string id { get; set; }
    }
}
