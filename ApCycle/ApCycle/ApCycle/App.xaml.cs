using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            // Handle when your app starts
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
            // Handle when your app resumes
        }
    }
}
