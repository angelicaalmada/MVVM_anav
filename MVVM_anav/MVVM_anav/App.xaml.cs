using MVVM_anav.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_anav
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new pagina1();
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
