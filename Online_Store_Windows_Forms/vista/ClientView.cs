using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Store_Windows_Forms.controlador;

namespace Online_Store_Windows_Forms.vista
{
    public partial class ClientView : Form
    {
        ClientController clientController;
        public ClientView(object controlador)
        {
            InitializeComponent();
            clientController = (ClientController) controlador;
        }

        private void BtafegirClients_Click(object sender, EventArgs e)
        {
            clientController.afegirClient();
        }

        private void BtmostrarClients_Click(object sender, EventArgs e)
        {
            clientController.mostrarclients();
        }

        private void BtmostrarCliStandard_Click(object sender, EventArgs e)
        {
            clientController.mostrarClientsStan();
        }

        private void BtmenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtmostrarCliVip_Click(object sender, EventArgs e)
        {
            clientController.mostrarClientsVip();
        }
    }
}
