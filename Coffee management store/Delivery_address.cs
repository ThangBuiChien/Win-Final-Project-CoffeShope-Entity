//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee_management_store
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivery_address
    {
        public string I_ID { get; set; }
        public string Address { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}