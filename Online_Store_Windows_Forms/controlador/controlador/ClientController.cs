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
        public void afegirClient()//mostra form afegir client
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
        public void mostrarclients()
        {
            List<string> clients = datos.mostrarclients();
            MostrarClients formClients = new MostrarClients(clients);
            formClients.Show();
        }
        public void mostrarClientsStan()
        {
            List<string> clients = datos.mostrarClientsStan();
            MostrarClientsStan formStan = new MostrarClientsStan(clients);
            formStan.Show();
        }
        public void mostrarClientsVip()
        {
            List<string> clients = datos.mostrarClientsVip();
            MostrarClientsVip formVip = new MostrarClientsVip(clients);
            formVip.Show();
        }
    }
}
