# YFenGongLib
对接易分工系统--支持实名认证，提现，身份证OCR认证。

本项目包含两个测试单元，两个框架源码。支持net core 和 net framework

使用方案：
首先可使用 YFenGongLibNet.Config 注入 appid 和 AppSecret 秘钥层。
接下来就可以使用你具体要使用的业务逻辑了
业务逻辑层支持同步与多路复用的异步方式
操作：
业务层逻辑层可以调用Domain 层的具体调度逻辑，比如：
1.UserAuthBO 实名逻辑
2.UserIdCardOCRAutoBO 身份证 OCR 识别 业务
3.UserWathdrawPayBO 用户提现发放业务 

本项目已在nuget包上线。框架支持net framwork 和 net core
请搜索 YFenGongLibCore 即core版本
搜索 	YFG.Interface.YFenGongLibNet 即 net 版本


