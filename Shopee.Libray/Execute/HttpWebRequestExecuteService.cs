using Newtonsoft.Json;
using Shopee.Libray.DataBeans;
using Shopee.Libray.Root;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Shopee.Libray.Execute
{
    public class HttpWebRequestExecuteService : BaseExcuteService, IExecuteService
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
                var jsonBytes = Encoding.UTF8.GetBytes(jsonText);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Post;
                request.ContentType = "application/json";
                request.ContentLength = jsonBytes.Length;
                if (addHeaders != null && addHeaders.Count > 0)
                {
                    foreach (var item in addHeaders)
                    {
                        request.Headers.Add(item.Key, item.Value);
                    }
                }
                request.Timeout = Properties.Settings.Default.ApiTimeOutSet * 1000;
                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(jsonBytes, 0, jsonBytes.Length);
                    requestStream.Flush();
                }
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (var stream = response.GetResponseStream())
                        using (var reader = new StreamReader(stream))
                        {
                            var returnContent = reader.ReadToEnd();
                            result.Content = JsonStringDeserializeObject<T2>(returnContent);
                            result.IsSuccess = true;
                        }
                    }
                    else
                    {
                        throw new HttpResponseException(response.StatusCode);
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

        // <summary>
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
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Get;
                request.ContentType = "application/json";
                if (addHeaders != null && addHeaders.Count > 0)
                {
                    foreach (var item in addHeaders)
                    {
                        request.Headers.Add(item.Key, item.Value);
                    }
                }
                request.Timeout = Properties.Settings.Default.ApiTimeOutSet * 1000;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (var stream = response.GetResponseStream())
                        using (var reader = new StreamReader(stream))
                        {
                            var returnContent = reader.ReadToEnd();
                            result.Content = JsonStringDeserializeObject<T>(returnContent);
                            result.IsSuccess = true;
                        }
                    }
                    else
                    {
                        throw new HttpResponseException(response.StatusCode);
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
