using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.vista_modelo
{
    class MainWindowVM : ObservableObject
    {
        ServicioNavegacion servicio;

        public RelayCommand NuevaPersonaCommand { get; }
        public RelayCommand ListaPersonasCommand { get; }

        private UserControl contenidoVista;

        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }
        


        public MainWindowVM()
        {
            servicio = new ServicioNavegacion();
            NuevaPersonaCommand = new RelayCommand(CargarVistaNuevaPersona);
            ListaPersonasCommand = new RelayCommand(CargarVistaListaPersonas);

        }

        private void CargarVistaNuevaPersona()
        {
            ContenidoVista = servicio.CargarVistaNuevaPersona();
        }

        private void CargarVistaListaPersonas()
        {
            ContenidoVista = servicio.CargarVistaListaPersonas();
        }
    }
}