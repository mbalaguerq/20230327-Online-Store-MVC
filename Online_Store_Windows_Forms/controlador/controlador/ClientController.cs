using Online_Store_Windows_Forms.vista;
using Online_Store_Windows_Forms.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Store_Windows_Forms;
using System.Collections;

namespace Online_Store_Windows_Forms.controlador
{
    internal class ClientController
    {
        OnlineStore datos;

        public ClientController(OnlineStore pdatos)
        {
            this.datos = pdatos;
        }
        public void afegirClient()//mostra from afegir client
        {
            ClientVAfegir formafegir = new ClientVAfegir(this);
            formafegir.Show();

        }
        public bool nouClient(Hashtable clientHash)
        {
            bool existeix = false;
            existeix= datos.nouClient(clientHash);
            return existeix;//ens retorna si el client s'ha afegit o ja existia
        }
        
    }
}
