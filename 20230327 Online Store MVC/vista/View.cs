using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327_Online_Store_MVC.vista
{
    internal class View
    {
        public string Vistamenu()
        {
            string opcio;
            bool sortir = false;

            Console.WriteLine();
            Console.WriteLine("1.Gestió d'Articles ");
            Console.WriteLine("2.Gestió de Clients ");
            Console.WriteLine("3.Gestió de Comandes ");
            Console.WriteLine("0. Sortir");
            Console.WriteLine();
            opcio = OpcioMenu();
            do
            {
                switch (opcio)
                {
                    case "1":
                        return VistaMenuArticles();
                    case "2":
                        return VistaMenuClients();
                    case "3":
                        return VistaMenuComandes();
                    default:
                        return "0";
                }
            } while (!sortir);
        }
        private string OpcioMenu()
        {
            string opcio;
            do
            {
                Console.WriteLine();
                Console.Write("Opció: ");
                opcio = Console.ReadLine();
            } while (!"0123".Contains(opcio));

            return opcio;
        }
        public string VistaMenuArticles()
        {
            string opcio;
            Console.WriteLine();
            Console.WriteLine("1.Afegir Article ");
            Console.WriteLine("2.Mostrar Article");
            Console.WriteLine("3.Menú anterior");
            Console.WriteLine("0. Sortir");
            opcio = OpcioMenuArticles();

            switch (opcio)
            {
                case "1":
                    return "1.1";   //afegirArticles();             
                case "2":
                    return "1.2";   //mostrarArticles();
                case "3":
                    return "1.3";//Ha de retornar vista.Vistamenu();
                default:
                    return "0";
            }
        }
        private string OpcioMenuArticles()
        {
            string opcio;
            do
            {
                Console.WriteLine();
                Console.Write("Opció: ");
                opcio = Console.ReadLine();
            } while (!"0123".Contains(opcio));

            return opcio;
        }
        public string VistaMenuClients()
        {
            string opcio;
            Console.WriteLine();
            Console.WriteLine("1.Afegir Clients ");
            Console.WriteLine("2.Mostrar Clients");
            Console.WriteLine("3.Mostrar Clients Estandard ");
            Console.WriteLine("4.Mostrar Clients Vip");
            Console.WriteLine("5.Menú anterior");
            Console.WriteLine("0. Sortir");
            opcio = OpcioMenuClients();

            switch (opcio)
            {
                case "1":
                    return "2.1";   //afegirClients();             
                case "2":
                    return "2.2";   //mostrarClients();
                case "3":
                    return "2.3";   //mostrarClientsStandard();             
                case "4":
                    return "2.4";   //mostrarClientsVip();
                case "5":
                    return "2.5"; //Ha de retornar vista.VistaMenu();
                default:
                    return "0";
            }
        }
        private string OpcioMenuClients()
        {
            string opcio;
            do
            {
                Console.WriteLine();
                Console.Write("Opció: ");
                opcio = Console.ReadLine();
            } while (!"012345".Contains(opcio));

            return opcio;
        }
        
        public string VistaMenuComandes()
        {
            string opcio;
            Console.WriteLine();
            Console.WriteLine("1.Afegir Comanda ");
            Console.WriteLine("2.Eliminar Comanda");
            Console.WriteLine("3.Mostrar Comandes pendents d'enviament ");
            Console.WriteLine("4.Mostar Comandes enviades");
            Console.WriteLine("5.Menú anterior");
            Console.WriteLine("0. Sortir");
            opcio = OpcioMenuComandes();

            switch (opcio)
            {
                case "1":
                    return "3.1";   //afegirComanda();             
                case "2":
                    return "3.2";   //eliminarComanda();
                case "3":
                    return "3.3";   //ComPendentsEnviament();             
                case "4":
                    return "3.4";   //mostrarComEnviades();
                case "5":
                    return "2.5"; //Ha de retornar vista.VistaMenu();
                default:
                    return "0";
            }
        }
        private string OpcioMenuComandes()
        {
            string opcio;
            do
            {
                Console.WriteLine();
                Console.Write("Opció: ");
                opcio = Console.ReadLine();
            } while (!"012345".Contains(opcio));

            return opcio;
        }

    }
}
