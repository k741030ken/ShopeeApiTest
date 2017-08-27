using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopee.Libray.Service.Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Order;
using Newtonsoft.Json;

namespace Shopee.Libray.Service.Order.Tests
{
    [TestClass()]
    public class OrderServiceUnitTests
    {
        [TestMethod()]
        public void GetEscrowDetailsTest()
        {
            try
            {
                var reqData = new GetEscrowDetailsBean();

                var shpeeService = Shopee.Libray.Service.ShopeeFactory.Instance().OrderService;
                ReturnModel<EscrowDetailsBean> data = shpeeService.GetEscrowDetails(reqData);
                if (data.IsSuccess)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(data.Content, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine(data.ErrorMsg);
                }
                Assert.IsTrue(data.IsSuccess, data.ErrorMsg);
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.StackTrace + "\n" + ex.Message);
            }
        }

        [TestMethod()]
        public void GetOrderDetailsTest()
        {
            try
            {
                var reqData = new GetOrderDetailsBean();

                var shpeeService = Shopee.Libray.Service.ShopeeFactory.Instance().OrderService;
                ReturnModel<OrderDetailsBean> data = shpeeService.GetOrderDetails(reqData);
                if (data.IsSuccess)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(data.Content, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine(data.ErrorMsg);
                }
                Assert.IsTrue(data.IsSuccess, data.ErrorMsg);
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.StackTrace + "\n" + ex.Message);
            }
        }

        [TestMethod()]
        public void GetOrdersListTest()
        {
            try
            {
                var reqData = new GetOrdersListBean();

                var shpeeService = Shopee.Libray.Service.ShopeeFactory.Instance().OrderService;
                ReturnModel<OrdersListBean> data = shpeeService.GetOrdersList(reqData);
                if (data.IsSuccess)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(data.Content, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine(data.ErrorMsg);
                }
                Assert.IsTrue(data.IsSuccess, data.ErrorMsg);
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.StackTrace + "\n" + ex.Message);
            }
        }

        [TestMethod()]
        public void CancelOrderTest()
        {
            try
            {
                var reqData = new CancelOrderBean();

                var shpeeService = Shopee.Libray.Service.ShopeeFactory.Instance().OrderService;
                ReturnModel<CancelOrderReturnBean> data = shpeeService.CancelOrder(reqData);
                if (data.IsSuccess)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(data.Content, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine(data.ErrorMsg);
                }
                Assert.IsTrue(data.IsSuccess, data.ErrorMsg);
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.StackTrace + "\n" + ex.Message);
            }
        }
    }
}
