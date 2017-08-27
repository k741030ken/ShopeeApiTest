using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopee.Libray.Service.Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopee.Libray.DataBeans.Item;
using Shopee.Libray.DataBeans;
using Newtonsoft.Json;

namespace Shopee.Libray.Service.Item.Tests
{
    [TestClass()]
    public class ItemServiceUnitTests
    {
        [TestMethod()]
        public void AddTest()
        {
            try
            {
                var reqData = new AddBean();

                var shpeeService = Shopee.Libray.Service.ShopeeFactory.Instance().ItemService;
                ReturnModel<AddReturnBean> data = shpeeService.Add(reqData);
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
        public void GetCategoriesTest()
        {
            try
            {
                var reqData = new GetCategoriesBean();

                var shpeeService = Shopee.Libray.Service.ShopeeFactory.Instance().ItemService;
                ReturnModel<CategoriesBean> data = shpeeService.GetCategories(reqData);
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
