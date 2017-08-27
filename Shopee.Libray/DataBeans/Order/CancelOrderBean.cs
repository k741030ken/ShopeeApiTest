using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Order
{
    #region CancelOrderBean
    public class CancelOrderBean
    {
        public UInt32 Ordersn { get; set; }

        public string Cancel_Reason { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }

        public UInt32? Item_Id { get; set; }

        public UInt32? Variation_Id { get; set; }
    } 
    #endregion

    #region CancelOrderReturnBean
    public class CancelOrderReturnBean
    {
        public string Error { get; set; }

        public UInt32 Modified_Time { get; set; }
    } 
    #endregion
}
