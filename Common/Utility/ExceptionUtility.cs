using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utility
{
    public class ExceptionUtility
    {
        /// <summary>
        /// 取得這個Exception詳細的訊息
        /// </summary>
        /// <param name="exceptionObject"></param>
        /// <returns></returns>
        public string GetExceptionDetailMessage(Exception exceptionObject)
        {
            StringBuilder sbMessage = new StringBuilder();

            if (exceptionObject != null)
            {
                // 1. 正常訊息
                sbMessage.Append("Error Message：");
                sbMessage.Append(exceptionObject.Message);
                sbMessage.Append(Environment.NewLine);

                // 2. 如果有內部的訊息
                if (exceptionObject.InnerException != null)
                {
                    sbMessage.Append("Inner Error Message：");
                    sbMessage.Append(exceptionObject.InnerException.Message);
                    sbMessage.Append(Environment.NewLine);
                }

                // 3. StackTrace
                sbMessage.Append(exceptionObject.StackTrace);

                // 4. 結束換行
                sbMessage.Append(Environment.NewLine);
            }

            return sbMessage.ToString();
        }
    }
}
