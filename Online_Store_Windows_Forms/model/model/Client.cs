using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store_Windows_Forms.modelo
{
    internal class Client
    {
        private string nom;
        private string domicili;
        private string nif;
        private string email;
        private bool vip;

        public string Nom { get => nom; set => nom = value; }
        public string Domicili { get => domicili; set => domicili = value; }
        public string Nif { get => nif; set => nif = value; }
        public string Email { get => email; set => email = value; }
        public bool Vip { get => vip; set => vip = value; }

        public override string ToString()
        {
            if (vip = true)
            {

                return "CLIENT VIP" + 
                        "\r\nNom: \t" + nom + 
                        "\r\nDomicili: \t" + domicili + 
                        "\r\nNif: \t" + nif + 
                        "\r\nEmail:  \t" + email;
            }
            else
            {
                return "\r\nNom: \t" + nom +
                        "\r\nDomicili: \t" + domicili +
                        "\r\nNif: \t" + nif +
                        "\r\nEmail:  \t" + email;
            }
        }
        
    }
}
