//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTYS_PROJE
{
    using System;
    using System.Collections.Generic;
    
    public partial class OdaKayitlari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OdaKayitlari()
        {
            this.Kasa = new HashSet<Kasa>();
        }
    
        public int odaKayitId { get; set; }
        public Nullable<int> musteriId { get; set; }
        public Nullable<int> odaId { get; set; }
        public string girisTarihi { get; set; }
        public string cikisTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kasa> Kasa { get; set; }
        public virtual Musteriler Musteriler { get; set; }
        public virtual Odalar Odalar { get; set; }
    }
}
