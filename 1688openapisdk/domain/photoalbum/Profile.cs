using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.photoalbum
{
    public class Profile
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// 已使用空间，单位为字节
        /// </summary>
        public long usedSpace { get; set; }

        /// <summary>
        /// 总空间，单位为字节
        /// </summary>
        public long totalSpace { get; set; }

        /// <summary>
        /// 空间是否已满，Y：已满 N：未满
        /// </summary>
        public string isFull { get; set; }

        /// <summary>
        /// 已使用空间占总空间百分比，精确到小数点后两位。如占用30.31%，返回值为30.31
        /// </summary>
        public double spaceUsage { get; set; }
    }
}
