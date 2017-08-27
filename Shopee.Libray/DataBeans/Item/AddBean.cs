using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region AddBean
    public class AddBean
    {
        public UInt32 Category_Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public UInt32 Stock { get; set; }

        public string Item_Sku { get; set; }

        public List<Variation> variations { get; set; }

        public List<Image> Images { get; set; }

        public List<Attribute> Attributes { get; set; }

        public List<Logistic> Logistics { get; set; }

        public double? Weight { get; set; }

        public double? Package_Length { get; set; }

        public double? Package_Width { get; set; }

        public double? Package_Height { get; set; }

        public UInt32? Days_To_Ship { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region Variation
    public class Variation
    {
        public string Name { get; set; }

        public UInt32 Stock { get; set; }

        public double Price { get; set; }

        public string Variation_Sku { get; set; }
    }
    #endregion

    #region Image
    public class Image
    {
        public string Url { get; set; }
    }
    #endregion

    #region Attribute
    public class Attribute
    {
        public string value { get; set; }

        public UInt32 Attributes_Id { get; set; }
    }
    #endregion

    #region Logistic
    public class Logistic
    {
        public UInt32 Logistic_Id { get; set; }

        public bool Enabled { get; set; }

        public double? Shipping_Fee { get; set; }

        public UInt32? Size_Id { get; set; }

        public bool? Is_Free { get; set; }
    }
    #endregion

    #region AddReturnBean
    public class AddReturnBean
    {
        public string Error { get; set; }

        public UInt32 Item_Id { get; set; }

        public string Warning { get; set; }
    }
    #endregion
}
