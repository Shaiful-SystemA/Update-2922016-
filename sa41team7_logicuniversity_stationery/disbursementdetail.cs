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
    
    public partial class disbursementdetail
    {
        public int disbursedetailID { get; set; }
        public int disbursementID { get; set; }
        public string itemID { get; set; }
        public int actualqty { get; set; }
        public int neededqty { get; set; }
    
        public virtual catalogue catalogue { get; set; }
        public virtual disbursement disbursement { get; set; }
    }
}