using System;
using Week5_input.Services;
using Week5_input.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week5_input
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Jokenpo();
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
