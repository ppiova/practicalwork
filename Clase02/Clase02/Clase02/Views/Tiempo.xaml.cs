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
    public partial class Tiempo : ContentPage
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int v, d, tiempo;

            v = int.Parse(entryVelocidad.Text);
            d = int.Parse(entryDistancia.Text);

            tiempo = d / v;

            lblRsultado.Text = tiempo.ToString();

        }
    }
}