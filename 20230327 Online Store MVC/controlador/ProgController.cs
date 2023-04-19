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
    }
}
