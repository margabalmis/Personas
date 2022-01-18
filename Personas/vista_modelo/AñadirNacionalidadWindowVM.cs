using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vista_modelo
{
    class AñadirNacionalidadWindowVM : ObservableRecipient
    {

        public AñadirNacionalidadWindowVM()
        { 
            
        
        }


        private ServicioNavegacion servicio;

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
            set { nacionalidad = value; }
        }
        public void GuardarNacionalidad()
        {
            Nacionalidades.Add(Nacionalidad);
        }
    }
}
