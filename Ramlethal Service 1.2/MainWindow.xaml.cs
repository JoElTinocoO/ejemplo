using Ramlethal_Service_1._2.Pantallas;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ramlethal_Service_1._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DatosUsuarioSQLDataContext datausuarios = new DatosUsuarioSQLDataContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            var validarcontrasena = from validar in datausuarios.Usuarios
                                    where validar.Nombre == tbx_Nombreusuarioinicio.Text
                                    && validar.Contraseña == Contrasenainicio.Text
                                    select validar;

            if (validarcontrasena.Any())
            {
                var usuario = validarcontrasena.First();
                bool esAdministrador = usuario.Administrador;

                if (usuario.Administrador)
                {
                    MessageBox.Show("Acceso Otorgado como Administrador");


                    MenuPrincipal pantallamenu = new MenuPrincipal();
                    this.Close();
                    pantallamenu.Show();
                }
                else
                {
                    MessageBox.Show("Acceso Otorgado como Usuario");

                    MenuPrincipal pantallamenu = new MenuPrincipal();
                    this.Close();
                    pantallamenu.Show();
                }
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas", "Verifica las credenciales");
            }
        }

        private void PantallaInicio()
        {
            this.Hide();
            MenuPrincipal Pantallamenu1 = new MenuPrincipal();
            Pantallamenu1.Show();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegistroUsuarios pantallaregistro = new RegistroUsuarios();
            pantallaregistro.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Boton de olvidaste tu contraseña
        }

        private void tbx_Nombreusuarioinicio_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}