﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_anav.Modelo;
using MVVM_anav.Datos;
using System.ComponentModel;
using MVVM_anav.Helpers.Validators;
using Xamarin.Essentials;
using MVVM_anav.Helpers.Validators.Rules;

namespace MVVM_anav.VistaModelo.VMpokemon
{
    public class VMregistropokemon: BaseViewModel, INotifyPropertyChanged
    {
        public ValidatableObject<string> Nombre { get; set; } = new ValidatableObject<string>();
        public void AddValidationRules()
        {
            Nombre.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "First Name Required" });
         
        }

        bool AreFieldsValid()
        {
            bool isNombreValid = Nombre.Validate();
        

            return isNombreValid;
        }


        #region VARIABLES
        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;
        #endregion
        #region CONSTRUCTOR
        public VMregistropokemon(INavigation navigation)
        {
            Navigation = navigation;
            AddValidationRules();
        }
        #endregion
        #region OBJETOS
        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }
        public string Txtcolorpoder
        {
            get { return _Txtcolorpoder; }
            set { SetValue(ref _Txtcolorpoder, value); }
        }
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }
        public string Txtnro
        {
            get { return _Txtnro; }
            set { SetValue(ref _Txtnro, value); }
        }
        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { SetValue(ref _Txtpoder, value); }
        }
        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Insertar()
        {
            var funcion = new Dpokemon();
            var parametros = new Mpokemon();
            parametros.Colorfondo = Txtcolorfondo;
            parametros.Colorpoder = Txtcolorpoder;
            parametros.Icono = Txticono;
            parametros.Nombre = Txtnombre;
            parametros.NroOrden = Txtnro;
            parametros.Poder = Txtpoder;

            await funcion.Insertarpokemon(parametros);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        //public ICommand Insertarcommand => new Command(async () => await Insertar());

        public ICommand Insertarcommand => new Command(async () =>
        {
            if (AreFieldsValid())
            {
                await Insertar();
                //await App.Current.MainPage.DisplayAlert("Welcome", "", "Ok");
            }
          
        });




        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}