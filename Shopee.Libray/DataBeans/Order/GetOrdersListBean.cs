using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Order
{
    #region GetOrdersListBean
    public class GetOrdersListBean
    {
        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }

        public UInt32? Create_Time_From { get; set; }

        public UInt32? Create_Time_To { get; set; }

        public UInt32? Update_Time_From { get; set; }

        public UInt32? Update_Time_To { get; set; }

        public UInt32? Pagination_Entries_Per_Page { get; set; }

        public UInt32? Pagination_Offset { get; set; }
    } 
    #endregion

    #region OrdersListBean
    public class OrdersListBean
    {
        public List<OrdersListOrder> orders { get; set; }

        public bool more { get; set; }
    } 
    #endregion

    #region OrdersListOrder
    public class OrdersListOrder
    {
        public string Ordersn { get; set; }

        public string Order_Status { get; set; }

        public UInt32 Update_Time { get; set; }
    } 
    #endregion
}
