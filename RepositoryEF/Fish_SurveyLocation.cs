//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RCIDRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fish_SurveyLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fish_SurveyLocation()
        {
            this.SurveyDetails = new HashSet<Fish_SurveyDetail>();
        }
    
        public int SurveyID { get; set; }
        public byte SurveyNumber { get; set; }
        public string LocationDetails { get; set; }
        public Nullable<System.DateTime> SurveyDate { get; set; }
        public Nullable<short> SurveyDurationSeconds { get; set; }
        public Nullable<byte> GeneratorID { get; set; }
        public string SurveyLocationComments { get; set; }
    
        public virtual Fish_Survey Survey { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fish_SurveyDetail> SurveyDetails { get; set; }
    }
}
