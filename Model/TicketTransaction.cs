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
    
    public partial class TicketTransaction
    {
        public int TicketTransactionId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime TicketTransactionDate { get; set; }
        public int TicketQuantity { get; set; }
        public string TicketTransactionStatus { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
