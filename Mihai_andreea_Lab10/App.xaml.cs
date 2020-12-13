using System;
using Mihai_andreea_L10.Data;
using System.IO;
using Xamarin.Forms;
using Mihai_andreea_Lab10;

namespace Mihai_andreea_L10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());

            MainPage = new MainPage();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
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