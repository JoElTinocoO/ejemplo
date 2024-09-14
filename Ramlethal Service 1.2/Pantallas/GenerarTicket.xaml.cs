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

namespace Ramlethal_Service_1._2.Pantallas
{
    /// <summary>
    /// Lógica de interacción para GenerarTicket.xaml
    /// </summary>
    public partial class GenerarTicket : Page
    {
        DatosUsuarioSQLDataContext AltaTicket = new DatosUsuarioSQLDataContext();

        public GenerarTicket()
        {
            InitializeComponent();
        }

        private void btnCrearArchivo_Click(object sender, RoutedEventArgs e)
        {
            //Boton para dar de alta el titulo y la descripcion del problema
        }

        private void btnLeerArchivo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtDescripcionProblema_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtFecha_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtTiposPrueba_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
