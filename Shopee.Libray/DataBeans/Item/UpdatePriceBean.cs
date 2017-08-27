using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region UpdatePriceBean
    public class UpdatePriceBean
    {
        public UInt32 Item_Id { get; set; }

        public double Price { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region UpdatePriceReturnBean
    public class UpdatePriceReturnBean
    {
        public string Error { get; set; }

        public UpdatePriceItem Item { get; set; }
    }
    #endregion

    #region UpdatePriceItem
    public class UpdatePriceItem
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Modified_Time { get; set; }
    } 
    #endregion
}
