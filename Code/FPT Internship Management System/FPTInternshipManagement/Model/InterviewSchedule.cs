//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class InterviewSchedule
    {
        public int InterviewID { get; set; }
        public int StudentID { get; set; }
        public int RecruiterID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int LocationID { get; set; }
        public string Status { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
