using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store_Windows_Forms.modelo
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

        /*
         taulell1.Codi = "STR*2512";
            taulell1.Descripcio = "Tauló fusta mdf Q1";
            taulell1.Pvp = 12; 

        taulell2.Codi = "STR*2812";
            taulell2.Descripcio = "Tauló fusta contrax. Q2";
            taulell2.Pvp = 9;

        article1.Codi = "PIC*FLEXIMAX";
            article1.Descripcio = "Matalàs + Somier + coixíns visco ";
            article1.Pvp = 299;

        vernis1.Codi = "VAL*MATEMALTE";
            vernis1.Descripcio = "Vernis incolor ref.12534 ";
            vernis1.Pvp = 25;

        */



    }
}
