using System;
using TravellingViajes.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes
{
    public partial class App : Application
    {
        public static DatabaseContext Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDatabase();

            MainPage = new NavigationPage(new MainPage());
        }

        private void InitializeDatabase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var DBPath = System.IO.Path.Combine(folderApp, "bd.db3");
            Context = new DatabaseContext(DBPath);
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
