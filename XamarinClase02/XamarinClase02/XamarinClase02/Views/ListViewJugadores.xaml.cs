using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinClase02.Models;

namespace XamarinClase02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewJugadores : ContentPage
    {
        public List<Jugador> Jugadores = new List<Jugador>();
        public ListViewJugadores()
        {
            InitializeComponent();

            LoadJugadores();

        }

        private void LoadJugadores()
        {
            this.Jugadores = new List<Jugador>();
            Jugador jugador = new Jugador()
            {
                Imagen = "https://img.elcomercio.pe/files/article_content_ec_fotos/uploads/2018/12/30/5c2923ba1e201.jpeg",
                Nombre = "Lebron James",
                Equipo = "Los Angeles Lakers"
            };


            this.Jugadores.Add(jugador);
            jugador = new Jugador()
            {
                Imagen = "https://i.cdn.turner.com/nba/nba/celtics/photos/larry-bird-dribble300400.jpg",
                Nombre = "Larry Bird",
                Equipo = "Celtics"
            };


            this.Jugadores.Add(jugador);
            jugador = new Jugador()
            {
                Imagen = "https://www.estadiodeportes.mx/wp-content/uploads/2017/04/michael-jordan-basketball-sport-wallpapers-hd-wallpapers-hd-celebrities-sports-photo-michael-jordan-wallpaper.jpg",
                Nombre = "Michael Jordan",
                Equipo = "Chicago Bulls"
            };

            this.Jugadores.Add(jugador);
            jugador = new Jugador()
            {
                Imagen = "https://i.dailymail.co.uk/i/pix/2018/01/06/07/47CD00D500000578-5241165-image-a-20_1515222562100.jpg",
                Nombre = "Julius Erving",
                Equipo = "Sixers"
            };

            this.Jugadores.Add(jugador);
            jugador = new Jugador()
            {
                Imagen = "https://clutchpoints.com/wp-content/uploads/2018/04/Manu-Ginobili-Spurs.jpg",
                Nombre = "Manu Ginóbili",
                Equipo = "San Antonio"
            };

            this.Jugadores.Add(jugador);
            this.jugadores.ItemsSource = this.Jugadores;
        }
    }
}