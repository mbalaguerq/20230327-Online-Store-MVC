using Online_Store_Windows_Forms.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Store_Windows_Forms.vista
{
    public partial class MostrarClientsStan : Form
    {
        List<string> clients;
        public void mostrarClientsStan()
        {
            //tbMostrar clientes el es textbox on s'han de mostrar
            //this.tbMostrarClientsVip.DataSource = clients;
            foreach(String s in clients)
            {
                this.tbMostrarClientsVip.Items.Add(s);
            }
        }

        public MostrarClientsStan(List<String> result)
        {
            InitializeComponent();
            clients = result;
            mostrarClientsStan();

        }
        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
