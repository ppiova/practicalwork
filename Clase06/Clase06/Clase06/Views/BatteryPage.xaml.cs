using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clase06.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatteryPage : ContentPage
    {
        public BatteryPage()
        {
            InitializeComponent();

            BatteryLevel.Text = (Battery.ChargeLevel * 100).ToString() + "%";

            //EnergySaver.Text = Battery.EnergySaverStatus.ToString();

            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            BatteryLevel.Text = (e.ChargeLevel * 100).ToString() + "%";
        }
    
    }
}