using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class OrderEntry
    {

        /// <summary>
        /// 商品信息数组-商品ID(订单中买家购买的商品信息，包括商品ID，图片URL、名称、单价、购买数量，下同)
        /// </summary>
        public long sourceId { get; set; }

        /// <summary>
        /// 商品信息数组-商品所有图片的URL地址
        /// </summary>
        public string[] productPic { get; set; }

        /// <summary>
        /// 商品信息数组-商品名称
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        /// 商品信息数组-商品单价，单位：分
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 商品信息数组-订单中该商品的购买数量
        /// </summary>
        public string quantity { get; set; }

        /// <summary>
        /// 子订单状态
        /// </summary>
        public string entryStatus { get; set; }

        /// <summary>
        /// 担保交易共有5个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕); 即时到账交易共有4个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货),(交易成功), cancel(交易取消，违约金等交割完毕) 分阶段交易包括：waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕),waitselleract(等待卖家操作),waitbuyerconfirmaction(等待买家确认操作),waitsellerpush(等待卖家推进)
        /// </summary>
        public int entryCodStatus { get; set; }

        /// <summary>
        /// 产品图片/快照图片
        /// </summary>
        public string offerSnapshotImageUrl { get; set; }

        /// <summary>
        /// 物流单id
        /// </summary>
        public long logisticsOrderId { get; set; }

    }
}
