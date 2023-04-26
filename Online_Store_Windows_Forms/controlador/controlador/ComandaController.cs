using Online_Store_Windows_Forms.vista;
using Online_Store_Windows_Forms.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Store_Windows_Forms;

namespace Online_Store_Windows_Forms.controlador
{
    internal class ComandaController
    {
        OnlineStore datos;

        public ComandaController(OnlineStore pdatos)
        {
            this.datos = pdatos;
        }
        public void novaComanda()
        {
            NovaComanda novaComanda = new NovaComanda(this);
            novaComanda.Show();            
        }
        public int nouNComanda()
        {
            int nComanda = datos.nouNComanda();
            return nComanda;
        }
        public List<string> getArticleBycodi(string codi)
        {
            List<string> list = new List<string>();
            list=datos.getArticleBycodi(codi);
            return list;
        }

    }
}
