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
    
    public partial class PrintInvoice
    {
        public string I_ID { get; set; }
        public Nullable<System.DateTime> IDate { get; set; }
        public string customer_ID { get; set; }
        public Nullable<int> quality { get; set; }
        public Nullable<double> initial_total { get; set; }
        public Nullable<double> final_total { get; set; }
        public string Products { get; set; }
    }
}
