using Newtonsoft.Json;
using RestSharp;
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
    public class RestSharpExecuteService : BaseExcuteService, IExecuteService
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
                var client = new RestClient(url);
                client.Timeout = Properties.Settings.Default.ApiTimeOutSet * 1000;
                var request = new RestRequest("", Method.POST);
                request.AddHeader("Content-type", "application/json");
                if (addHeaders != null && addHeaders.Count > 0)
                {
                    foreach (var item in addHeaders)
                    {
                        request.AddHeader(item.Key, item.Value);
                    }
                }
                request.Parameters.Clear();
                request.AddParameter("application/json", jsonText, ParameterType.RequestBody);
                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var returnContent = response.Content;
                    result.Content = JsonStringDeserializeObject<T2>(returnContent);
                    result.IsSuccess = true;
                }
                else
                {
                    result.IsSuccess = false;
                    result.ErrorMsg = response.ErrorMessage;
                }
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
                var client = new RestClient(url);
                client.Timeout = Properties.Settings.Default.ApiTimeOutSet * 1000;
                var request = new RestRequest("", Method.GET);
                request.AddHeader("Content-type", "application/json");
                if (addHeaders != null && addHeaders.Count > 0)
                {
                    foreach (var item in addHeaders)
                    {
                        request.AddHeader(item.Key, item.Value);
                    }
                }
                request.Parameters.Clear();
                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var returnContent = response.Content;
                    result.Content = JsonStringDeserializeObject<T>(returnContent);
                    result.IsSuccess = true;
                }
                else
                {
                    result.IsSuccess = false;
                    result.ErrorMsg = response.ErrorMessage;
                }
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
