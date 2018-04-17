using System;
using System.Web.Mvc;
using web_loja_dal.Models;
using web_loja_bll.Service;

namespace web_loja_app.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Produto
        public ActionResult EstoqueList(){
            
            using (var ctx = new Model())
            {                               
                return View(new ProdutoService().list());                
            }                           
        }

        // GET
        public ActionResult EstoqueDetail(int? id)
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
        public ActionResult EstoqueEdit(int? id)
        {
            if (id == null)
            {
                return View("EstoqueEdit");
            }
            else
            {
                return View("EstoqueEdit", new ProdutoService().getById((int)id));
            }
        }

        // POST Produto/ProdutoEdit
        [HttpPost]
        public ActionResult EstoqueEdit(PRODUTO produto){
            try
            {
                if (produto.ID != 0)
                {
                    new ProdutoService().update(produto);                    
                } else
                {
                    produto.DATA_CRIACAO = DateTime.Now;
                    produto.ATIVO = 1;
                    new ProdutoService().insert(produto);                    
                }
                return View(produto);
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult EstoqueDelete(int? id)
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