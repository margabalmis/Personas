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
        internal UserControl CargarVistaNuevaPersona()
        {
            return new NuevaPersonaUC();
        }

        internal UserControl CargarVistaListaPersonas()
        {
            return new ListadoPersonasUC();
        }
    }
}

