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
    
    public partial class catalogue
    {
        public catalogue()
        {
            this.adjustvoucherdetails = new HashSet<adjustvoucherdetail>();
            this.disbursementdetails = new HashSet<disbursementdetail>();
            this.itemprices = new HashSet<itemprice>();
            this.podetails = new HashSet<podetail>();
            this.requisitiondetails = new HashSet<requisitiondetail>();
            this.stockcards = new HashSet<stockcard>();
        }
    
        public string itemID { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public int reorderlevel { get; set; }
        public int reorderqty { get; set; }
        public string unit { get; set; }
        public string bin { get; set; }
        public Nullable<int> balance { get; set; }
        public string image { get; set; }
        public Nullable<double> avgprice { get; set; }
    
        public virtual ICollection<adjustvoucherdetail> adjustvoucherdetails { get; set; }
        public virtual ICollection<disbursementdetail> disbursementdetails { get; set; }
        public virtual ICollection<itemprice> itemprices { get; set; }
        public virtual ICollection<podetail> podetails { get; set; }
        public virtual ICollection<requisitiondetail> requisitiondetails { get; set; }
        public virtual ICollection<stockcard> stockcards { get; set; }
    }
}
