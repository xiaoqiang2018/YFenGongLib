using NUnit.Framework;

namespace NUnitTestYFenGongCore
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {

            YFenGongLibCore.Config.YFenGongConfig.AppId = "";
            YFenGongLibCore.Config.YFenGongConfig.AppSecret = "";
            var result = 
            YFenGongLibCore.Domain.UserAuthBO.UserAuthIdentityByBackCardNoSync(                
                new YFenGongLibCore.Dto.UserAuthIdentityRequestDto()
                {
                     bankCardNo = "",
                      idNumber = "",
                       mobile = ""
                }
                );


            //Assert.Pass();
        }
    }
}