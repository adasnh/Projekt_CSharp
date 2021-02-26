using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfProjekt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            LoginWindow lw = new LoginWindow();
            bool? rslt = lw.ShowDialog();
            if (rslt == true)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
            }
            else
                this.Shutdown();
        }
    }
}
