//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeApp.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmplyPayInfo
    {
        public System.Guid pernr { get; set; }
        public System.DateTime datefrom { get; set; }
        public System.DateTime dateto { get; set; }
        public Nullable<decimal> dailyWorkHours { get; set; }
        public Nullable<decimal> weeklyWorkHours { get; set; }
        public Nullable<decimal> payRate { get; set; }
        public string overtimefactor { get; set; }
        public string Notes { get; set; }
    }
}
