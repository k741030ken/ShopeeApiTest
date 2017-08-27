using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utility
{
    public class ReflectionUtility
    {
        /// <summary>
        /// 設定物件的屬性
        /// </summary>
        /// <param name="page"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetProperty(object page, string name, Object value)
        {
            PropertyInfo property = page.GetType().GetProperties().Where(p => p.Name == name).FirstOrDefault();

            if (null != property)
            {
                property.SetValue(page, value, null);
            }
        }

        /// <summary>
        /// 取得物件屬性
        /// </summary>
        /// <param name="page"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public object GetProperty(object page, string name)
        {
            PropertyInfo property = page.GetType().GetProperties().Where(p => p.Name == name).FirstOrDefault();

            if (null != property)
            {
                return property.GetValue(page, null);
            }

            return null;
        }

        /// <summary>
        /// 取得屬性
        /// </summary>
        /// <param name="page"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public PropertyInfo GetPropertyInfo(object page, string name)
        {
            return page.GetType().GetProperties().Where(p => p.Name == name).FirstOrDefault();
        }

        /// <summary>
        /// 執行物件中的方法
        /// </summary>
        /// <param name="executeObject">物件</param>
        /// <param name="methodName">方法名稱</param>
        /// <param name="parameters">參數</param>
        public object ExecuteMethod(object executeObject, string methodName, object[] parameters)
        {
            if (!string.IsNullOrEmpty(methodName) && executeObject != null)
            {
                MethodInfo enterFunction = executeObject.GetType().GetMethod(methodName);
                if (null != enterFunction)
                {
                    return enterFunction.Invoke(executeObject, parameters);
                }
            }

            return null;
        }
    }
}
