using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store_Windows_Forms.modelo
{
    internal class OnlineStore
    {
        List<Article> articles;
        List<Client> clients;
        List<Comanda> comandes;

        public OnlineStore()
        {
            articles = new List<Article>();
            clients = new List<Client>();
            comandes = new List<Comanda>();
        }

       
    }
}
