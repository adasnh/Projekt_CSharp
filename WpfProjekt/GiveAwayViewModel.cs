using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjekt
{
    class GiveAwayViewModel
    {
        /// <summary>
        /// Publiczne property klasy GiveAwayViewModel
        /// </summary>
        public int id_zam { get; set; }
        public int id_art { get; set; }
        public int id_prac { get; set; }

        public int ilosc_sztuk { get; set; }
        public DateTime data_wyd { get; set; }

        /// <summary>
        /// Publiczny Konstruktor klasy GiveAwayViewModel
        /// </summary>
        public GiveAwayViewModel (GiveAway ga)
        {
            id_zam = ga.id_zamowienia;
            id_prac = ga.id_pracownika;
            id_art = ga.id_artykulu;
            ilosc_sztuk = ga.ilosc_sztuk;
            data_wyd = ga.data_wydania;
        }
    }
}
