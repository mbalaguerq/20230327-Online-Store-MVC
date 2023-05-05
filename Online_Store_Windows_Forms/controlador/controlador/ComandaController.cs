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
        public void eliminarComanda()
        {
            EliminarComanda formEliminar = new EliminarComanda(this);
            formEliminar.Show();
        }
        public int nouNComanda()
        {
            int nComanda = datos.nouNComanda();
            return nComanda;
        }
        public List<string> getArticleBycodi(string codi)
        {
            List<string> list = new List<string>();
            list = datos.getArticleBycodi(codi);
            return list;
        }
        public List<string> getClientByNif(string nif)
        {
            List<string> list = new List<string>();
            list = datos.getClientByNif(nif);
            return list;
        }
        public List<string> getPreuByUnitats(int quantitat, string codi)
        {
            List<string> list = new List<string>();
            list = datos.getPreuByUnitats(quantitat, codi);
            return list;
        }
        public void creaComanda(string txNComanda, string txunitats, string textdata,
                                string txNifClient, string txArticle)
        {
            datos.creaComanda(txNComanda, txunitats, textdata, txNifClient, txArticle);
        }
        public List<string> buscarComandaByNif(string txtNifoComanda)
        {
            List<string> list = new List<string>();

            list = datos.buscarComandaByNif(txtNifoComanda);
            return list;
        }
        public List<string> buscarComandabyNcom(string txtNifoComanda)
        {
            List<string> list = new List<string>();

            list = datos.buscarComandabyNcom(txtNifoComanda);
            return list;
        }
        public void eliminaComandaByNif(string txtNifoComanda)
        {
            datos.eliminaComandaByNif(txtNifoComanda);
        }
        public void eliminaComandaByCom(string nComanda)
        {
            datos.eliminaComandaByCom(nComanda);
        }

    }
}
