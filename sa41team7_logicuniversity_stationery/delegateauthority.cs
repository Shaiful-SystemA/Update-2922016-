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
    
    public partial class delegateauthority
    {
        public int delegateID { get; set; }
        public string headID { get; set; }
        public string employeeID { get; set; }
        public System.DateTime startdate { get; set; }
        public System.DateTime enddate { get; set; }
        public string status { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual staff staff1 { get; set; }
    }
}
