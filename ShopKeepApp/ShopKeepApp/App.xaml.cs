using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopKeepApp
{
    public partial class App : Application
    {
        public static string dbLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        public App(string dblocation)
        {
            InitializeComponent();

            MainPage = new MainPage();
            dbLocation = dblocation;

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
