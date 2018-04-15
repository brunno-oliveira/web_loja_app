using System;
using System.Web.Mvc;
using web_loja_dal.Models;
using web_loja_bll.Service;

namespace web_loja_app.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult ProdutoList(){
            
            using (var ctx = new Model())
            {                               
                return View(new ProdutoService().list());                
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
                    return View(new ProdutoService().getById((int)id));                    
                } catch (Exception ex)
                {
                    Console.Write("Erro ao consultar pelo ID: " + id);
                    return View("Error");
                }
            }            
        }

        // GET Produto/ProdutoEdit/{Produto ID}
        public ActionResult ProdutoEdit(int? id)
        {
            if (id == null)
            {
                return View("ProdutoEdit");
            }
            else
            {
                return View("ProdutoEdit", new ProdutoService().getById((int)id));
            }
        }

        // POST Produto/ProdutoEdit
        [HttpPost]
        public ActionResult ProdutoEdit(PRODUTO produto){
            try
            {
                if (produto.ID != null)
                {
                    new ProdutoService().update(produto);
                } else
                {
                    produto.DATA_CRIACAO = DateTime.Now;
                    produto.ATIVO = 1;
                    new ProdutoService().insert(produto);                    
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult ProdutoDelete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            new ProdutoService().remove((int)id);
            return View();
        }
    }
}