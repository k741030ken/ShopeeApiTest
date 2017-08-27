using Shopee.Libray.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Template.Request;
using Shopee.Libray.DataBeans.Template.Response;

namespace Shopee.Libray.Service.Template
{
    public partial class TemplateService : BaseService, ITemplateService
    {
        /// <summary>
        /// (測試)取得動態指定[縣市]的公共自行車即時車位資料
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public ReturnModel<List<BikeAvailabilityRespBean>> GetBikeAvailabilityData(UserReqBean user)
        {
            var returnModel = new ReturnModel<List<BikeAvailabilityRespBean>>();
            try
            {
                var jsonStr1 = ObjectDeserializeJsonStr(user); //無\r\n，有包含null欄位
                var jsonStr2 = ObjectDeserializeJsonStr(user, Newtonsoft.Json.Formatting.Indented); //有\r\n，有包含null欄位
                var jsonStr3 = ObjectDeserializeJsonStr(user, Newtonsoft.Json.Formatting.None, Newtonsoft.Json.NullValueHandling.Ignore); //無\r\n，無包含null欄位
                var jsonStr4 = ObjectDeserializeJsonStr(user, Newtonsoft.Json.Formatting.Indented, Newtonsoft.Json.NullValueHandling.Ignore); //有\r\n，無包含null欄位
                var url = Properties.Settings.Default.TemplatePath + Properties.Settings.Default.TemplateApiAction + "?$top=10&$format=JSON";
                IDictionary<string, string> addHeaders = new Dictionary<string, string>(){{"Key","Value"}};
                returnModel = ExecuteService().Get<List<BikeAvailabilityRespBean>>(url, addHeaders);               
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
