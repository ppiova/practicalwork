using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClase02.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuBasico : ContentPage
    {
        public MenuBasico()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Label label = (Label)sender;

            if (label.Text == "Auto")
                App.MenuPrincipal.Detail = new Auto();
            else if (label.Text == "Moto") 
                App.MenuPrincipal.Detail = new Moto();
            else 
                App.MenuPrincipal.Detail = new Bus();

            App.MenuPrincipal.IsPresented = false;
        }
    }
}