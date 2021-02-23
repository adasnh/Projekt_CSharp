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
using System.Data.SqlClient;
using System.Configuration;

namespace MagazynDNAProjekt
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public LoginWindow()
        {
            InitializeComponent();
            DnaDatabaseEntities db = new DnaDatabaseEntities();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if ( con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            if (VerifyUser(txtUserName.Text, txtPassword.Password))
            {
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Login lub hasło niepoprawne", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPassword.Clear();
                txtUserName.Clear();
            }
        }
        private bool VerifyUser(string username, string password)
        {

            con.Open();
            com.Connection = con;
            com.CommandText = "select Status from uzytkownicy where nazwa='" + username + "' and haslo='" + password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void Border_MouseDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            
                Application.Current.Shutdown();
            
        }
    }
}
