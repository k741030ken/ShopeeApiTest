using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Order
{
    #region GetEscrowDetailsBean
    public class GetEscrowDetailsBean
    {
        public string Ordersn { get; set; }

        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region EscrowDetailsBean
    public class EscrowDetailsBean
    {
        public string Error { get; set; }

        public EscrowDetailsOrder Order { get; set; }
    } 
    #endregion

    #region EscrowDetailsOrder
    public class EscrowDetailsOrder
    {
        public string Ordersn { get; set; }

        public string Country { get; set; }

        public IncomeDetails Income_Details { get; set; }

        public string Shipping_Carrier { get; set; }

        public string Escrow_Currency { get; set; }

        public string Exchange_Rate { get; set; }

        public string Escrow_Channel { get; set; }

        public string Payee_Id { get; set; }

        public BankAccount Bank_Account { get; set; }
    } 
    #endregion

    #region IncomeDetails
    public class IncomeDetails
    {
        public string Local_Currency { get; set; }

        public double Total_Amount { get; set; }

        public double Coin { get; set; }

        public double Voucher { get; set; }

        public double Seller_Rebate { get; set; }

        public double Commission_Fee { get; set; }

        public double Escrow_Amount { get; set; }

        public double? Actual_Shipping_Cost { get; set; }

        public double? Shipping_Fee_Rebate { get; set; }
    } 
    #endregion

    #region BankAccount
    public class BankAccount
    {
        public string Bank_Name { get; set; }

        public string Bank_Account_Number { get; set; }

        public string Bank_Account_Country { get; set; }
    } 
    #endregion
}