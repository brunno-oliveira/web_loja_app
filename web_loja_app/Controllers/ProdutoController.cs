using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_loja_app.Models;


namespace web_loja_app.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Produto()
        {
            using (var ctx = new web_loja_dal.Model())
            {
                List<web_loja_dal.PRODUTO> prod = (from d in ctx.PRODUTO select d).ToList<web_loja_dal.PRODUTO>();
                Console.WriteLine(prod);
            }            
                return View();
        }

        // GET
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET
        public ActionResult Create()
        {
            Produto produto = new Produto();
            produto.nome = "joao";
            produto.id = 999;
            return View("Produto", produto);
        }

        // POST
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Produto");
            } catch
            {
                return View();
            }            
        }        
    }
}