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
    public class AutonomosController : Controller
    {
        private Motoristadb db = new Motoristadb();

        // GET: Autonomos
        public ActionResult Index()
        {
            return View(db.MOT_AUTONOMO.ToList());
        }

        // GET: Autonomos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_AUTONOMO mOT_AUTONOMO = db.MOT_AUTONOMO.Find(id);
            if (mOT_AUTONOMO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_AUTONOMO);
        }

        // GET: Autonomos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autonomos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MOT_AUT_ID,MOT_AUT_NACIONALIDADE,MOT_AUT_NOME,MOT_AUT_SEXO,MOT_AUT_DATA_NASCIMENTO,MOT_AUT_CPF,MOT_AUT_RG_RGE,MOT_AUT_RG_ORG_EMISSAO,MOT_AUT_RG_DATA_EMISSAO,MOT_AUT_CNH,MOT_AUT_CNH_UF,MOT_AUT_P_CNH,MOT_AUT_CNH_VALIDADE,MOT_AUT_CNH_SEGURANCA,MOT_AUT_CNH_CAT_ID,MOT_AUT_TELEFONE,MOT_AUT_CELULAR_I,MOT_AUT_CELULAR_II,MOT_AUT_EMAIL,MOT_AUT_FLG_SERASA,MOT_AUT_FLG_CRIMINAL")] MOT_AUTONOMO mOT_AUTONOMO)
        {
            if (ModelState.IsValid)
            {
                db.MOT_AUTONOMO.Add(mOT_AUTONOMO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOT_AUTONOMO);
        }

        // GET: Autonomos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_AUTONOMO mOT_AUTONOMO = db.MOT_AUTONOMO.Find(id);
            if (mOT_AUTONOMO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_AUTONOMO);
        }

        // POST: Autonomos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MOT_AUT_ID,MOT_AUT_NACIONALIDADE,MOT_AUT_NOME,MOT_AUT_SEXO,MOT_AUT_DATA_NASCIMENTO,MOT_AUT_CPF,MOT_AUT_RG_RGE,MOT_AUT_RG_ORG_EMISSAO,MOT_AUT_RG_DATA_EMISSAO,MOT_AUT_CNH,MOT_AUT_CNH_UF,MOT_AUT_P_CNH,MOT_AUT_CNH_VALIDADE,MOT_AUT_CNH_SEGURANCA,MOT_AUT_CNH_CAT_ID,MOT_AUT_TELEFONE,MOT_AUT_CELULAR_I,MOT_AUT_CELULAR_II,MOT_AUT_EMAIL,MOT_AUT_FLG_SERASA,MOT_AUT_FLG_CRIMINAL")] MOT_AUTONOMO mOT_AUTONOMO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOT_AUTONOMO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOT_AUTONOMO);
        }

        // GET: Autonomos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_AUTONOMO mOT_AUTONOMO = db.MOT_AUTONOMO.Find(id);
            if (mOT_AUTONOMO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_AUTONOMO);
        }

        // POST: Autonomos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOT_AUTONOMO mOT_AUTONOMO = db.MOT_AUTONOMO.Find(id);
            db.MOT_AUTONOMO.Remove(mOT_AUTONOMO);
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
