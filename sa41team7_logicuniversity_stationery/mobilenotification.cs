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
    
    public partial class mobilenotification
    {
        public int notificationID { get; set; }
        public string type { get; set; }
        public string senderID { get; set; }
        public string receiverID { get; set; }
        public System.DateTime sendtime { get; set; }
        public string status { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual staff staff1 { get; set; }
    }
}
