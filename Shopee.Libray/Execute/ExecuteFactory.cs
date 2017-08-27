using Shopee.Libray.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Execute
{
    public class ExecuteFactory
    {
        #region "Local"

        #endregion "Local"

        #region "Constructor"
        /// <summary>
        /// 選擇Execute 的 Service
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IExecuteService CreateExecuteService(ExecuteServiceEnum type)
        {
            switch (type)
            {
                case ExecuteServiceEnum.HttpWebRequest:
                    {

                        return new HttpWebRequestExecuteService(); 
                    }
                case ExecuteServiceEnum.WebClient:
                    {

                        return new WebClientExecuteService();
                    }
                case ExecuteServiceEnum.RestSharp:
                    {

                        return new RestSharpExecuteService();
                    }
                case ExecuteServiceEnum.HttpClient:
                    {

                        return new HttpClientExecuteService();
                    }
                default:
                    {
                        return new HttpWebRequestExecuteService(); 
                    }
            }
        }

        #endregion "Constructor"

        #region "Property"

        #endregion "Property"
    }
}
