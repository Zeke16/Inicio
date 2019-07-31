using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Inicio.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Inicio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IndexMainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
