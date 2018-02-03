using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotoristaMvc5.Models.Cadastros.Motoristas;

namespace MotoristaMvc5.Controllers
{
    public class IndividualsController : Controller
    {
        private Motoristadb db = new Motoristadb();

        // GET: Individuals
        public ActionResult Index()
        {
            return View(db.MOT_INDIVIDUAL.ToList());
        }

        // GET: Individuals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_INDIVIDUAL mOT_INDIVIDUAL = db.MOT_INDIVIDUAL.Find(id);
            if (mOT_INDIVIDUAL == null)
            {
                return HttpNotFound();
            }
            return View(mOT_INDIVIDUAL);
        }

        // GET: Individuals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Individuals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MOT_INDI_ID,MOT_INDI_NACIONALIDADE,MOT_INDI_NOME,MOT_INDI_SEXO,MOT_INDI_DATA_NASCIMENTO,MOT_INDI_CPF,MOT_INDI_RG_RGE,MOT_INDI_RG_ORG_EMISSAO,MOT_INDI_RG_DATA_EMISSAO,MOT_INDI_CNH,MOT_INDI_CNH_UF,MOT_INDI_P_CNH,MOT_INDI_CNH_VALIDADE,MOT_INDI_CNH_SEGURANCA,MOT_INDI_CNH_CAT_ID,MOT_INDI_TELEFONE,MOT_INDI_CELULAR_I,MOT_INDI_CELULAR_II,MOT_INDI_EMAIL,MOT_INDI_EX_DOCUMENTO,MOT_INDI_EX_DOC_VALIDADE,MOT_INDI_EX_CNH,MOT_INDI_EX_CNH_VALIDADE,MOT_INDI_EX_PAIS_ORG,MOT_INDI_EX_CIDADE")] MOT_INDIVIDUAL mOT_INDIVIDUAL)
        {
            if (ModelState.IsValid)
            {
                db.MOT_INDIVIDUAL.Add(mOT_INDIVIDUAL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOT_INDIVIDUAL);
        }

        // GET: Individuals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_INDIVIDUAL mOT_INDIVIDUAL = db.MOT_INDIVIDUAL.Find(id);
            if (mOT_INDIVIDUAL == null)
            {
                return HttpNotFound();
            }
            return View(mOT_INDIVIDUAL);
        }

        // POST: Individuals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MOT_INDI_ID,MOT_INDI_NACIONALIDADE,MOT_INDI_NOME,MOT_INDI_SEXO,MOT_INDI_DATA_NASCIMENTO,MOT_INDI_CPF,MOT_INDI_RG_RGE,MOT_INDI_RG_ORG_EMISSAO,MOT_INDI_RG_DATA_EMISSAO,MOT_INDI_CNH,MOT_INDI_CNH_UF,MOT_INDI_P_CNH,MOT_INDI_CNH_VALIDADE,MOT_INDI_CNH_SEGURANCA,MOT_INDI_CNH_CAT_ID,MOT_INDI_TELEFONE,MOT_INDI_CELULAR_I,MOT_INDI_CELULAR_II,MOT_INDI_EMAIL,MOT_INDI_EX_DOCUMENTO,MOT_INDI_EX_DOC_VALIDADE,MOT_INDI_EX_CNH,MOT_INDI_EX_CNH_VALIDADE,MOT_INDI_EX_PAIS_ORG,MOT_INDI_EX_CIDADE")] MOT_INDIVIDUAL mOT_INDIVIDUAL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOT_INDIVIDUAL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOT_INDIVIDUAL);
        }

        // GET: Individuals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_INDIVIDUAL mOT_INDIVIDUAL = db.MOT_INDIVIDUAL.Find(id);
            if (mOT_INDIVIDUAL == null)
            {
                return HttpNotFound();
            }
            return View(mOT_INDIVIDUAL);
        }

        // POST: Individuals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOT_INDIVIDUAL mOT_INDIVIDUAL = db.MOT_INDIVIDUAL.Find(id);
            db.MOT_INDIVIDUAL.Remove(mOT_INDIVIDUAL);
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
