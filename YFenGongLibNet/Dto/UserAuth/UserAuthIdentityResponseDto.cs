using YFenGongLibNet.Dto.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFenGongLibNet.Dto.UserAuth
{
    /// <summary>
    /// 用户注册 四要素认证响应结果集
    /// </summary>
    public class UserAuthIdentityResponseDto: ResponseStatus
    {
        /// <summary>
        /// 人员的 id，唯一且不变的值 易分工提现用户唯一标识
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool verified { get; set; }
        /// <summary>
        ///  必返回 是否签署了电子合同，或线下签约。
        /// </summary>
        public bool signed { get; set; }
        /// <summary>
        /// 必返回 创建日期，格式为 yyyy-MM-dd。
        /// </summary>
        public string gmtCreate { get; set; }

        public employer employer { get; set; }
        public employee employee { get; set; }


    }
    /// <summary>
    /// 注册者人员信息
    /// </summary>
    public class employer
    {
        /// <summary>
        /// 注册id
        /// </summary>
        public string companyId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string companyName { get; set; }
        public int zone { get; set; }
    }
    /// <summary>
    /// 注册公司主体
    /// </summary>
    public class employee
    {
        /// <summary>
        /// 主体名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 主体标识
        /// </summary>
        public string idNumber { get; set; }
        /// <summary>
        /// 主体电话
        /// </summary>
        public string mobile { get; set; }
    }

}
