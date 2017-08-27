using Newtonsoft.Json;
using Shopee.Libray.DataBeans;
using Shopee.Libray.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Execute
{
    public class WebClientExecuteService : BaseExcuteService, IExecuteService
    {
        /// <summary>
        /// Execute use Post
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="addHeaders"></param>
        /// <returns></returns>
        public ReturnModel<T2> Post<T1, T2>(string url, T1 data, IDictionary<string, string> addHeaders = null)
        {
            ReturnModel<T2> result = new ReturnModel<T2>();
            try
            {
                var jsonText = ObjectDeserializeJsonStr(data, Formatting.None, NullValueHandling.Ignore);
                using (var client = new CustWebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    if (addHeaders != null && addHeaders.Count > 0)
                    {
                        foreach (var item in addHeaders)
                        {
                            client.Headers.Add(item.Key, item.Value);
                        }
                    }
                    var response = client.UploadData(url, "POST", Encoding.UTF8.GetBytes(jsonText));
                    var returnContent = Encoding.UTF8.GetString(response);
                    result.Content = JsonStringDeserializeObject<T2>(returnContent);
                    result.IsSuccess = true;
                };
            }
            catch (WebException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMsg = GetExceptionDetailMessage(ex);
            }
            return result;
        }

        /// <summary>
        /// Execute use Get
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="addHeaders"></param>
        /// <returns></returns>
        public ReturnModel<T> Get<T>(string url, IDictionary<string, string> addHeaders = null)
        {
            ReturnModel<T> result = new ReturnModel<T>();
            try
            {
                using (var client = new CustWebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    if (addHeaders != null && addHeaders.Count > 0)
                    {
                        foreach (var item in addHeaders)
                        {
                            client.Headers.Add(item.Key, item.Value);
                        }
                    }
                    var returnContent = client.DownloadString(url);
                    result.Content = JsonStringDeserializeObject<T>(returnContent);
                    result.IsSuccess = true;
                };
            }
            catch(WebException ex)
            {
                throw(ex);
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMsg = GetExceptionDetailMessage(ex);
            }
            return result;
        }
    }
}
