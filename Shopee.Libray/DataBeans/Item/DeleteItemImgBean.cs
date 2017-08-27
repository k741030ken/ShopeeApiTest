using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region DeleteItemImgBean
    public class DeleteItemImgBean
    {
        public UInt32 Item_Id { get; set; }

        public List<string> Images { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region DeleteItemImgReturnBean
    public class DeleteItemImgReturnBean
    {
        public string Error { get; set; }
    } 
    #endregion
}
