using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vista_modelo
{
    class ControlNuevaPersonaMV : ObservableObject
    {
        private ServicioNavegacion servicio;
        public RelayCommand VentanaAñadirNacionalidad { get; }
        public RelayCommand AñadirPersona { get; }

        public ControlNuevaPersonaMV()
        {
            servicio = new ServicioNavegacion();
            VentanaAñadirNacionalidad = new RelayCommand(AñadirNacionalidad);
            AñadirPersona = new RelayCommand(AddPerson);
            Nacionalidades = new ObservableCollection<string> { "Española", "Italiana", "Portuguesa", "Francesa" };
        }

        private void AddPerson()
        {
            Persona p = new Persona(Nombre, Edad, Nacionalidad);

            //añadir a la lista
            Nombre = "";
            Edad = "";
            Nacionalidad = "";
        }

        private ObservableCollection<string> nacionalidades;

        public ObservableCollection<string> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad , value); }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private string edad;

        public string Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }
        
        public void AñadirNacionalidad() 
        {
            servicio.CargarDialogoNacionalidad();
        }

    }
}