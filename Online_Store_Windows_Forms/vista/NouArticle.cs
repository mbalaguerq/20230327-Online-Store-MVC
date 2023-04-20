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
        public NouArticle()
        {
            InitializeComponent();
        }

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
            this.Dispose();
        }

        private void btAcceptar_Click(object sender, EventArgs e)
        {
            Hashtable articleHash = new Hashtable();

            if (!this.txCodi.Text.Equals(""))
            {
                string codi = this.txCodi.Text;
                articleHash.Add("codi", codi);
            }
            else
            {
                this.lbCampOblig.Visible = true;
            }
            if(!this.txdescrip.Text.Equals(""))
                string descripcio = this.txDescrip.Text;
            articleHash.Add("descripcio", descripcio);

            decimal preu = decimal.Parse(this.txPreu.Text);
            articleHash.Add("preu", preu);
        }
    }
}
