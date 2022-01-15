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
using System.Windows.Shapes;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para WindowAñadirNacionalidad.xaml
    /// </summary>
    public partial class WindowAñadirNacionalidad : Window
    {
        AñadirNacionalidadWindowVM vmNacionalidad;
        public WindowAñadirNacionalidad()
        {
            InitializeComponent();
            vmNacionalidad = new AñadirNacionalidadWindowVM();
            this.DataContext = vmNacionalidad;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
            vmNacionalidad = true;
        }
    }
}
