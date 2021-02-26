using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjekt
{
    class WorkerViewModel
    {
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }

        public WorkerViewModel(Workers worker)
        {
            id = worker.Id;
            imie = worker.imie;
            nazwisko = worker.nazwisko;
        }
    }
}
