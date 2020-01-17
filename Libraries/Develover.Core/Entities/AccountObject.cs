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
    
    public partial class AccountObject
    {
        public System.Guid AccountObjectID { get; set; }
        public System.Guid AccountObjectGroupID { get; set; }
        public Nullable<System.Guid> BranchID { get; set; }
        public string AccountObjectCode { get; set; }
        public string AccountObjectName { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Nullable<decimal> AgreementSalary { get; set; }
        public Nullable<decimal> SalaryCoefficient { get; set; }
        public Nullable<int> NumberOfDependent { get; set; }
        public Nullable<decimal> InsuranceSalary { get; set; }
        public string Address { get; set; }
        public string CompanyTaxCode { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public Nullable<decimal> MaximizeDebtAmount { get; set; }
        public Nullable<int> DueTime { get; set; }
        public string Country { get; set; }
        public string ProvinceOrCity { get; set; }
        public string District { get; set; }
        public string WardOrCommune { get; set; }
        public string Prefix { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactMobile { get; set; }
        public string OtherContactMobile { get; set; }
        public string ContactFixedTel { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        public Nullable<bool> IsVendor { get; set; }
        public Nullable<bool> IsCustomer { get; set; }
        public Nullable<bool> IsEmployee { get; set; }
        public Nullable<int> AccountObjectType { get; set; }
        public string Description { get; set; }
        public string LegalRepresentative { get; set; }
        public string EInvoiceContactName { get; set; }
        public string EInvoiceContactEmail { get; set; }
        public string EInvoiceContactAddress { get; set; }
        public string EInvoiceContactMobile { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
