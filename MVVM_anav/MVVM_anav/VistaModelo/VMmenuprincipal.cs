using MVVM_anav.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_anav.Vistas;

namespace MVVM_anav.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Modelo.Mmenuprincipal> listapaginas { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry,datepicker, picker,label, navegacion",
                    Icono = "https://i.ibb.co/tsBM4xV/psyduck.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a base de datos",
                    Icono = "https://i.ibb.co/wygvCfg/pokebola.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://i.ibb.co/zhg1KT9/pikachu.png"
                }
            };
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if(pagina.Contains("Entry, DataPicker"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("ColectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if (pagina.Contains("Crud Pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        // public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        //public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
