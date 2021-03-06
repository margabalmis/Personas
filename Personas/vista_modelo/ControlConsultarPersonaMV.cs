using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vista_modelo
{
    class ControlConsultarPersonaMV : ObservableRecipient
    {

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
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


        public ControlConsultarPersonaMV()
        { 
        
        
        }

    }
}