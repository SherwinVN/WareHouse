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
    
    public partial class Location
    {
        public System.Guid LocationID { get; set; }
        public Nullable<System.Guid> BranchID { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
