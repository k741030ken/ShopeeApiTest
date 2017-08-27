using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopee.Libray.Service.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Template.Request;
using Newtonsoft.Json;

namespace Shopee.Libray.Service.Template.Tests
{
    [TestClass()]
    public class TemplateServiceUnitTest
    {
        [TestMethod()]
        public void GetBikeAvailabilityDataTest()
        {
            try
            {
                var user = new UserReqBean();
                user.UserID = "334888";
                var citys = new List<CityReqBean>(){
                new CityReqBean(){
                    name = "Tai"
                },
                new CityReqBean(){
                    name = "Keel",
                    Bikes = new List<BikeReqBean>(){
                        new BikeReqBean(){
                            name = "Ken"
                        },
                        new BikeReqBean(){
                            name = "Ken",
                            Top = 2
                        }
                    }
                },
            };
                user.Citys = citys;
                var templateService = Shopee.Libray.Service.ShopeeFactory.Instance().templateService;
                var data = templateService.GetBikeAvailabilityData(user);
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
