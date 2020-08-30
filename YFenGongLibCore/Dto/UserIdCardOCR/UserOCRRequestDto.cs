using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibCore.Dto.UserIdCardOCR
{
    public class UserOCRRequestDto
    {
        /// <summary> 
        /// 人员的 id。
        /// </summary>
        public string employeeId { get; set; }
        /// <summary>
        /// 身份证人像面的图片链接。
        /// </summary>
        public string idCardFace { get; set; }

        /// <summary>
        /// 身份证国徽面的图片链接。
        /// </summary>
        public string idCardBack { get; set; }

    }
}
