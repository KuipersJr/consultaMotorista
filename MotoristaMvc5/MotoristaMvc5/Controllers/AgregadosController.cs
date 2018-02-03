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
    public class AgregadosController : Controller
    {
        private Motoristadb db = new Motoristadb();

        // GET: Agregado
        public ActionResult Index()
        {
            return View(db.MOT_AGREGADO_VEICULO.ToList());
        }

        // GET: Agregado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_AGREGADO_VEICULO mOT_AGREGADO_VEICULO = db.MOT_AGREGADO_VEICULO.Find(id);
            if (mOT_AGREGADO_VEICULO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_AGREGADO_VEICULO);
        }

        // GET: Agregado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agregado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAV_ID,MAV_TIPO_PROPRIETARIO,MAV_CPF,MAV_NOME,MAV_PLACA,MAV_RENAVAM,MAV_RENA_UF,MAV_PROP_CPF_CNPJ,MAV_PROP_NOME_RAZAO_SOCIAL,MAV_PROP_NOME_MAE,MAV_PROP_NOME_PAI,MAV_PROP_SEXO,MAV_PROP_DATA_NASCIMENTO,MAV_PROP_RG,MAV_PROP_UF")] MOT_AGREGADO_VEICULO mOT_AGREGADO_VEICULO)
        {
            if (ModelState.IsValid)
            {
                db.MOT_AGREGADO_VEICULO.Add(mOT_AGREGADO_VEICULO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOT_AGREGADO_VEICULO);
        }

        // GET: Agregado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_AGREGADO_VEICULO mOT_AGREGADO_VEICULO = db.MOT_AGREGADO_VEICULO.Find(id);
            if (mOT_AGREGADO_VEICULO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_AGREGADO_VEICULO);
        }

        // POST: Agregado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAV_ID,MAV_TIPO_PROPRIETARIO,MAV_CPF,MAV_NOME,MAV_PLACA,MAV_RENAVAM,MAV_RENA_UF,MAV_PROP_CPF_CNPJ,MAV_PROP_NOME_RAZAO_SOCIAL,MAV_PROP_NOME_MAE,MAV_PROP_NOME_PAI,MAV_PROP_SEXO,MAV_PROP_DATA_NASCIMENTO,MAV_PROP_RG,MAV_PROP_UF")] MOT_AGREGADO_VEICULO mOT_AGREGADO_VEICULO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOT_AGREGADO_VEICULO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOT_AGREGADO_VEICULO);
        }

        // GET: Agregado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_AGREGADO_VEICULO mOT_AGREGADO_VEICULO = db.MOT_AGREGADO_VEICULO.Find(id);
            if (mOT_AGREGADO_VEICULO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_AGREGADO_VEICULO);
        }

        // POST: Agregado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOT_AGREGADO_VEICULO mOT_AGREGADO_VEICULO = db.MOT_AGREGADO_VEICULO.Find(id);
            db.MOT_AGREGADO_VEICULO.Remove(mOT_AGREGADO_VEICULO);
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
