using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Order;
using Shopee.Libray.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Service.Order
{
    public partial class OrderService : BaseService, IOrderService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        public ReturnModel<EscrowDetailsBean> GetEscrowDetails(GetEscrowDetailsBean reqData)
        {
            var returnModel = new ReturnModel<EscrowDetailsBean>();
            try
            {
                var url = "";
                IDictionary<string, string> addHeaders = new Dictionary<string, string>() { { "", "" } };
                returnModel = ExecuteService().Post<GetEscrowDetailsBean, EscrowDetailsBean>(url, reqData, addHeaders);
            }
            catch (Exception ex)
            {
                returnModel.IsSuccess = false;
                returnModel.ErrorMsg = GetExceptionDetailMessage(ex);
            }
            return returnModel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        public ReturnModel<OrderDetailsBean> GetOrderDetails(GetOrderDetailsBean reqData)
        {
            var returnModel = new ReturnModel<OrderDetailsBean>();
            try
            {
                var url = "";
                IDictionary<string, string> addHeaders = new Dictionary<string, string>() { { "", "" } };
                returnModel = ExecuteService().Post<GetOrderDetailsBean, OrderDetailsBean>(url, reqData, addHeaders);
            }
            catch (Exception ex)
            {
                returnModel.IsSuccess = false;
                returnModel.ErrorMsg = GetExceptionDetailMessage(ex);
            }
            return returnModel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        public ReturnModel<OrdersListBean> GetOrdersList(GetOrdersListBean reqData)
        {
            var returnModel = new ReturnModel<OrdersListBean>();
            try
            {
                var url = "";
                IDictionary<string, string> addHeaders = new Dictionary<string, string>() { { "", "" } };
                returnModel = ExecuteService().Post<GetOrdersListBean, OrdersListBean>(url, reqData, addHeaders);
            }
            catch (Exception ex)
            {
                returnModel.IsSuccess = false;
                returnModel.ErrorMsg = GetExceptionDetailMessage(ex);
            }
            return returnModel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        public ReturnModel<CancelOrderReturnBean> CancelOrder(CancelOrderBean reqData)
        {
            var returnModel = new ReturnModel<CancelOrderReturnBean>();
            try
            {
                var url = "";
                IDictionary<string, string> addHeaders = new Dictionary<string, string>() { { "", "" } };
                returnModel = ExecuteService().Post<CancelOrderBean, CancelOrderReturnBean>(url, reqData, addHeaders);
            }
            catch (Exception ex)
            {
                returnModel.IsSuccess = false;
                returnModel.ErrorMsg = GetExceptionDetailMessage(ex);
            }
            return returnModel;
        }

    }
}
