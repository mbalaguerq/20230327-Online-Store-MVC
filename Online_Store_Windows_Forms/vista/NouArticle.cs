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
    public partial class NouArticle : Form
    {
        ArticleController articleController;
        public NouArticle(object controlador)
        {
            InitializeComponent();
            articleController = (ArticleController)controlador;
        }
        //BOTONS
        private void btEsborrar_Click(object sender, EventArgs e)
        {
            EsborrarDades();
        }
        private void EsborrarDades()
        {
            this.txCodi.Text = string.Empty;
            this.txPreu.Text = "";
            this.txDescrip.Text = string.Empty;
        }
        private void btTancar_Click(object sender, EventArgs e)
        {
            //El mètode dispose, elimina l'objecte. Amb això, tanquem el form.
            //provar this.close
            this.Dispose();
        }
        private void btAcceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Hashtable articleHash = new Hashtable();
                bool faltaAlgun = false;

                if (!this.txCodi.Text.Equals(""))
                {
                    string codi = this.txCodi.Text;
                    articleHash.Add("codi", codi);
                }
                else
                {
                    this.lbCampOblig.Visible = true;
                    faltaAlgun = true;
                }

                if (!this.txDescrip.Text.Equals(""))
                {
                    string descripcio = this.txDescrip.Text;
                    articleHash.Add("descripcio", descripcio);
                }
                else
                {
                    this.lbCampOblig2.Visible = true;
                    faltaAlgun = true;
                }

                if (!this.txPreu.Text.Equals(""))
                {
                    decimal preu = decimal.Parse(this.txPreu.Text);
                    articleHash.Add("preu", preu);
                }
                else
                {
                    this.lbCampOblig3.Visible = true;
                    faltaAlgun = true;
                }

                if (faltaAlgun == false)
                {
                    bool existeix = articleController.nouArticle(articleHash);

                    if (existeix == true)
                    {
                        MessageBox.Show("l'Article ja existeix");
                    }
                    else
                    {
                        MessageBox.Show("Article afegit correctament");
                        txCodi.Text = "";
                        txPreu.Text = "";
                        txDescrip.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S'ha produit un error: " + ex.Message);
            }
        }
        //EVENTS
        private void txDescrip_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig3.Visible = false;
        }
        private void txPreu_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig2.Visible = false;
        }
        private void txCodi_TextChanged(object sender, EventArgs e)
        {
            lbCampOblig.Visible = false;
        }

    }
}
