using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// spu
    /// </summary>
    public class StandardSpu
    {
        /// <summary>
        /// id
        /// </summary>
        public int spuId { get; set; }

        /// <summary>
        /// pic url
        /// </summary>
        public string picUrls { get; set; }

        public StandardSpuAttrValues[] standardSpuAttrValues { get; set; }
    }
}
