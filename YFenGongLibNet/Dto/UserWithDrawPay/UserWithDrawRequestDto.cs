using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibNet.Dto.UserWithDrawPay
{
    public class UserWithDrawRequestDto
    {
        private decimal _amount { get; set; }

        /// <summary>
        /// String 必填 身份证号。
        /// </summary>
        public string idNumber { get; set; }
        /// <summary>
        /// 必填 银行卡号。
        /// </summary>
        public string bankCardNo { get; set; }
        /// <summary>
        /// 必填 发放金额，不能为负数 支持小数点后两位
        /// </summary>
        public decimal amount 
        { 
            get
            {
                return Math.Round(_amount,2); 
            }
            set
            {
                _amount = value;
            }
        }


    }
}
