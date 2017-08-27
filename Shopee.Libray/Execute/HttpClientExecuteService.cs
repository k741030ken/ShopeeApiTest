using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Shopee.Libray.DataBeans;
using Shopee.Libray.Root;
using System.Web.Http;

namespace Shopee.Libray.Execute
{
    public class HttpClientExecuteService : BaseExcuteService, IExecuteService
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
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(Properties.Settings.Default.ApiTimeOutSet); //抓Settings裡設定的秒數
                    var jsonText = ObjectDeserializeJsonStr(data, Formatting.None, NullValueHandling.Ignore);
                    var content = new StringContent(jsonText, Encoding.UTF8, "application/json");
                    //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    if (addHeaders != null && addHeaders.Count > 0)
                    {
                        foreach (var item in addHeaders)
                        {
                            client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                    }
                    Task<HttpResponseMessage> response = client.PostAsync(url, content);
                    using (HttpResponseMessage message = response.Result)
                    {
                        if (message.IsSuccessStatusCode)
                        {
                            var responseContent = message.Content;
                            string returnContent = responseContent.ReadAsStringAsync().Result;
                            result.Content = JsonStringDeserializeObject<T2>(returnContent);
                            result.IsSuccess = true;
                        }
                        else
                        {
                            throw new HttpResponseException(message.StatusCode);
                        }
                    }
                }
            }
            catch (HttpResponseException ex)
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
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(Properties.Settings.Default.ApiTimeOutSet); //抓Settings裡設定的秒數
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    if (addHeaders != null && addHeaders.Count > 0)
                    {
                        foreach (var item in addHeaders)
                        {
                            client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                    }
                    Task<HttpResponseMessage> response = client.GetAsync(url);
                    using (HttpResponseMessage message = response.Result)
                    {
                        if (message.IsSuccessStatusCode)
                        {
                            var responseContent = message.Content;
                            string returnContent = responseContent.ReadAsStringAsync().Result;
                            result.Content = JsonStringDeserializeObject<T>(returnContent);
                            result.IsSuccess = true;
                        }
                        else
                        {
                            throw new HttpResponseException(message.StatusCode);
                        }
                    }
                }
            }
            catch (HttpResponseException ex)
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
        
    }
}
