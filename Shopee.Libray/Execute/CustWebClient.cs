using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Execute
{
    /// <summary>
    /// 設定Timeout
    /// </summary>
    public class CustWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = Properties.Settings.Default.ApiTimeOutSet * 1000;
            return w;
        }
    }
}
