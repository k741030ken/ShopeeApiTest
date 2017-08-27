using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region UpdateVariationStockBean
    public class UpdateVariationStockBean
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Stock { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }

        public UInt32? Variation_Id { get; set; }
    }
    #endregion

    #region UpdateVariationStockReturnBean
    public class UpdateVariationStockReturnBean
    {
        public string Error { get; set; }

        public UpdatePriceItem Item { get; set; }
    }
    #endregion

    #region UpdateVariationStockItem
    public class UpdateVariationStockItem
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Modified_Time { get; set; }

        public UInt32 Variation_Id { get; set; }
    }
    #endregion
}
