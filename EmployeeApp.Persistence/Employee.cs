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
    
    public partial class Employee
    {
        public System.Guid pernr { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public Nullable<System.Guid> address { get; set; }
    }
}
