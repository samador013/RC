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
    
    public partial class Fish_Species
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fish_Species()
        {
            this.SurveyDetail1 = new HashSet<Fish_SurveyDetail>();
        }
    
        public short SpeciesID { get; set; }
        public string SpeciesName { get; set; }
        public Nullable<byte> SpeciesGroupID { get; set; }
        public bool SpeciesActive { get; set; }
    
        public virtual Fish_SpeciesGroup SpeciesGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fish_SurveyDetail> SurveyDetail1 { get; set; }
    }
}
