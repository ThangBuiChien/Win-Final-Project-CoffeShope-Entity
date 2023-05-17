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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.Invoice_detail = new HashSet<Invoice_detail>();
        }
    
        public string I_ID { get; set; }
        public Nullable<System.DateTime> IDate { get; set; }
        public string customer_ID { get; set; }
        public string shop_ID { get; set; }
        public Nullable<double> coupon { get; set; }
        public Nullable<double> initial_total { get; set; }
        public Nullable<double> discount { get; set; }
        public string delivery { get; set; }
        public string employee_ID { get; set; }
        public Nullable<double> final_total { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Delivery_address Delivery_address { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shop Shop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_detail> Invoice_detail { get; set; }
    }
}