using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Service.Order
{
    public interface IOrderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        ReturnModel<EscrowDetailsBean> GetEscrowDetails(GetEscrowDetailsBean reqData);

         /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        ReturnModel<OrderDetailsBean> GetOrderDetails(GetOrderDetailsBean reqData);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        ReturnModel<OrdersListBean> GetOrdersList(GetOrdersListBean reqData);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        ReturnModel<CancelOrderReturnBean> CancelOrder(CancelOrderBean reqData);
    }
}
