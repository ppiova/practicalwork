using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinClase02.Bindings;
using XamarinClase02.Navigation;
using XamarinClase02.Views;

namespace XamarinClase02
{
    public partial class App : Application
    {
        public static MasterDetailPage MenuPrincipal;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            //MainPage = new GridEjemplo();
            //MainPage = new NavigationPage(new Pagina01());


            //MasterDetailPage masterDetailPage = new MasterDetailPage();
            //masterDetailPage.Master = new MenuBasico();
            //masterDetailPage.Detail = new SeleccionarVehiculo();
            //MenuPrincipal = masterDetailPage;
            //MainPage = masterDetailPage;



            //MainPage = new TabbedPageVehiculos();

            //MainPage = new NavigationPage(new ToolbarItemPage());

            //MainPage = new BindingClases();

            //MainPage = new ListViewJugadores();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
