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
    public partial class AppInfoPage : ContentPage
    {
        public AppInfoPage()
        {
            InitializeComponent();

            AppName.Text = AppInfo.Name;
            PackageName.Text = AppInfo.PackageName;
            Version.Text = AppInfo.Version.ToString();
            Build.Text = AppInfo.BuildString;
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            AppInfo.ShowSettingsUI();
        }
    }
}