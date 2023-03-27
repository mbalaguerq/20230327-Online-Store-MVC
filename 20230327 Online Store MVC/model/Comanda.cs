using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327_Online_Store_MVC.model
{
    internal class Comanda
    {
        private int nComanda;
        private Client client;
        private Article article;
        int unitats;
        DateTime dataAvui;

        public int NComanda { get => nComanda; set => nComanda = value; }
        public int Unitats { get => unitats; set => unitats = value; }
        public DateTime DataAvui { get => dataAvui; set => dataAvui = value; }
        internal Client Client { get => client; set => client = value; }
        internal Article Article { get => article; set => article = value; }
    }
}
