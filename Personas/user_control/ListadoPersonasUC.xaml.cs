using Personas.vista_modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas.user_control
{
    /// <summary>
    /// Lógica de interacción para ListadoPersonas.xaml
    /// </summary>
    public partial class ListadoPersonasUC : UserControl
    {
        ControlListaPersonasMV vmListaPersonas;
        public ListadoPersonasUC()
        {
            InitializeComponent();
            vmListaPersonas = new ControlListaPersonasMV();
            this.DataContext = vmListaPersonas;
        }
    }
}
