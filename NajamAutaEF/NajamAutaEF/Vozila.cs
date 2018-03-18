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
    
    public partial class Vozila
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vozila()
        {
            this.Rezervacije = new HashSet<Rezervacije>();
        }
    
        public int VoziloID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Godiste { get; set; }
        public string Gorivo { get; set; }
        public int BrojSjedala { get; set; }
        public bool Kuka { get; set; }
        public decimal DnevniNajam { get; set; }
        public bool Rezerviran { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }

        public string NazivAuta { get; set; }

        public void Ucitaj()
        {
            NazivAuta = Marka + " " + Model;
        }
    }
}