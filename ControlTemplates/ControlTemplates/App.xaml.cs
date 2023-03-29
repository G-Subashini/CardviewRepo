using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControlTemplates.View;

namespace ControlTemplates
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CardPage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

