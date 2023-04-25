using Online_Store_Windows_Forms.controlador;
using Online_Store_Windows_Forms.modelo;
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
    public partial class MostrarClientsVip : Form
    {
        List<string> clients;
        public void mostrarClientsVip()
        {
            //tbMostrar clientes el es textbox on s'han de mostrar
            this.tbMostrarClientsVip.DataSource = clients;
        }
        public MostrarClientsVip(List<String> result)
        {
            InitializeComponent();
            clients = result;
            mostrarClientsVip();
        }
        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

