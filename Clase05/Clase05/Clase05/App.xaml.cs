using Clase05.Data;
using Clase05.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clase05
{
    public partial class App : Application
    {
        //Property static para poder acceder al context en todo el aplicativo
        public static DatabaseContext Context { get; set; }
        public App()
        {
            InitializeComponent();
          
            InitializeDatabase();

           //MainPage = new NavigationPage(new HomePage());
           
            MainPage = new MainPage();
        }

        private void InitializeDatabase()
        {
            var dbPath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "TaskToDo.db3");

            Context = new DatabaseContext(dbPath);
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
