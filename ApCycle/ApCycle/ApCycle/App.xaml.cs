using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Connectivity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ApCycle
{
    public partial class App : Application
    {
        string hour = "";
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                MainPage = new NavigationPage(new ExceptionView());
            }
        }

        protected override void OnSleep()
        {
            if (Application.Current.Properties.ContainsKey("Las")==false)
            {
                DateTime time = DateTime.Now;
                hour = Convert.ToString(time);
                Application.Current.Properties["Las"] = hour;
            }
            else
            {
                DateTime time = DateTime.Now;
                hour = Convert.ToString(time);
                Application.Current.Properties["Las"] = hour;
            }
        }

        protected override void OnResume()
        {
            Application.Current.MainPage.DisplayAlert("Xamarin.Forms Message"
                ,"OnResume();"
                ,"Ok");
        }
    }
}
