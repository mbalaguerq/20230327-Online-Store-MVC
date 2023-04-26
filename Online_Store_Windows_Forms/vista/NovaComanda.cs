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
        
        private void btBuscarArticle_Click(object sender, EventArgs e)
        {
            List<String> articleTrobat = comandaController.getArticleBycodi(this.txArticle.Text);

            //COUNT ENS CONTROLA QUANTS ELEMENTS RETORNEN AMB AQUEST LIST
            if (articleTrobat.Count() == 0)
            {
                MessageBox.Show("No hi ha cap article amb aquest codi");
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
        private void txArticle_TextChanged(object sender, EventArgs e)
        {


        }

    }

}
