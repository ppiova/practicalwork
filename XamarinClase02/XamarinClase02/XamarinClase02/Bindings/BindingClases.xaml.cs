using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinClase02.Models;

namespace XamarinClase02.Bindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingClases : ContentPage
    {
        public Persona person;
        public BindingClases()
        {
            InitializeComponent();


            LoadPersona();
        }

        private void LoadPersona()
        {
            this.person = new Persona();
            person.Nombre = "Diego Armando Maradona";
            person.Edad = 60;
            person.Imagen = "https://sunnewsonline.com/wp-content/uploads/2018/07/sei_12879938.jpg";
            this.BindingContext = person;
        }
    }
}