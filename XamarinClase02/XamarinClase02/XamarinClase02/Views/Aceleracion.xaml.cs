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
    public partial class Aceleracion : ContentPage
    {
        public Aceleracion()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int v, d, tiempo;

            v = int.Parse(entryVelocidad.Text);
            d = int.Parse(entryDistancia.Text);

            tiempo = d / v;

            lblResultado.Text = tiempo.ToString();


        }
    }
}