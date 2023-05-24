using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Booking_Test.View;
using Booking_Test.ViewModel;

namespace Booking_Test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show();
            loginView.IsVisibleChanged += (s, ev) =>
            {
                //Login success with valid user
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    //var mainView = new MainView();
                    var mainViewModel = new MainViewModel(); // Assuming you have a MainViewModel class
                    var mainView = new MainView();
                    mainView.DataContext = mainViewModel;
                    mainView.Show();
                    loginView.Close();
                }
            };
        }
    }
}
