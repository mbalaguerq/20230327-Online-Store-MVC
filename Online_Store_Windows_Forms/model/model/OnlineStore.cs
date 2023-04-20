using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
        public List<String> mostrarArticulos()
        {
            List <String> result = new List<String>();

            foreach(Article article in articles) 
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

    }
}
