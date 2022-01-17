using Personas.user_control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        static ListadoPersonasUC listaPersonas = new ListadoPersonasUC();
        internal UserControl CargarVistaNuevaPersona()
        {
            return new NuevaPersonaUC();
        }

        internal UserControl CargarVistaListaPersonas()
        {
            return listaPersonas;
        }
        internal void CargarDialogoNacionalidad()
        {
            WindowAñadirNacionalidad nuevaVentana = new WindowAñadirNacionalidad();
            nuevaVentana.ShowDialog();
        }
    }
}

