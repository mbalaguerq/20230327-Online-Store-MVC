﻿using Online_Store_Windows_Forms.vista;
using Online_Store_Windows_Forms.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Store_Windows_Forms;

namespace Online_Store_Windows_Forms.controlador
{
    internal class ArticleController
    {
        OnlineStore datos;
        public ArticleController(OnlineStore pdatos)
        {
            this.datos = pdatos;
        }
        public void mostrarArticulos()
        {
            List<String> result =  datos.mostrarArticulos();

            MostrarArticulos articulos = new MostrarArticulos(result);
            articulos.Show();
            
        }
        public void afegirArticles()
        {
            NouArticle nouArticle = new NouArticle();
            nouArticle.Show();

        }

    }
}
