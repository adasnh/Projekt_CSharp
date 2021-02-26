using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjekt
{
    class ItemViewModel
    {
        /// <summary>
        /// Publiczne property klasy ItemViewModel
        /// </summary>
        public int idart { get; set; }
        public string nazwa { get; set; }
        public decimal koszt { get; set; }
        public int ilosc { get; set; }

        /// <summary>
        /// Publiczny Konstruktor klasy ItemViewModel
        /// </summary>
        public ItemViewModel(Items item)
        {
            idart = item.id_artykulu;
            nazwa = item.nazwa;
            koszt = item.koszt_zakupu;
            ilosc = item.ilosc_sztuk;
        }
    }
}
