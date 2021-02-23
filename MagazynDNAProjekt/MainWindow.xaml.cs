using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MagazynDNAProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closed += MainWindow_Closed;
        }
        void MainWindow_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }
        private void Border_MouseDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }   

        private void ListOfElectroRentals(object sender, RoutedEventArgs e)
        {
            var addListElectroRentalsWindow = new ElectroRentalsList();
            addListElectroRentalsWindow.Show();
        }

        private void ReturnElectro(object sender, RoutedEventArgs e)
        {
            var addReturnElectroWindow = new ReturnElectro();
            addReturnElectroWindow.Show();
        }

        private void RentElectro(object sender, RoutedEventArgs e)
        {
            var addRentElectroWindow = new RentElectro();
            addRentElectroWindow.Show();
        }

        private void ListOfItems(object sender, RoutedEventArgs e)
        {
            var addListOfItemsWindow = new ListOfItems();
            addListOfItemsWindow.Show();
        }

        private void GiveItem(object sender, RoutedEventArgs e)
        {
            var addGiveItemWindow = new GiveItem();
            addGiveItemWindow.Show();
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var addAddItemWindow = new AddItem();
            addAddItemWindow.Show();
        }

        private void AddWorker(object sender, RoutedEventArgs e)
        {
            var addWorkerPage = new AddWorker();
            addWorkerPage.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
                Application.Current.Shutdown();
        }
    }
}
