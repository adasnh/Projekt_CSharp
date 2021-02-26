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
    /// Interaction logic for AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        Database1Entities2 db = new Database1Entities2();
        public AddItem()
        {
            InitializeComponent();

            var items = from w in db.Items
                        select w;

            this.gridItems.ItemsSource = items.ToList();
        }
        private void Create_button(object sender, RoutedEventArgs e)
        {

            try
            {
                Items newItem = new Items()
                {
                    nazwa = nazwaTextBox.Text,
                    koszt_zakupu = decimal.Parse(kosztTextBox.Text),
                    ilosc_sztuk = int.Parse(iloscTextBox.Text)
                };
                db.Items.Add(newItem);
                db.SaveChanges();

                this.gridItems.ItemsSource = db.Items.ToList();
                kosztTextBox.Clear();
                nazwaTextBox.Clear();
                iloscTextBox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void Delete_button(object sender, RoutedEventArgs e)
        {
            var customer = db.Items.FirstOrDefault(y => y.id_artykulu == ItemId);
            try
            {

                db.Items.Remove(customer);
                db.SaveChanges();
                this.gridItems.ItemsSource = db.Workers.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Nie można usunąć powiązanych rekordów", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Update_button(object sender, RoutedEventArgs e)
        {
            db.Items.Load();

            var v = from w in db.Items
                    where w.id_artykulu == this.ItemId
                    select w;
            Items obj = v.SingleOrDefault();

            if (obj != null)
            {
                obj.nazwa = this.nazwaTextBox.Text;
                obj.koszt_zakupu = decimal.Parse(this.kosztTextBox.Text);
                obj.ilosc_sztuk = int.Parse(this.iloscTextBox.Text);

            }

            try
            {
                db.SaveChanges();
                this.gridItems.ItemsSource = db.Items.ToList();
                kosztTextBox.Clear();
                nazwaTextBox.Clear();
                iloscTextBox.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("Nie można edytować powiązanych rekordów", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        
        private int ItemId = 0;
        private void gridWorkers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             
            var w = this.gridItems.SelectedItem as Items;
            if (w == null)
            {
                this.nazwaTextBox.Text = string.Empty;
                this.kosztTextBox.Text = string.Empty;
                this.iloscTextBox.Text = string.Empty;
                return;
            }
            this.nazwaTextBox.Text = w.nazwa;
            this.kosztTextBox.Text = w.koszt_zakupu.ToString();
            this.iloscTextBox.Text = w.ilosc_sztuk.ToString();
            this.ItemId = w.id_artykulu;
        }

    }
}