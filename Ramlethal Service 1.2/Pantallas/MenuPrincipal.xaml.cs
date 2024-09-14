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

namespace Ramlethal_Service_1._2.Pantallas
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Boton de cierre de sesion
            foreach (Window window in Application.Current.Windows.OfType<Window>().ToList())
            {
                if (window != this)
                {
                    window.Close();
                }
            }

            MainWindow inicioSesion = new MainWindow();
            inicioSesion.Show();

            // Cerrar la ventana actual
            this.Close();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Levantar ticket
            GenerarTicket Pantallalevanto = new GenerarTicket();
            Frame_App.Navigate(Pantallalevanto);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Bnt gestor de los tickets
            TicketsGestion pantallagestion = new TicketsGestion();
            Frame_App.Navigate(pantallagestion);


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string usuarioNombre = "nombreDelUsuario";


            //Pantalla de configuracion
            Configuracion PantallaConfiguracion = new Configuracion(usuarioNombre);
            Frame_App.Navigate(PantallaConfiguracion);
        }
    }
}
