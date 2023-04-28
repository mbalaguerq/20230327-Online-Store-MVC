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
        private static int _contador = 500;


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

            Comanda comanda1 = new Comanda();
            comanda1.NComanda = 499;
            comanda1.DataAvui = DateTime.Parse("01/01/2023");
            comanda1.Unitats = 6;
            comanda1.Article = article3;
            comanda1.Client = cli1;
            comandes.Add(comanda1);

            Comanda comanda2 = new Comanda();
            comanda2.NComanda = 498;
            comanda2.DataAvui = DateTime.Parse("12/04/2023");
            comanda2.Unitats = 1;
            comanda2.Article = article1;
            comanda2.Client = cli2;
            comandes.Add(comanda2);



        }

        public List<string> mostrarArticulos()
        {
            List<string> result = new List<string>();

            foreach (Article article in articles)
            {
                result.Add("ARTICLE: ");
                result.Add("Codi: " + article.Codi);
                result.Add("Descripció:" + article.Descripcio);
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
                if (client.Vip == true)
                {
                    result.Add("CLIENT VIP:");
                }
                result.Add("NOM: " + client.Nom);
                result.Add("NIF: " + client.Nif);
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
            bool existeix = false;

            foreach (Client client in clients)
            {
                if (client.Nif.Equals(clientHash["nif"]))
                {
                    existeix = true;
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
                    existeix = false;
                    return existeix;
                }
            }
            return existeix;
        }
        public int nouNComanda()
        {
            _contador++;
            return _contador;
        }
        public List<string> getArticleBycodi(string codi)
        {
            List<string> list = new List<string>();
            foreach (Article arti in articles)
            {
                if (arti.Codi.Equals(codi))
                {
                    list.Add(arti.Codi);
                    list.Add(arti.Descripcio);
                    list.Add(arti.Pvp.ToString());
                    list.Add("");
                    return list;
                }
            }
            return list;
        }
        public List<string> getClientByNif(string nif)
        {
            List<string> list = new List<string>();

            foreach (Client cli in clients)
            {
                if (cli.Nif.Equals(nif))
                {
                    list.Add(cli.Nif);
                    list.Add(cli.Nom);
                    list.Add(cli.Domicili);
                    list.Add(cli.Email);
                    list.Add("");
                    return list;
                }
            }
            return list;
        }
        public List<string> getPreuByUnitats(int quantitat, string codi)
        {
            List<string> list = new List<string>();
            foreach (Article arti in articles)
            {
                if (arti.Codi.Equals(codi))
                {
                    decimal preuTotal;
                    preuTotal = arti.Pvp * quantitat;

                    list.Add("Preu x unitat" + arti.Pvp.ToString());
                    list.Add("Unitats: " + quantitat.ToString());
                    list.Add("Preu Total: " + preuTotal.ToString());
                    return list;
                }
            }
            return list;
        }
        public void creaComanda(string txNComanda, string txunitats, string textdata,
                                   string txNifClient, string txArticle)
        {
            Comanda novaComanda = new Comanda();
            novaComanda.NComanda = int.Parse(txNComanda);
            novaComanda.Unitats = int.Parse(txunitats);
            novaComanda.DataAvui = DateTime.Parse(textdata);

            foreach (Article arti in articles)
                if (arti.Codi == txArticle)
                {
                    novaComanda.Article = arti;
                }
            foreach (Client client in clients)
            {
                if (client.Nif.Equals(txNifClient))
                {
                    novaComanda.Client = client;
                }
            }
            comandes.Add(novaComanda);
        }
        public List<string> esborrarComanda(string txtNifoComanda)
        {
            List<string> list = new List<string>();

            foreach (Comanda comanda in comandes)
            {//corregir això. fer dos mètodes
                if (comanda.NComanda.Equals(txtNifoComanda) || comanda.Client.Nif.Equals(txtNifoComanda))
                {
                    list.Add("Comanda " + comanda.NComanda);
                    list.Add("Client: " + comanda.Client.Nom);
                    list.Add("Nif: " + comanda.Client.Nif);
                    list.Add("Adreça: " + comanda.Client.Domicili);
                    list.Add("Article: " + comanda.Article.Descripcio);
                    list.Add("Unitats: " + comanda.Unitats.ToString());
                    list.Add("Preu/Unitat: " + comanda.Article.Pvp.ToString());
                    list.Add("Preu Total: " + (comanda.Article.Pvp * comanda.Unitats).ToString() + "Euros");
                    return list;
                }
            }return list;
        }

    }
}

