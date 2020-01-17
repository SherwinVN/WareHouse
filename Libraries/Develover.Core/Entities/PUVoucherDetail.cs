//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Develover.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class PUVoucherDetail
    {
        public System.Guid VoucherDetailID { get; set; }
        public System.Guid VoucherID { get; set; }
        public System.Guid ProductID { get; set; }
        public string Description { get; set; }
        public System.Guid LocationID { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public System.Guid UOMID { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal AmountForeignCurrency { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmountForeignCurrency { get; set; }
        public decimal DiscountAmount { get; set; }
        public Nullable<decimal> VATRate { get; set; }
        public decimal VATAmountForeignCurrency { get; set; }
        public decimal VATAmount { get; set; }
        public string VATAccount { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string VATDescription { get; set; }
        public Nullable<System.Guid> AccountObjectID { get; set; }
        public Nullable<System.Guid> TaxAccountObjectID { get; set; }
        public string TaxAccountObjectName { get; set; }
        public string TaxAccountObjectAddress { get; set; }
        public string TaxAccountObjectTaxCode { get; set; }
        public Nullable<System.DateTime> InvDate { get; set; }
        public string InvNo { get; set; }
        public string InvSeries { get; set; }
        public string InvTemplateNo { get; set; }
    }
}
