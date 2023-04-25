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
    public partial class MostrarClients : Form
    {
        List<string> clients;
        public void mostrarClients()
        {
            //tbMostrar clientes el es textbox on s'han de mostrar
            this.tbMostrarClients.DataSource = clients;
        }
        public MostrarClients(List<String>result)
        {
            InitializeComponent();
            clients = result;
            mostrarClients();
        }                
        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
