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
    public partial class ListarNumeros : ContentPage
    {
        public ListarNumeros()
        {
            InitializeComponent();
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            StackLista.Children.Clear();
            if (EntryNumero.Text != string.Empty)
            {
                int numero = int.Parse(EntryNumero.Text);

                for (int iterador = 1; iterador <= numero; iterador++)
                {
                    StackLista.Children.Add(new Label()
                    {
                        FontSize = 25,
                        Text = iterador.ToString()
                    });
                }
            }
        }
    }
}