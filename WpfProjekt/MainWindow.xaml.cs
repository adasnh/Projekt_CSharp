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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Database1Entities2 db = new Database1Entities2();
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
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddWorker(object sender, RoutedEventArgs e)
        {
            var goWorkerWindow = new AddWorker();
            goWorkerWindow.Show();
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var goItemsWindow = new AddItem();
            goItemsWindow.Show();
        }

        private void GiveItem(object sender, RoutedEventArgs e)
        {
            var goGiveItemWindow = new GiveItem();
            goGiveItemWindow.Show();
        }

        private void ListOfItems(object sender, RoutedEventArgs e)
        {

        }

        private void AboutMe(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("                 WSEI 2021\n    Programowanie obietowe C#\n          Adam Rosowicz 12450", "Info", MessageBoxButton.OK);
        }
    }
}
