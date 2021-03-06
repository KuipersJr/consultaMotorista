﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotoristaMvc5.Models.Cadastros.Motoristas;
using MotoristaMvc5.Models.Cadastros.Veiculo;

namespace MotoristaMvc5.Controllers
{
    public class VeiculosController : Controller
    {
        private Motoristadb db = new Motoristadb();

        // GET: Veiculos
        public ActionResult Index()
        {
            return View(db.MOT_VEICULO.ToList());
        }

        // GET: Veiculos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_VEICULO mOT_VEICULO = db.MOT_VEICULO.Find(id);
            if (mOT_VEICULO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_VEICULO);
        }

        // GET: Veiculos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VEI_ID,VEI_TIPO_PROPRIETARIO,VEI_CPF,VEI_NOME,VEI_PLACA,VEI_RENAVAM,VEI_RENA_UF,VEI_PROP_CPF_CNPJ,VEI_PROP_NOME_RAZAO_SOCIAL")] MOT_VEICULO mOT_VEICULO)
        {
            if (ModelState.IsValid)
            {
                db.MOT_VEICULO.Add(mOT_VEICULO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOT_VEICULO);
        }

        // GET: Veiculos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_VEICULO mOT_VEICULO = db.MOT_VEICULO.Find(id);
            if (mOT_VEICULO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_VEICULO);
        }

        // POST: Veiculos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VEI_ID,VEI_TIPO_PROPRIETARIO,VEI_CPF,VEI_NOME,VEI_PLACA,VEI_RENAVAM,VEI_RENA_UF,VEI_PROP_CPF_CNPJ,VEI_PROP_NOME_RAZAO_SOCIAL")] MOT_VEICULO mOT_VEICULO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOT_VEICULO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOT_VEICULO);
        }

        // GET: Veiculos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_VEICULO mOT_VEICULO = db.MOT_VEICULO.Find(id);
            if (mOT_VEICULO == null)
            {
                return HttpNotFound();
            }
            return View(mOT_VEICULO);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOT_VEICULO mOT_VEICULO = db.MOT_VEICULO.Find(id);
            db.MOT_VEICULO.Remove(mOT_VEICULO);
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
