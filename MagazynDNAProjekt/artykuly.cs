//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagazynDNAProjekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class artykuly
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artykuly()
        {
            this.wydania = new HashSet<wydania>();
        }
    
        public int id_artykulu { get; set; }
        public string nazwa { get; set; }
        public Nullable<decimal> koszt_zakup { get; set; }
        public Nullable<int> ilosc_sztuk { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wydania> wydania { get; set; }
    }
}