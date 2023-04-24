using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
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
        public List<String> mostrarArticulos()
        {
            List<String> result = new List<String>();

            foreach (Article article in articles)
            {
                result.Add(article.ToString());
            }
            return result;
        }
        public void cargarDatos()
        {
            Article article1 = new Article();
            article1.Descripcio = "Palo";
            article1.Pvp = 1;
            article1.Codi = "pal*3114";
            articles.Add(article1);
        }
        public bool nouArticle(Hashtable articleHash)
        {
            if (articleHash.Count == 0 ) { 
                return true;
            }
            bool existeix = false;
            foreach (Article article in articles)
            {
                if (article.Codi.Equals(articleHash["codi"]))
                {
                    existeix = true;
                    //En un foreach, si hi ha una modificació del "list" de 
                    //objectes, s'ha de fer un return dins. Sino dona error.
                    return true;
                }
                else { return true; }
            }
            if (!existeix)
            {
                Article art = new Article();
                art.Descripcio = (string)articleHash["descripcio"];
                art.Codi = (string)articleHash["codi"];
                art.Pvp = (decimal)articleHash["preu"];
                articles.Add(art);
                //En un foreach, si hi ha una modificació del "list" de 
                //objectes, s'ha de fer un return dins. Sino dona error.
                return false;

            }
            return existeix;
        }
        public bool nouClient(Hashtable clientHash)
        {
            bool existeix = true;

            foreach (Client client in clients)
            {
                if (!client.Nif.Equals(clientHash["nif"]))
                {
                    Client cli = new Client();
                    cli.Nif = (string)clientHash["nif"];
                    cli.Nom = (string)clientHash["nom"];
                    cli.Domicili = (string)clientHash["domicili"];
                    cli.Email = (string)clientHash["mail"];
                    cli.Vip = (bool)clientHash["vip"];
                    clients.Add(client);
                    return false;
                }
                else { return true; }
            }
            return existeix;
        }
    }
}

