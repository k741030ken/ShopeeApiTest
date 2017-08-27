using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region GetItemDetailBean
    public class GetItemDetailBean
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region ItemDetailBean
    public class ItemDetailBean
    {
        public string Error { get; set; }

        public ItemDetailItem item { get; set; }
    }
    #endregion

    #region ItemDetailItem
    public class ItemDetailItem
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public string Item_Sku { get; set; }

        public string Status { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Images { get; set; }

        public string Currency { get; set; }

        public bool Has_Variation { get; set; }

        public double Price { get; set; }

        public UInt32 Stock { get; set; }

        public UInt32 Create_Time { get; set; }

        public UInt32 Update_Time { get; set; }

        public double Weight { get; set; }

        public UInt32 Category_Id { get; set; }

        public List<ItemDetailVariation> Variations { get; set; }
    }
    #endregion

    #region ItemDetailVariation
    public class ItemDetailVariation
    {
        public UInt32 Variation_Id { get; set; }

        public string Variation_Sku { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public UInt32 Stock { get; set; }

        public string Status { get; set; }

        public UInt32 Create_Time { get; set; }

        public UInt32 Update_Time { get; set; }
    }
    #endregion
}
