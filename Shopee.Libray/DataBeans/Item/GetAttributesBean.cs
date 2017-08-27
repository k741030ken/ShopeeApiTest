using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region GetAttributesBean
    public class GetAttributesBean
    {
        public UInt32 Category_Id { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region AttributesBean
    public class AttributesBean
    {
        public string Error { get; set; }

        public List<GetAttributesAttribute> Attributes { get; set; }
    } 
    #endregion

    #region GetAttributesAttribute
    public class GetAttributesAttribute
    {
        public UInt32 Attribute_Id { get; set; }

        public UInt32 Attribute_Name { get; set; }

        public bool Is_Mandatory { get; set; }

        public string Attribute_Type { get; set; }

        public string Input_Type { get; set; }

        public List<string> Options { get; set; }
    }
    #endregion
}
