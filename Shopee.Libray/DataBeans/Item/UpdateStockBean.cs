using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region UpdateStockBean
    public class UpdateStockBean
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Stock { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    }
    #endregion

    #region UpdateStockReturnBean
    public class UpdateStockReturnBean
    {
        public string Error { get; set; }

        public UpdatePriceItem Item { get; set; }
    }
    #endregion

    #region UpdateStockItem
    public class UpdateStockItem
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Modified_Time { get; set; }
    }
    #endregion
}
