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
    
    public partial class department
    {
        public department()
        {
            this.disbursements = new HashSet<disbursement>();
            this.requisitions = new HashSet<requisition>();
        }
    
        public string departmentID { get; set; }
        public string name { get; set; }
        public string contactID { get; set; }
        public Nullable<int> phone { get; set; }
        public Nullable<int> fax { get; set; }
        public string headID { get; set; }
        public string collectionpoint { get; set; }
        public string repID { get; set; }
    
        public virtual collectionpoint collectionpoint1 { get; set; }
        public virtual staff staff { get; set; }
        public virtual staff staff1 { get; set; }
        public virtual staff staff2 { get; set; }
        public virtual ICollection<disbursement> disbursements { get; set; }
        public virtual ICollection<requisition> requisitions { get; set; }
    }
}
