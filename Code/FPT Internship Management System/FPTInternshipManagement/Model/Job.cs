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
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.Aspirations = new HashSet<Aspiration>();
            this.SkillDetails = new HashSet<SkillDetail>();
        }
    
        public int JobID { get; set; }
        public string JobName { get; set; }
        public string ContentJob { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> RecruiterID { get; set; }
        public Nullable<int> AmountStudent { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aspiration> Aspirations { get; set; }
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkillDetail> SkillDetails { get; set; }
    }
}
