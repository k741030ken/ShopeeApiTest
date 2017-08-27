using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Item;
using Shopee.Libray.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Service.Item
{
    public partial class ItemService : BaseService , IItemService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        public ReturnModel<AddReturnBean> Add(AddBean reqData)
        {
            var returnModel = new ReturnModel<AddReturnBean>();
            try
            {
                var url = "";
                IDictionary<string, string> addHeaders = new Dictionary<string, string>() { { "", "" } };
                returnModel = ExecuteService().Post<AddBean, AddReturnBean>(url, reqData, addHeaders);
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
        public ReturnModel<CategoriesBean> GetCategories(GetCategoriesBean reqData)
        {
            var returnModel = new ReturnModel<CategoriesBean>();
            try
            {
                var url = "";
                IDictionary<string, string> addHeaders = new Dictionary<string, string>() { { "", "" } };
                returnModel = ExecuteService().Post<GetCategoriesBean, CategoriesBean>(url, reqData, addHeaders);
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
