using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knockout.Models
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int Quantity { get; set; }
    }
}