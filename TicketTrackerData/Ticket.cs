//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketTrackerEntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public int PerformanceId { get; set; }
        public string Description { get; set; }
        public Nullable<int> AmountSold { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Performance Performance { get; set; }
    }
}
