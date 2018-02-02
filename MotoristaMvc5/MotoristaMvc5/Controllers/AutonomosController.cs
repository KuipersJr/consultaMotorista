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
    public class AutonomosController : Controller
    {
        private Autonomodb db = new Autonomodb();

        // GET: Autonomos
        public async Task<ActionResult> Index()
        {
            return View(await db.Autonomo.ToListAsync());
        }

        // GET: Autonomos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autonomo autonomo = await db.Autonomo.FindAsync(id);
            if (autonomo == null)
            {
                return HttpNotFound();
            }
            return View(autonomo);
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
        public async Task<ActionResult> Create([Bind(Include = "MOT_AUT_ID,MOT_AUT_NACIONALIDADE,MOT_AUT_NOME,MOT_AUT_SEXO,MOT_AUT_DATA_NASCIMENTO,MOT_AUT_CPF,MOT_AUT_RG_RGE,MOT_AUT_RG_ORG_EMISSAO,MOT_AUT_RG_DATA_EMISSAO,MOT_AUT_CNH,MOT_AUT_CNH_UF,MOT_AUT_P_CNH,MOT_AUT_CNH_VALIDADE,MOT_AUT_CNH_SEGURANCA,MOT_AUT_CNH_CAT_ID,MOT_AUT_TELEFONE,MOT_AUT_CELULAR_I,MOT_AUT_CELULAR_II,MOT_AUT_EMAIL,MOT_AUT_FLG_SERASA,MOT_AUT_FLG_CRIMINAL")] Autonomo autonomo)
        {
            if (ModelState.IsValid)
            {
                db.Autonomo.Add(autonomo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(autonomo);
        }

        // GET: Autonomos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autonomo autonomo = await db.Autonomo.FindAsync(id);
            if (autonomo == null)
            {
                return HttpNotFound();
            }
            return View(autonomo);
        }

        // POST: Autonomos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MOT_AUT_ID,MOT_AUT_NACIONALIDADE,MOT_AUT_NOME,MOT_AUT_SEXO,MOT_AUT_DATA_NASCIMENTO,MOT_AUT_CPF,MOT_AUT_RG_RGE,MOT_AUT_RG_ORG_EMISSAO,MOT_AUT_RG_DATA_EMISSAO,MOT_AUT_CNH,MOT_AUT_CNH_UF,MOT_AUT_P_CNH,MOT_AUT_CNH_VALIDADE,MOT_AUT_CNH_SEGURANCA,MOT_AUT_CNH_CAT_ID,MOT_AUT_TELEFONE,MOT_AUT_CELULAR_I,MOT_AUT_CELULAR_II,MOT_AUT_EMAIL,MOT_AUT_FLG_SERASA,MOT_AUT_FLG_CRIMINAL")] Autonomo autonomo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autonomo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(autonomo);
        }

        // GET: Autonomos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autonomo autonomo = await db.Autonomo.FindAsync(id);
            if (autonomo == null)
            {
                return HttpNotFound();
            }
            return View(autonomo);
        }

        // POST: Autonomos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Autonomo autonomo = await db.Autonomo.FindAsync(id);
            db.Autonomo.Remove(autonomo);
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
