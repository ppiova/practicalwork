using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClase02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //lo normal es llamar a un servicio para validar credenciales

            if (entryUsuario.Text == "mponce" && entryClave.Text == "goya12345")
            {
                DisplayAlert("Login", "Ingreso Exitoso", "OK");

                App.Current.MainPage = new NavigationPage(new Aceleracion());
            }
            else
            {
                DisplayAlert("Login", "Ingreso Fallido", "OK");
            }
        }
    }
}