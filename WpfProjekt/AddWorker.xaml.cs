using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfProjekt
{
    /// <summary>
    /// Logika dla klasy AddWorker
    /// </summary>
    public partial class AddWorker : Window
    {
        /// <summary>
        /// Publiczne property
        /// </summary>
        public string imie { get; set; }
        public string nazwisko { get; set; }

        private int UpdatingWorkerId = 0;
        Database1Entities2 db = new Database1Entities2();
        /// <summary>
        /// Publiczny konstruktor klasy AddWorker
        /// </summary>
        public AddWorker()
        {
            InitializeComponent();

            this.gridWorkers.ItemsSource = db.Workers.ToList();
 
        }
        private void Create_button(object sender, RoutedEventArgs e)
        {

            try
            {
                Workers newWorker = new Workers()
                {
                    imie = imieTextBox.Text,
                    nazwisko = nazwiskoTextBox.Text,
                };
                db.Workers.Add(newWorker);
                db.SaveChanges();

                this.gridWorkers.ItemsSource = db.Workers.ToList();
                imieTextBox.Clear();
                nazwiskoTextBox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void Delete_button(object sender, RoutedEventArgs e)
        {
           
                var customer = db.Workers.FirstOrDefault(y => y.Id == workerID);
            try
            {
                db.Workers.Remove(customer);
                db.SaveChanges();
                this.gridWorkers.ItemsSource = db.Workers.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można usunąć powiązanych rekordów", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

           
        }

        private void Update_button(object sender, RoutedEventArgs e)
        {
            db.Workers.Load();

            var v = from w in db.Workers
                    where w.Id == this.UpdatingWorkerId
                    select w;
            Workers obj = v.SingleOrDefault();

            if (obj != null)
            {
                obj.imie = this.imieTextBox.Text;
                obj.nazwisko = this.nazwiskoTextBox.Text;

            }

            try
            {
                db.SaveChanges();
                this.gridWorkers.ItemsSource = db.Workers.ToList();
                imieTextBox.Clear();
                nazwiskoTextBox.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można edytować powiązanych rekordów", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        int workerID = 0;
        private void gridWorkers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            var w = this.gridWorkers.SelectedItem as Workers;
            if(w == null)
            {
                this.imieTextBox.Text = string.Empty;
                this.nazwiskoTextBox.Text = string.Empty;
                return;
            }
            this.imieTextBox.Text = w.imie;
            this.nazwiskoTextBox.Text = w.nazwisko;
            this.workerID = w.Id;
        }
    } 
}

