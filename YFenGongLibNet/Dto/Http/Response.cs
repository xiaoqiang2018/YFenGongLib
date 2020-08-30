using System;
using System.Collections.Generic;
using System.Text;

namespace YFenGongLibNet.Dto.Http
{
    public class Response<ResponseEntity>: ResponseStatus
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        public ResponseEntity Result { get; set; }
        /// <summary>
        /// 错误消息返回头部
        /// </summary>
        public ErrorResponseDto Message { get; set; }
    }

    public class EntitySync<T> where T:class
    {

    }

    public class ResponseStatus
    {
        public bool IsSuccess { get; set; }
    }

    


}
