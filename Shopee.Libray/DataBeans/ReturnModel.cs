using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans
{
    public class ReturnModel<TModel>
    {
        /// <summary>
        /// 系統執行是否成功，若不成功，錯誤訊息將顯示於ErrorMsg
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 系統執行發生錯誤時，儲存錯誤訊息
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 回傳的資料
        /// </summary>
        public TModel Content { get; set; }
    }
}
