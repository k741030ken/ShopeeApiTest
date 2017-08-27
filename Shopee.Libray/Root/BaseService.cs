
using Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Shopee.Libray.Common.Enum;
using Shopee.Libray.Execute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Root
{
    public class BaseService
    {
        /// <summary>
        /// 物件轉字串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        protected string IIF<T>(T data)
        {
            return UtilityFactory.Instance().StringUtility.IIF(data);
        }

        /// <summary>
        /// JsonStringDeserializeObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="st"></param>
        /// <returns></returns>
        protected T JsonStringDeserializeObject<T>(string st)
        {
            return UtilityFactory.Instance().SerializeUtility.JsonStringDeserializeObject<T>(st);
        }

        /// <summary>
        /// ObjectDeserializeJsonStr
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="formatting"></param>
        /// <param name="nullValueHandling"></param>
        /// <returns></returns>
        protected string ObjectDeserializeJsonStr<T>(T data, Formatting formatting = Formatting.None, NullValueHandling nullValueHandling = NullValueHandling.Include)
        {
            return JsonConvert.SerializeObject(data, formatting,
                new JsonSerializerSettings
                {
                    NullValueHandling = nullValueHandling,
                    //ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
        }

        /// <summary>
        /// CreateExecuteService
        /// </summary>
        /// <returns></returns>
        protected IExecuteService ExecuteService()
        {
            return ExecuteFactory.CreateExecuteService(ExecuteServiceEnum.RestSharp);
        }

        /// <summary>
        /// 取得這個Exception詳細的訊息
        /// </summary>
        /// <param name="exceptionObject"></param>
        /// <returns></returns>
        protected string GetExceptionDetailMessage(Exception exceptionObject)
        {
            return UtilityFactory.Instance().ExceptionUtility.GetExceptionDetailMessage(exceptionObject);
        }
    }
}
