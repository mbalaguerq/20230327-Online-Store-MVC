using Online_Store_Windows_Forms.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Store_Windows_Forms.vista
{
    public partial class MostrarArticulos : Form
    {
        List<String> articulos;

        public void mostrararticulos()
        {
            this.mostraArticles.DataSource = articulos;
        }

        public MostrarArticulos(List<String> result)
        {
            InitializeComponent();
            articulos = result;
            mostrararticulos();
        }

        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
