using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApCycle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string hour = "";
            if (Application.Current.Properties.ContainsKey("Las")==false)
            {
                
                DateTime time = DateTime.Now;
                hour = Convert.ToString(time);
                Application.Current.Properties["Las"] = hour;
                lastseen.Text = "Última conexión registrada";
            }
            else
            {
                string hora = Convert.ToString(Application.Current.Properties["Las"]);
                lastseen.Text = hora;
            }
        }
    }
}
