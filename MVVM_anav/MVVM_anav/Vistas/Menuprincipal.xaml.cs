using MVVM_anav.Modelo;
using MVVM_anav.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_anav.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menuprincipal : ContentPage
	{
		public Menuprincipal()
		{
            InitializeComponent();
			BindingContext = new VMmenuprincipal(Navigation);
        }
            
    }
}
