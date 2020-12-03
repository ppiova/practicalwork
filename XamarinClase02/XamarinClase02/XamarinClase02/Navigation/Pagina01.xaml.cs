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
    public partial class Pagina01 : ContentPage
    {
        public Pagina01()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Pagina02());
        }
    }
}