using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM_anav
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Alerta();
        }
        private void Alerta()
        {
            DisplayAlert("Alerta", "Esto es un alerta", "Okay");
        }
    }
}
