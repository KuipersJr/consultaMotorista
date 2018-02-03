using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotoristaMvc5.Models.Cadastros.Empresa;
using MotoristaMvc5.Models.Cadastros.Motoristas;

namespace MotoristaMvc5.Controllers
{
    public class EmpresasController : Controller
    {
        private Motoristadb db = new Motoristadb();

        // GET: Empresas
        public ActionResult Index()
        {
            return View(db.MOT_EMPRESA.ToList());
        }

        // GET: Empresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_EMPRESA mOT_EMPRESA = db.MOT_EMPRESA.Find(id);
            if (mOT_EMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(mOT_EMPRESA);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMP_ID,EMP_CNPJ,EMP_IE,EMP_NOME_RAZAO_SOCIAL,EMP_CEP,EMP_ENDERECO,EMP_COMPLEMENTO,EMP_CIDADE,EMP_BAIRRO,EMP_UF")] MOT_EMPRESA mOT_EMPRESA)
        {
            if (ModelState.IsValid)
            {
                db.MOT_EMPRESA.Add(mOT_EMPRESA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOT_EMPRESA);
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_EMPRESA mOT_EMPRESA = db.MOT_EMPRESA.Find(id);
            if (mOT_EMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(mOT_EMPRESA);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMP_ID,EMP_CNPJ,EMP_IE,EMP_NOME_RAZAO_SOCIAL,EMP_CEP,EMP_ENDERECO,EMP_COMPLEMENTO,EMP_CIDADE,EMP_BAIRRO,EMP_UF")] MOT_EMPRESA mOT_EMPRESA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOT_EMPRESA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOT_EMPRESA);
        }

        // GET: Empresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_EMPRESA mOT_EMPRESA = db.MOT_EMPRESA.Find(id);
            if (mOT_EMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(mOT_EMPRESA);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOT_EMPRESA mOT_EMPRESA = db.MOT_EMPRESA.Find(id);
            db.MOT_EMPRESA.Remove(mOT_EMPRESA);
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
