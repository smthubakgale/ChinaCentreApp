using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ChinaCentre.Views.Shared;

namespace ChinaCentre
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new _Layout();
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
