
using Shopee.Libray.DataBeans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Execute
{
    public interface IExecuteService
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
        ReturnModel<T2> Post<T1, T2>(string url, T1 data, IDictionary<string, string> addHeaders = null);

        /// <summary>
        /// Execute use Get
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="addHeaders"></param>
        /// <returns></returns>
        ReturnModel<T> Get<T>(string url, IDictionary<string, string> addHeaders = null);
    }
}
