using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Order
{
    #region GetOrderDetailsBean
    public class GetOrderDetailsBean
    {
        public List<string> Ordersn_List { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }

    } 
    #endregion

    #region OrderDetailsBean
    public class OrderDetailsBean
    {
        public List<string> Errors { get; set; }

        public List<OrderDetailsOrder> Orders { get; set; }
    } 
    #endregion

    #region OrderDetailsOrder
    public class OrderDetailsOrder
    {
        public string Ordersn { get; set; }

        public string Country { get; set; }

        public string Currency { get; set; }

        public bool Cod { get; set; }

        public string Tracking_No { get; set; }

        public UInt32 Days_To_Ship { get; set; }

        public double Estimated_Shipping_Fee { get; set; }

        public double Actual_Shipping_Cost { get; set; }

        public double Total_Amount { get; set; }

        public string Order_Status { get; set; }

        public string Shipping_Carrier { get; set; }

        public string Payment_Method { get; set; }

        public bool Goods_To_Declare { get; set; }

        public string Message_To_Seller { get; set; }

        public UInt32 Create_Time { get; set; }

        public UInt32 Update_Time { get; set; }

        public List<OrderDetailsOrderItems> Items { get; set; }

        public double? Escrow_Amount { get; set; }

        public RecipientAddress Recipient_Address { get; set; }
    } 
    #endregion

    #region RecipientAddress
    public class RecipientAddress
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Town { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Zipcode { get; set; }

        public string Full_Address { get; set; }
    } 
    #endregion

    #region OrderDetailsOrderItems
    public class OrderDetailsOrderItems
    {
        public string Item_Id { get; set; }

        public string Item_Name { get; set; }

        public string Item_Sku { get; set; }

        public UInt32 Variation_Id { get; set; }

        public string Variation_Name { get; set; }

        public string Variation_Sku { get; set; }

        public UInt32 Variation_Quantity_Purchased { get; set; }

        public double Variation_Original_Price { get; set; }

        public double Variation_Discounted_Price { get; set; }
    } 
    #endregion
}
