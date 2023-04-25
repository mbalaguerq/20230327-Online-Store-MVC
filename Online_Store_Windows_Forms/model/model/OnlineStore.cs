using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting;
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
        public void cargarDatos()
        {
            Article article1 = new Article();
            article1.Descripcio = "Palo";
            article1.Pvp = 1;
            article1.Codi = "pal*3114";
            articles.Add(article1);

            Article article2 = new Article();
            article2.Descripcio = "Palo Selfie";
            article2.Pvp = 2;
            article2.Codi = "pal*5467";
            articles.Add(article2);

            Article article3 = new Article();
            article3.Descripcio = "Raqueta";
            article3.Pvp = 6;
            article3.Codi = "raq*3784";
            articles.Add(article3);

            Client cli1 = new Client();
            cli1.Nom = "Marc Balaguer";
            cli1.Domicili = "Plaça Catalunya nº 4 08001 BCN";
            cli1.Nif = "46712725R";
            cli1.Email = "notinctemps7@hotmail.com";
            cli1.Vip = true;
            clients.Add(cli1);

            Client cli2 = new Client();
            cli2.Nom = "Marc Platero";
            cli2.Domicili = "Plaça València nº 8 08009 BCN";
            cli2.Nif = "46709712S";
            cli2.Email = "notincvida14@hotmail.com";
            cli2.Vip = false;
            clients.Add(cli2);
        }

        public List<string> mostrarArticulos()
        {
            List<string> result = new List<string>();

            foreach (Article article in articles)
            {
                result.Add("ARTICLE: ");
                result.Add("Codi: " + article.Codi);
                result.Add("Descripció:"  + article.Descripcio);
                result.Add("Preu: " + article.Pvp + "Euros");
                result.Add("");
            }
            return result;           
        }
        public List<string> mostrarclients()
        {
            List<string> result = new List<string>();

            foreach (Client client in clients)
            {
                if(client.Vip==true)
                {
                    result.Add("CLIENT VIP:");
                }
                result.Add("NOM: " + client.Nom);
                result.Add("NIF: " +  client.Nif);
                result.Add("ADREÇA: " + client.Domicili); 
                result.Add("E-MAIL: " + client.Email);
                result.Add("");
            }
            return result;
        }  
        public List<string> mostrarClientsStan()
        {
            List<string> result = new List<string>();

            foreach (Client client in clients)
            {
                if (client.Vip == false)
                {
                    result.Add("CLIENT STANDAR:");
                    result.Add("NOM: " + client.Nom);
                    result.Add("NIF: " + client.Nif);
                    result.Add("ADREÇA: " + client.Domicili);
                    result.Add("E-MAIL: " + client.Email);
                    result.Add("");
                }
            }
            return result;
        }
        public List<string> mostrarClientsVip()
        {
            List<string> result = new List<string>();

            foreach (Client client in clients)
            {
                if (client.Vip == true)
                {
                    result.Add("CLIENT VIP:");
                    result.Add("NOM: " + client.Nom);
                    result.Add("NIF: " + client.Nif);
                    result.Add("ADREÇA: " + client.Domicili);
                    result.Add("E-MAIL: " + client.Email);
                    result.Add("");
                }
            }
            return result;
        }
        public bool nouArticle(Hashtable articleHash)
        {
            // if (articleHash.Count == 0 ) 
            // { return true;//si el hashtable arriba buit}

            bool existeix = false;
            foreach (Article article in articles)
            {
                if (article.Codi.Equals(articleHash["codi"]))
                {
                    return true;
                }
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
            bool existeix=false;

            foreach (Client client in clients)
            {
                if (client.Nif.Equals(clientHash["nif"]))
                {
                    existeix= true;
                }
                else
                {
                    Client cli = new Client();
                    cli.Nif = (string)clientHash["nif"];
                    cli.Nom = (string)clientHash["nom"];
                    cli.Domicili = (string)clientHash["domicili"];
                    cli.Email = (string)clientHash["mail"];
                    cli.Vip = (bool)clientHash["vip"];
                    clients.Add(cli);
                    existeix= false;
                    return existeix;
                }
            }
            return existeix;
        }


    }
}

