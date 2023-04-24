using Online_Store_Windows_Forms.controlador;
using System;
using System.Collections;
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
    public partial class ClientVAfegir : Form
    {
        ClientController clientController;
        public ClientVAfegir(object controlador)
        {
            InitializeComponent();
            clientController = (ClientController)controlador;
        }

        private void btEsborrar_Click(object sender, EventArgs e)
        {
            EsborrarDades();
        }
        private void EsborrarDades()
        {
            this.txNom.Text = string.Empty;
            this.txDomi.Text = "";
            this.txNif.Text = string.Empty;
            this.txMail.Text = string.Empty;
            this.rBNo.Checked = false;
            this.rBYes.Checked = false;
        }
        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txNom_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig.Visible = false;
        }
        private void txDomi_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig2.Visible = false;
        }
        private void txNif_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig3.Visible = false;
        }
        private void txMail_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig4.Visible = false;
        }
        private void rBYes_CheckedChanged(object sender, EventArgs e)
        {
            lbCampOblig5.Visible = false;
        }
        private void rBNo_CheckedChanged(object sender, EventArgs e)
        {
            lbCampOblig5.Visible = false;
        }
        private void btAcceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool faltaAlgun = false;
                Hashtable clientHash = new Hashtable();

                if (!this.txNom.Text.Equals(""))
                {
                    string nom = this.txNom.Text;
                    clientHash.Add("nom", nom);
                }
                else
                {
                    this.lbCampOblig.Visible = true;
                    faltaAlgun = true;
                }
                if (!this.txDomi.Text.Equals(""))
                {
                    string domi = this.txDomi.Text;
                    clientHash.Add("domicili", domi);
                }
                else
                {
                    this.lbCampOblig2.Visible = true;
                    faltaAlgun = true;
                }
                if (!this.txNif.Text.Equals(""))
                {
                    string nif = this.txNif.Text;
                    clientHash.Add("nif", nif);
                }
                else
                {
                    this.lbCampOblig3.Visible = true;
                    faltaAlgun = true;
                }
                if (!this.txMail.Text.Equals(""))
                {
                    string mail = this.txMail.Text;
                    clientHash.Add("mail", mail);
                }
                else
                {
                    this.lbCampOblig4.Visible = true;
                    faltaAlgun = true;
                }
                if (this.rBYes.Checked)
                {
                    bool vip = true;
                    clientHash.Add("vip", vip);
                }
                else if (this.rBNo.Checked)
                {
                    bool vip = false;
                    clientHash.Add("vip", vip);
                }
                else
                {
                    this.lbCampOblig5.Visible = true;
                    faltaAlgun = true;
                }
                if (!faltaAlgun)
                {
                    bool existeix = clientController.nouClient(clientHash);


                    if (existeix == true)
                    {
                        MessageBox.Show("El client ja existeix");
                    }
                    else
                    {
                        MessageBox.Show("Client afegit correctament");
                        txNom.Text = "";
                        txDomi.Text = "";
                        txNif.Text = "";
                        txMail.Text = "";
                        rBYes.Checked = false;
                        rBNo.Checked = false;
                    }
                }
            }
            catch { MessageBox.Show("Omple els camps obligatoris"); }
        }

    }
}
