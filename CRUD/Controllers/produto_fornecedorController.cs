using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class produto_fornecedorController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: produto_fornecedor
        public ActionResult Index()
        {
            var produto_fornecedor = db.produto_fornecedor.Include(p => p.fornecedor).Include(p => p.produto);
            return View(produto_fornecedor.ToList());
        }

        // GET: produto_fornecedor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produto_fornecedor produto_fornecedor = db.produto_fornecedor.Find(id);
            if (produto_fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(produto_fornecedor);
        }

        // GET: produto_fornecedor/Create
        public ActionResult Create()
        {
            ViewBag.id_fornecedor = new SelectList(db.fornecedor, "id_fornecedor", "nome");
            ViewBag.id_produto = new SelectList(db.produto, "id_produto", "nome");
            return View();
        }

        // POST: produto_fornecedor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_produto,id_fornecedor")] produto_fornecedor produto_fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.produto_fornecedor.Add(produto_fornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_fornecedor = new SelectList(db.fornecedor, "id_fornecedor", "nome", produto_fornecedor.id_fornecedor);
            ViewBag.id_produto = new SelectList(db.produto, "id_produto", "nome", produto_fornecedor.id_produto);
            return View(produto_fornecedor);
        }

        // GET: produto_fornecedor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produto_fornecedor produto_fornecedor = db.produto_fornecedor.Find(id);
            if (produto_fornecedor == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_fornecedor = new SelectList(db.fornecedor, "id_fornecedor", "nome", produto_fornecedor.id_fornecedor);
            ViewBag.id_produto = new SelectList(db.produto, "id_produto", "nome", produto_fornecedor.id_produto);
            return View(produto_fornecedor);
        }

        // POST: produto_fornecedor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_produto,id_fornecedor")] produto_fornecedor produto_fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto_fornecedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_fornecedor = new SelectList(db.fornecedor, "id_fornecedor", "nome", produto_fornecedor.id_fornecedor);
            ViewBag.id_produto = new SelectList(db.produto, "id_produto", "nome", produto_fornecedor.id_produto);
            return View(produto_fornecedor);
        }

        // GET: produto_fornecedor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produto_fornecedor produto_fornecedor = db.produto_fornecedor.Find(id);
            if (produto_fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(produto_fornecedor);
        }

        // POST: produto_fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            produto_fornecedor produto_fornecedor = db.produto_fornecedor.Find(id);
            db.produto_fornecedor.Remove(produto_fornecedor);
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
