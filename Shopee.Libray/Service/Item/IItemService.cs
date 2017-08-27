using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Service.Item
{
    public interface IItemService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        ReturnModel<AddReturnBean> Add(AddBean reqData);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        ReturnModel<CategoriesBean> GetCategories(GetCategoriesBean reqData);
    }       
}
