using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clase02.Views
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
            ///UNO LLAMA A UN SERVICIO - API - CREDECIALES SON VALIDAS

            if(entryUsuario.Text == "Mponce" && entryPass.Text =="goya12345")
            {
                DisplayAlert("Login", "Ingreso Exitoso", "OK");
                //NAVEGATION X PAGE
            }
            else
            {
                //MENSAJE ERROR
                DisplayAlert("Login", "Ingreso Fallido", "OK");
            }
        }
    }
}