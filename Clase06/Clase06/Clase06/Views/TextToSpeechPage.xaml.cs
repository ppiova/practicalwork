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
    public partial class TextToSpeechPage : ContentPage
    {
        IEnumerable<Locale> locales;
        public TextToSpeechPage()
        {
            InitializeComponent();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            locales = await TextToSpeech.GetLocalesAsync();

            foreach (var l in locales)
                Languages.Items.Add(l.Name);

        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Languages.SelectedIndex > 0)
            {
                TextToSpeech.SpeakAsync(TextToSpeak.Text, new SpeechOptions
                {
                    Locale = locales.Single(l => l.Name == Languages.SelectedItem.ToString())
                });
            }
        }
    }
}