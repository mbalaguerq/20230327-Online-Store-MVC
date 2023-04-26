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



namespace Online_Store_Windows_Forms
{
    public partial class MenuPrincipal : Form
    {       
        ProgController controller;
        public MenuPrincipal(object controlador)
        {
            controller = (ProgController)controlador;
            InitializeComponent();            
        }

        private void BtGArticles_Click(object sender, EventArgs e)
        {
            controller.menuArticles();
            //this.Visible = false;
        }
        private void BtGClients_Click(object sender, EventArgs e)
        {
            controller.menuClients();
        }

        private void BtGComandes_Click(object sender, EventArgs e)
        {
            controller.menuComandes();
        }
    }
}

