//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sa41team7_logicuniversity_stationery
{
    using System;
    using System.Collections.Generic;
    
    public partial class adjustvoucher
    {
        public adjustvoucher()
        {
            this.adjustvoucherdetails = new HashSet<adjustvoucherdetail>();
        }
    
        public int voucherID { get; set; }
        public System.DateTime createdate { get; set; }
        public string status { get; set; }
        public string clerkID { get; set; }
        public string approverID { get; set; }
        public double totalamount { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual staff staff1 { get; set; }
        public virtual ICollection<adjustvoucherdetail> adjustvoucherdetails { get; set; }
    }
}