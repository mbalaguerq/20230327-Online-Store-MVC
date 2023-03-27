using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327_Online_Store_MVC.model
{
    internal class Article
    {
        private string codi;
        private string descripcio;
        private decimal pvp;

        public string Codi { get => codi; set => codi = value; }
        public string Descripcio { get => descripcio; set => descripcio = value; }
        public decimal Pvp { get => pvp; set => pvp = value; }

        public override string ToString()
        {
            return "Article: " + "\n" + "Codi: " + "\t" + codi + "\n" + "Descripció: " + "\t" + descripcio +
                   "\n" + "Preu: " + "\t" + pvp; 
        }
    }
}
