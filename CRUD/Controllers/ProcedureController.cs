using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class ProcedureController : Controller
    {
        Database1Entities entities = new Database1Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View(entities.spSearchProducts(""));
        }

        [HttpPost]
        public ActionResult Index(string productName)
        {
            return View(entities.spSearchProducts(productName));
        }

        // GET: Home
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produto produto = entities.produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: produto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, string nome, decimal valor) 
        {
            if (ModelState.IsValid)
            {
                // entities.Entry(entities.spUpdateProduto(id_produto, nome, valor)).State = EntityState.Modified;
                entities.spUpdateProduto(id, nome, valor);
                entities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: Home
        public ActionResult CountProducts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CountProducts(int? id)
        {
            var fornecedor = from f in entities.fornecedor
                             select new { id = f.id_fornecedor, Nome = f.nome };


            ViewBag.lista_forne = new SelectList(fornecedor, "id_forecedor", "nome"); 

            return View(entities.Produto_CountProducts(id));
        }


    }
}