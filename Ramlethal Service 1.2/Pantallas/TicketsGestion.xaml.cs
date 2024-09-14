using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para TicketsGestion.xaml
    /// </summary>
    public partial class TicketsGestion : Page
    {

      DatosUsuarioSQLDataContext DatosTickets = new DatosUsuarioSQLDataContext();
        public TicketsGestion()
        {
            InitializeComponent();
            var consulta = from ConsultaTicketsAD in DatosTickets.Tickets select ConsultaTicketsAD;
            Datagridtickets.ItemsSource = consulta;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long ticketId;
            if (long.TryParse(Tbx_busquedaTicket.Text, out ticketId))
            {
                var ConsultarID = from ticket in DatosTickets.Tickets
                                  where ticket.Id_ticket == ticketId
                                  select ticket;
                Datagridtickets.ItemsSource = ConsultarID.ToList();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID de ticket válido.", "Error de Entrada", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tbx_busqudaticket_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
