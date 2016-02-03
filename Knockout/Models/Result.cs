using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knockout.Models
{
    /// <summary>
    /// 通用结果
    /// </summary>
    public class Result<T>// where T:class
    {
        public Result()
        {
            Data=default(T);
        }

        /// <summary>
        /// 结果
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 需要服务端返回的结果
        /// </summary>
        public T Data { get; set; }
    }
}