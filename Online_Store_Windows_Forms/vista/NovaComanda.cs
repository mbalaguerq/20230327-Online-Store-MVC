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
    public partial class NovaComanda : Form
    {
        ComandaController comandaController;
        public NovaComanda(object controlador)
        {
            InitializeComponent();
            comandaController = (ComandaController)controlador;
        }
        private void NovaComanda_Load(object sender, EventArgs e)
        {
            int nouN = comandaController.nouNComanda();
            this.txNComanda.Text = nouN.ToString();
            this.textdata.Text = DateTime.Now.ToShortDateString();
        }
        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btEsborrar_Click(object sender, EventArgs e)
        {
            this.txArticle.Text = "";
            this.txunitats.Text = "";
            this.txNifClient.Text = "";
            this.lbMostraR.Items.Clear();

        }
        private void txArticle_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig3.Visible = false;

        }
        private void txunitats_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig2.Visible = false;
        }
        private void txNifClient_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig.Visible = false;
        }
        private void btBuscarArticle_Click(object sender, EventArgs e)
        {
            if (!txArticle.Text.Equals(""))
            {
                List<String> articleTrobat = comandaController.getArticleBycodi(this.txArticle.Text.ToLower());

                //COUNT ENS CONTROLA QUANTS ELEMENTS RETORNEN AMB AQUEST LIST
                if (articleTrobat.Count() == 0)
                {
                    MessageBox.Show("No hi ha cap article amb aquest codi");
                    txArticle.Text = "";
                }
                else
                {
                    this.txArticle.Text = articleTrobat[0];
                    foreach (String s in articleTrobat)
                    {
                        this.lbMostraR.Items.Add(s);
                    }
                }
            }
            else { lbCampOblig3.Visible = true; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!txNifClient.Text.Equals(""))
            {
                List<String> clientTrobat = comandaController.getClientByNif(this.txNifClient.Text.ToUpper());

                if (clientTrobat.Count() == 0)
                {
                    MessageBox.Show("No hi ha cap Client amb aquest Nif");
                    txNifClient.Text = "";
                }
                else
                {
                    this.txNifClient.Text = clientTrobat[0];
                    foreach (String s in clientTrobat)
                    {
                        this.lbMostraR.Items.Add(s);
                    }
                }
            }
            else { lbCampOblig.Visible = true; }
        }
        private void selData_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateSelected = selData.Value;

            if (dateSelected < DateTime.Now)
            {
                MessageBox.Show("La data no pot ser inferior a la data actual");
            }
            else
            {
                int disponible;
                disponible =comandaController.ComprovaDataEntrega(dateSelected);

                if(disponible > 4)
                {
                    MessageBox.Show("Data no disponible, seleccioni una altre data");

                }

            }
        }


        private void btAcceptar_Click(object sender, EventArgs e)
        {
            if (!txunitats.Text.Equals(""))
            {
                int quantitat = int.Parse(txunitats.Text);
                string codi = txArticle.Text.ToLower();

                List<string> preuFinal = new List<string>();

                preuFinal = comandaController.getPreuByUnitats(quantitat, codi);
                foreach (String s in preuFinal)
                {
                    this.lbMostraR.Items.Add(s);
                }
                comandaController.creaComanda(txNComanda.Text, txunitats.Text, textdata.Text,
                                              txNifClient.Text, txArticle.Text, selData.Value);


            }
            else
            { lbCampOblig2.Visible = true; }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
    }
}
