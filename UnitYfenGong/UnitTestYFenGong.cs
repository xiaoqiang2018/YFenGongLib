using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitYfenGong
{
    [TestClass]
    public class UnitTestYFenGong
    {
        [TestMethod]
        public void TestMethod1()
        {
            YFenGongLibNet.Config.YFenGongConfig.AppId = "";
            YFenGongLibNet.Config.YFenGongConfig.AppSecret = "";
            var Result = 
            YFenGongLibNet.Domain.UserAuthBO.UserAuthIdentityByBackCardNoSync(
                new YFenGongLibNet.Dto.UserAuthIdentityRequestDto()
                {
                    bankCardNo = "",
                    idNumber = "",
                    mobile = "",
                    name = ""
                });
        }
    }



}
