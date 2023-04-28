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
    public partial class EliminarComanda : Form
    {
        ComandaController comandaController;
        public EliminarComanda(object controlador)
        {
            InitializeComponent();
            comandaController = (ComandaController)controlador;
        }
        private void EliminarComanda_Load(object sender, EventArgs e)
        {
            lblNumComanda.Visible = false;
            lblNifClient.Visible = false;
            txtNifoComanda.Visible = false;
            btBuscar.Visible = false;
        }
        private void rBComanda_CheckedChanged(object sender, EventArgs e)
        {
            lblNifClient.Visible = false;
            lblNumComanda.Visible = true;
            txtNifoComanda.Visible = true;
            btBuscar.Visible = true;
        }
        private void rBNifClient_CheckedChanged(object sender, EventArgs e)
        {
            lblNumComanda.Visible = false;
            lblNifClient.Visible = true;
            txtNifoComanda.Visible = true;
            btBuscar.Visible = true;
        }
        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btEsborrar_Click(object sender, EventArgs e)
        {
            txtNifoComanda.Text = "";
            listBoxResultats.Items.Clear();
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (rBComanda.Checked)
            {
                if (!txtNifoComanda.Text.Equals("") && !txtNifoComanda.Text.Contains("0123456789"))
                {
                    List<string> comTrobada = new List<string>();
                    comTrobada = comandaController.esborrarComanda(txtNifoComanda.Text);
                    if (comTrobada.Count() == 0)
                    {
                        MessageBox.Show("No hi ha cap Comanda amb aquest número");
                        txtNifoComanda.Text = "";
                    }
                    else
                    {
                        foreach (String s in comTrobada)
                        {
                            this.listBoxResultats.Items.Add(s);
                        }
                    }
                }
                else if (!txtNifoComanda.Equals("") && !txtNifoComanda.Text.Contains("0123456789"))
                {
                    MessageBox.Show("El Nºde comanda només pot contenir números");
                }
                else
                {
                    MessageBox.Show("Introdueix el Nºde Comanda");
                }
            }
        }
    }
}
