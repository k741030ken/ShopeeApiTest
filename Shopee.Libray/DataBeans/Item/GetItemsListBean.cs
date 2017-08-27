using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region GetItemsListBean
    public class GetItemsListBean
    {
        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }

        public UInt32 Pagination_Offset { get; set; }

        public UInt32 Pagination_Entries_Per_Page { get; set; }
    } 
    #endregion

    #region ItemsListBean
    public class ItemsListBean
    {
        public string Error { get; set; }

        public List<ItemsListItem> Items { get; set; }

        public bool More { get; set; }
    }
    #endregion

    #region ItemsListItem
    public class ItemsListItem
    {
        public UInt32 Item_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public string Status { get; set; }
    }
    #endregion
}
