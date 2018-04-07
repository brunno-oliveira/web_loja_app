using System;
using System.Linq;
using System.Web.Mvc;
using web_loja_dal.Models;
using web_loja_dal.DAO;

namespace web_loja_app.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult ProdutoList()
        {
            using (var ctx = new Model())
            {                               
                return View(new ProdutoDAO().list());                
            }                           
        }

        // GET
        public ActionResult ProdutoDetail(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            using (var ctx = new Model()) {
                try
                {
                    return View(new ProdutoDAO().getById((int)id));                    
                } catch (Exception ex)
                {
                    Console.Write("Erro ao consultar pelo ID: " + id);
                    return View("Error");
                }
            }            
        }
        
        // GET
        public ActionResult ProdutoEdit()
        {
            return View("ProdutoEdit");
        }

        // POST
        [HttpPost]
        public ActionResult ProdutoCreate(PRODUTO produto)
        {
            try
            {
                new ProdutoDAO().insert(produto);
                return View();
            } catch
            {
                return View();
            }            
        }        
    }
}