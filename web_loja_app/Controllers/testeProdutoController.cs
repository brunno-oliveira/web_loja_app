using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using web_loja_dal;

namespace web_loja_app.Controllers
{
    public class testeProdutoController : Controller
    {
        private Model db = new Model();

        // GET: testeProduto
        public ActionResult Index()
        {
            return View(db.PRODUTO.ToList());
        }

        // GET: testeProduto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // GET: testeProduto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: testeProduto/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NOME,MARCA,VALOR,QUANTIDADE,ATIVO,DATA_CRIACAO,DATA_ATUALIZACAO")] PRODUTO pRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.PRODUTO.Add(pRODUTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRODUTO);
        }

        // GET: testeProduto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // POST: testeProduto/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NOME,MARCA,VALOR,QUANTIDADE,ATIVO,DATA_CRIACAO,DATA_ATUALIZACAO")] PRODUTO pRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRODUTO);
        }

        // GET: testeProduto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // POST: testeProduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            db.PRODUTO.Remove(pRODUTO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
