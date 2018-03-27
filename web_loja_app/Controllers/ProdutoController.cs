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
                List<web_loja_dal.PRODUTO> listProd = (from d in ctx.PRODUTO select d).ToList<web_loja_dal.PRODUTO>();
                Console.WriteLine(listProd);
            }            
                return View();
        }

        // GET
        public ActionResult ProdutoDetail(int id)
        {
            using (var ctx = new web_loja_dal.Model()) {
                try
                {
                    web_loja_dal.PRODUTO prod = ctx.PRODUTO.Where(p => p.ID == id).Single();
                    return View(prod);
                } catch (Exception ex)
                {
                    Console.Write("Erro ao consultar pelo ID: " + id);
                    return View("Error");
                }
            }            
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
                using (var ctx = new web_loja_dal.Model())
                {
                    web_loja_dal.PRODUTO prod = new web_loja_dal.PRODUTO();                    
                    return View();
                }                 
            } catch
            {
                return View();
            }            
        }        
    }
}