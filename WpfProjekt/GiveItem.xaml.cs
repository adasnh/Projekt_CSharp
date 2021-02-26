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
    /// Interaction logic for GiveItem.xaml
    /// </summary>
    public partial class GiveItem : Window
    {
        Database1Entities2 db = new Database1Entities2();
        public GiveItem()
        {
            InitializeComponent();


            this.gridGiveItems.ItemsSource = db.GiveAway.ToList();
        }

        private void Create_button(object sender, RoutedEventArgs e)
        {
            try
            {
                GiveAway ga = new GiveAway()
                {
                    id_artykulu = int.Parse(idartykuluTextBox.Text),
                    id_pracownika = int.Parse(idpracownikaTextBox.Text),
                    ilosc_sztuk = int.Parse(iloscTextBox.Text),
                    data_wydania = Convert.ToDateTime(data_wydaniaDatePicker)
                };
                db.GiveAway.Add(ga);
                db.SaveChanges();
                this.gridGiveItems.ItemsSource = db.GiveAway.ToList();
                idartykuluTextBox.Clear();
                idpracownikaTextBox.Clear();
                iloscTextBox.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void Update_button(object sender, RoutedEventArgs e)
        {
            db.GiveAway.Load();

            var v = from w in db.GiveAway 
                    where w.id_zamowienia == this.GiveAwayID
                    select w;
            GiveAway obj = v.SingleOrDefault();

            if (obj != null)
            {
                obj.id_artykulu = int.Parse(this.idartykuluTextBox.Text);
                obj.id_pracownika = int.Parse(this.idpracownikaTextBox.Text);
                obj.ilosc_sztuk = int.Parse(this.iloscTextBox.Text);
                obj.data_wydania = Convert.ToDateTime(this.data_wydaniaDatePicker);

            }

            try
            {
                db.SaveChanges();
                this.gridGiveItems.ItemsSource = db.GiveAway.ToList();
                idartykuluTextBox.Clear();
                idpracownikaTextBox.Clear();
                iloscTextBox.Clear();
;
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można edytować powiązanych rekordów", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    

        private void Delete_button(object sender, RoutedEventArgs e)
        {
            var ga = db.GiveAway.FirstOrDefault(y => y.id_zamowienia == GiveAwayID);
            try
            {
                db.GiveAway.Remove(ga);
                db.SaveChanges();
                this.gridGiveItems.ItemsSource = db.GiveAway.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można usunąć powiązanych rekordów", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        }
        int GiveAwayID = 0;
        private void gridWorkers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var w = this.gridGiveItems.SelectedItem as GiveAway;
            if (w == null)
            {
                this.idartykuluTextBox.Text = string.Empty;
                this.idpracownikaTextBox.Text = string.Empty;
                this.iloscTextBox.Text = string.Empty;
                this.data_wydaniaDatePicker.Text = string.Empty;
                return;
            }
            this.idartykuluTextBox.Text = w.id_artykulu.ToString();
            this.idpracownikaTextBox.Text = w.id_pracownika.ToString();
            this.iloscTextBox.Text = w.ilosc_sztuk.ToString();
            this.data_wydaniaDatePicker.Text = w.data_wydania.ToString();
            this.GiveAwayID = w.id_zamowienia;
        }
    }
}
