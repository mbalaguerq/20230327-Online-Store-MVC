﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327_Online_Store_MVC.model
{
    internal class Client
    {
        private string nom;
        private string domicili;
        private string nif;
        private string email;
        private int vip;

        public string Nom { get => nom; set => nom = value; }
        public string Domicili { get => domicili; set => domicili = value; }
        public string Nif { get => nif; set => nif = value; }
        public string Email { get => email; set => email = value; }
        public int Vip { get => vip; set => vip = value; }

        public override string ToString()
        {
            return "Nom: \t" + nom + "\n" + "Domicili: \t" +  domicili + "\n" + 
                   "Nif: \t" + nif + "\n" + "Email:  \t" + email;
        }
    }
}
