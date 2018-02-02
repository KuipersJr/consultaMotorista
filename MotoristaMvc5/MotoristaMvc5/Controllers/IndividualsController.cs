using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotoristaMvc5.Models.Cadastros.Motoristas;

namespace MotoristaMvc5.Controllers
{
    public class IndividualsController : Controller
    {
        private Individualdb db = new Individualdb();

        // GET: Individuals
        public ActionResult Index()
        {
            return View(db.Individual.ToList());
        }

        // GET: Individuals/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_INDIVIDUAL individual = await db.Individual.FindAsync(id);
            if (individual == null)
            {
                return HttpNotFound();
            }
            return View(individual);
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
        public async Task<ActionResult> Create([Bind(Include = "MOT_INDI_ID,MOT_INDI_NACIONALIDADE,MOT_INDI_NOME,MOT_INDI_SEXO,MOT_INDI_DATA_NASCIMENTO,MOT_INDI_CPF,MOT_INDI_RG_RGE,MOT_INDI_RG_ORG_EMISSAO,MOT_INDI_RG_DATA_EMISSAO,MOT_INDI_CNH,MOT_INDI_CNH_UF,MOT_INDI_P_CNH,MOT_INDI_CNH_VALIDADE,MOT_INDI_CNH_SEGURANCA,MOT_INDI_CNH_CAT_ID,MOT_INDI_TELEFONE,MOT_INDI_CELULAR_I,MOT_INDI_CELULAR_II,MOT_INDI_EMAIL,MOT_INDI_EX_DOCUMENTO,MOT_INDI_EX_DOC_VALIDADE,MOT_INDI_EX_CNH,MOT_INDI_EX_CNH_VALIDADE,MOT_INDI_EX_PAIS_ORG,MOT_INDI_EX_CIDADE")] MOT_INDIVIDUAL individual)
        {
            if (ModelState.IsValid)
            {
                db.Individual.Add(individual);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(individual);
        }

        // GET: Individuals/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_INDIVIDUAL individual = await db.Individual.FindAsync(id);
            if (individual == null)
            {
                return HttpNotFound();
            }
            return View(individual);
        }

        // POST: Individuals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MOT_INDI_ID,MOT_INDI_NACIONALIDADE,MOT_INDI_NOME,MOT_INDI_SEXO,MOT_INDI_DATA_NASCIMENTO,MOT_INDI_CPF,MOT_INDI_RG_RGE,MOT_INDI_RG_ORG_EMISSAO,MOT_INDI_RG_DATA_EMISSAO,MOT_INDI_CNH,MOT_INDI_CNH_UF,MOT_INDI_P_CNH,MOT_INDI_CNH_VALIDADE,MOT_INDI_CNH_SEGURANCA,MOT_INDI_CNH_CAT_ID,MOT_INDI_TELEFONE,MOT_INDI_CELULAR_I,MOT_INDI_CELULAR_II,MOT_INDI_EMAIL,MOT_INDI_EX_DOCUMENTO,MOT_INDI_EX_DOC_VALIDADE,MOT_INDI_EX_CNH,MOT_INDI_EX_CNH_VALIDADE,MOT_INDI_EX_PAIS_ORG,MOT_INDI_EX_CIDADE")] MOT_INDIVIDUAL individual)
        {
            if (ModelState.IsValid)
            {
                db.Entry(individual).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(individual);
        }

        // GET: Individuals/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOT_INDIVIDUAL individual = await db.Individual.FindAsync(id);
            if (individual == null)
            {
                return HttpNotFound();
            }
            return View(individual);
        }

        // POST: Individuals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MOT_INDIVIDUAL individual = await db.Individual.FindAsync(id);
            db.Individual.Remove(individual);
            await db.SaveChangesAsync();
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
