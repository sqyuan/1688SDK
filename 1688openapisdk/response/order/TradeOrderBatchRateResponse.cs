using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.response.order
{
    public class TradeOrderBatchRateResponse:AliResponse
    {
        /// <summary>
        /// 提交评价失败的订单Map(Long,String),前者为失败的订单号，后者为失败的错误码： 1 返回为空时，创建全部成功 2 没指定订单号及评价内容时,接口直接返回成功结果 3 当订单已经评价过时，接口直接返回成功结果，不做任何处理 4 当指定的订单不是指定postMemberId用户的订单是，接口直接返回成功结果，不做任何处理 5 当指定的订单不处于待评价状态时，接口直接返回成功结果，不做任何处理
        /// { “92154312490525” :"INVOKE_DUBBO_ERROR" //评价失败的订单号 以及失败的错误码 }
        /// NULL_PARAM	指定的参数为空	
        ///INVALID_PARAM	指定的参数有误	
        ///INVOKE_DUBBO_ERROR	接口内部服务调用错误,请联系服务接口人	
        ///UPDATE_DATABASE_FAILED	提交评价失败,数据库异常
        /// </summary>
        public Dictionary<String, String> failedOrder { get; set; }
    }
}
