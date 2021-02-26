using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjekt
{
    class WorkerViewModel
    {
        /// <summary>
        /// Publiczne property klasy WorkerViewModel
        /// </summary>
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        /// <summary>
        /// Publiczny Konstruktor klasy WorkerViewModel
        /// </summary>
        public WorkerViewModel(Workers worker)
        {
            id = worker.Id;
            imie = worker.imie;
            nazwisko = worker.nazwisko;
        }
    }
}
