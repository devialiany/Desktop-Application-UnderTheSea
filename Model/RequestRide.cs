//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnderTheSea.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestRide
    {
        public int ReqRideId { get; set; }
        public string ReqRideName { get; set; }
        public string ReqRideDescription { get; set; }
        public string ReqRideHowToWork { get; set; }
        public string ReqRideKind { get; set; }
        public string ReqRideSafetyInformation { get; set; }
        public string ReqRideStatus { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<int> RideId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}