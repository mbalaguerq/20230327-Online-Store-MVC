using _20230327_Online_Store_MVC.vista;
using _20230327_Online_Store_MVC.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327_Online_Store_MVC.controlador
{
    internal class ProgController
    {
        OnlineStore datos;
        View vista;

        public ProgController()
        {
            datos = new OnlineStore();
            vista = new View();
        }
        public void gestionMenu()
        {
            string opcio;
            bool sortir=false;
           
            do
            {
                opcio = vista.Vistamenu();
                switch (opcio)
                {
                    case "1.1":
                        //afegirArticles();
                        break;
                    case "1.2":
                        //mostrarArticles();
                        break;
                    case "1.3":
                        vista.Vistamenu();
                        break;
                    case "2.1":
                        //afegirClients();
                        break;
                    case "2.2":
                        //mostrarClients();
                        break;
                    case "2.3":
                        //mostrarClientsStandard(); 
                        break;
                    case "2.4":
                        //mostrarClientsVip();
                        break;
                    case "2.5":
                        vista.Vistamenu();
                        break;
                    case "3.1":
                        //afegirComanda(); 
                        break;
                    case "3.2":
                        //eliminarComanda();
                        break;
                    case "3.3":
                        //ComPendentsEnviament(); 
                        break;
                    case "3.4":
                        //mostrarComEnviades();
                        break;
                    case "3.5":
                        vista.Vistamenu();
                        break;
                    case "0":
                        sortir = true;
                        break;
                }

            } while (!sortir); 
        }
        private void afegirArticles()
        {
            ArticleController articleController = new ArticleController(datos);
            ArticleView articleView = new ArticleView(articleController);
            ArticleView.afegirArticles();
        }

    }
}
