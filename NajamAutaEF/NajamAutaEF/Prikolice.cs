//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NajamAutaEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prikolice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prikolice()
        {
            this.Rezervacije = new HashSet<Rezervacije>();
        }
    
        public int PrikolicaID { get; set; }
        public string TipPrikolice { get; set; }
        public int BrojOsovina { get; set; }
        public decimal DnevniNajam { get; set; }
        public bool PotrebaBE { get; set; }
        public bool Rezervirana { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
