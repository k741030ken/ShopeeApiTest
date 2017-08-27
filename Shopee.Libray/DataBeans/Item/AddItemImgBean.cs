using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region AddItemImgBean
    public class AddItemImgBean
    {
        public UInt32 Item_Id { get; set; }

        public List<string> Images { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region AddItemImgReturnBean
    public class AddItemImgReturnBean
    {
        public string Error { get; set; }
    } 
    #endregion
}
