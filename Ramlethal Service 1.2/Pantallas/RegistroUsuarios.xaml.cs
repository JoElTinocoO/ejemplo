using System.Windows;
using System.Windows.Controls;

namespace Ramlethal_Service_1._2.Pantallas
{
    /// <summary>
    /// Lógica de interacción para RegistroUsuarios.xaml
    /// </summary>
    public partial class RegistroUsuarios : Window
    {
        DatosUsuarioSQLDataContext Usuariosregistro = new DatosUsuarioSQLDataContext();
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Bnt_regresomenuregistro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Pantallainicio = new MainWindow();
            this.Hide();
            Pantallainicio.Show();
        }

        private void btn_registrousuario_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_registronombre.Text) &&
                !string.IsNullOrEmpty(tbx_registrocorreo.Text) &&
                !string.IsNullOrEmpty(tbx_confirmarcontrasena.Text))
            {
                Usuarios registro_usuario = new Usuarios();
                registro_usuario.Nombre = tbx_registronombre.Text;
                registro_usuario.Correo = tbx_registrocorreo.Text;
                registro_usuario.Contraseña = tbx_confirmarcontrasena.Text;
                Usuariosregistro.Usuarios.InsertOnSubmit(registro_usuario);
                Usuariosregistro.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
