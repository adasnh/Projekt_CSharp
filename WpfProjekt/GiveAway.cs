//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfProjekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiveAway
    {
        public int id_zamowienia { get; set; }
        public int id_artykulu { get; set; }
        public int id_pracownika { get; set; }
        public int ilosc_sztuk { get; set; }
        public System.DateTime data_wydania { get; set; }
    
        public virtual Items Items { get; set; }
        public virtual Workers Workers { get; set; }
    }
}