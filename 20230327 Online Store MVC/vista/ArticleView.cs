using _20230327_Online_Store_MVC.controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327_Online_Store_MVC.vista
{
    internal class ArticleView
    {
        ArticleController ArticleController;
        public ArticleView(ArticleController pArticleController)
        {
            ArticleController = pArticleController;
        }
    }
}
