//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightMode.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HealthReport
    {
        public long ReportId { get; set; }
        public string Description { get; set; }
        public Nullable<long> AppId { get; set; }
        public Nullable<long> HPId { get; set; }
        public string CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual HealthParameter HealthParameter { get; set; }
    }
}
