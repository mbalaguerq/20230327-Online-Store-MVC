using Online_Store_Windows_Forms.vista;
using Online_Store_Windows_Forms.modelo;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Store_Windows_Forms;

namespace Online_Store_Windows_Forms.controlador
{
    internal class ProgController
    {
        public OnlineStore datos;
        MenuPrincipal vista;

        public ProgController(OnlineStore pdatos)
        {
            datos = pdatos;            
        }
        public void menuArticles()
        {
            ArticleController articleController = new ArticleController(datos);
            ArticleView formArticle = new ArticleView(articleController);
            formArticle.Show();
        }

    }
}
