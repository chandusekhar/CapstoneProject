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
    
    public partial class Aspiration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aspiration()
        {
            this.SkillDetails = new HashSet<SkillDetail>();
            this.UserAspirations = new HashSet<UserAspiration>();
        }
    
        public int AspirationsID { get; set; }
        public string AspirationsName { get; set; }
        public Nullable<int> JobID { get; set; }
        public Nullable<double> Salary { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    
        public virtual Job Job { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkillDetail> SkillDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAspiration> UserAspirations { get; set; }
    }
}
