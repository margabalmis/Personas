using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vista_modelo
{
    class ControlListaPersonasMV : ObservableObject
    {

        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }
        public ControlListaPersonasMV()
        {
            ListaPersonas = new ObservableCollection<Persona>
            {
                new Persona("Ana","32","Española"),
                new Persona("Sophie","22","Francesa"),
                new Persona("Francesca","32","Italiana")
            };
        }
    }
}