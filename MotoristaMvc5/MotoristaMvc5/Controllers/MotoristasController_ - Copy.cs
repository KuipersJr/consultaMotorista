using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotoristaMvc5;
using MotoristaMvc5.Models.Cadastros.Motoristas;

namespace MotoristaMvc5.Controllers
{
    public class MotoristasController_ : Controller
    {
        private Motoristadb db = new Motoristadb();

        // GET: Motoristas
        public ActionResult Index()
        {
            return View(db.Motoristas.ToList());
        }

        // GET: Motoristas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Motorista_ motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // GET: Motoristas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motoristas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MOT_NACIONALIDADE,MOT_NOME,MOT_SEXO,MOT_DATA_NASCIMENTO,MOT_CPF,MOT_RG_RGE,MOT_RG_ORG_EMISSAO,MOT_RG_DATA_EMISSAO,MOT_CNH,MOT_CNH_UF,MOT_P_CNH,MOT_CNH_VALIDADE,MOT_CNH_SEGURANCA,MOT_CNH_CAT_ID,MOT_TELEFONE,MOT_CELULAR_I,MOT_CELULAR_II,MOT_EMAIL,MOT_FLAG_TP_MOT")] Motorista_ motorista, string checkbox)
        {

            if (!String.IsNullOrEmpty(checkbox))
            {
                motorista.MOT_NACIONALIDADE = "S";
            }
            else
            {
                motorista.MOT_NACIONALIDADE = "N";
            }

            var Categoria = new SelectList(new[] { "A", "B", "C", "D", "E", "ACC" });
            ViewBag.Categoria = Categoria;

            if (ModelState.IsValid)
            {
                db.Motoristas.Add(motorista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorista);
        }

        // GET: Motoristas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Motorista_ motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // POST: Motoristas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MOT_NACIONALIDADE,MOT_NOME,MOT_SEXO,MOT_DATA_NASCIMENTO,MOT_CPF,MOT_RG_RGE,MOT_RG_ORG_EMISSAO,MOT_RG_DATA_EMISSAO,MOT_CNH,MOT_CNH_UF,MOT_P_CNH,MOT_CNH_VALIDADE,MOT_CNH_SEGURANCA,MOT_CNH_CAT_ID,MOT_TELEFONE,MOT_CELULAR_I,MOT_CELULAR_II,MOT_EMAIL,MOT_FLAG_TP_MOT")] MOTORISTA motorista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorista);
        }

        // GET: Motoristas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MOTORISTA motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // POST: Motoristas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOTORISTA motorista = db.Motoristas.Find(id);
            db.Motoristas.Remove(motorista);
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
