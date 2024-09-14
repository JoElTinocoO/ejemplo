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
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Page
    {
        DatosUsuarioSQLDataContext UsuariosSQL = new DatosUsuarioSQLDataContext();
        private string NombreUsuario;
        public Configuracion( string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
        }
        private void CargarDatosUsuario()
        {
            var usuario = UsuariosSQL.Usuarios.SingleOrDefault(u => u.Nombre == NombreUsuario);
            if (usuario != null)
            {
                tbx_consultardatorol.Text = usuario.Nombre;
                tbx_consultardatorol1.Text = usuario.Administrador ? "Administrador" : "Usuario";
            }
        }
        private void Btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            string Codigoadmin = "Kawamas123";

            if (tbx_haceradmin.Text == Codigoadmin)
            {
                try
                {
                    var usuario = UsuariosSQL.Usuarios.SingleOrDefault(u => u.Nombre == NombreUsuario);

                    if (usuario != null)
                    {
                        usuario.Administrador = true;


                        UsuariosSQL.SubmitChanges();

                        MessageBox.Show("Ahora eres administrador.");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los cambios: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Código de promoción incorrecto.");
            }
        }
        private void Btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbx_consultardatorol_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbx_consultardatorol.Text = NombreUsuario;
        }
    }
}
