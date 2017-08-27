using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region UpdateItemBean
    public class UpdateItemBean
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Category_Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }

        public string Item_Sku { get; set; }

        public UInt32? Days_To_Ship { get; set; }

        public List<Variation> Variations { get; set; }
    } 
    #endregion

    #region UpdateItemReturnBean
    public class UpdateItemReturnBean
    {
        public string Error { get; set; }
    }
    #endregion

    #region Variation
    public class Variation
    {
        public UInt32 Variation_Id { get; set; }

        public string Name { get; set; }

        public string Variation_Sku { get; set; }
    }
    #endregion
}
