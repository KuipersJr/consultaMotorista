using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotoristaMvc5.Models;

namespace MotoristaMvc5.Controllers
{
    public class AgregadosController : Controller
    {
        private Agregadodb db = new Agregadodb();

        // GET: Agregados
        public async Task<ActionResult> Index()
        {
            return View(await db.Agregado.ToListAsync());
        }

        // GET: Agregados/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agregado agregado = await db.Agregado.FindAsync(id);
            if (agregado == null)
            {
                return HttpNotFound();
            }
            return View(agregado);
        }

        // GET: Agregados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agregados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MAV_ID,MAV_TIPO_PROPRIETARIO,MAV_CPF,MAV_NOME,MAV_PLACA,MAV_RENAVAM,MAV_RENA_UF,MAV_PROP_CPF_CNPJ,MAV_PROP_NOME_RAZAO_SOCIAL,MAV_PROP_NOME_MAE,MAV_PROP_NOME_PAI,MAV_PROP_SEXO,MAV_PROP_DATA_NASCIMENTO,MAV_PROP_RG,MAV_PROP_UF")] Agregado agregado)
        {
            if (ModelState.IsValid)
            {
                db.Agregado.Add(agregado);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(agregado);
        }

        // GET: Agregados/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agregado agregado = await db.Agregado.FindAsync(id);
            if (agregado == null)
            {
                return HttpNotFound();
            }
            return View(agregado);
        }

        // POST: Agregados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MAV_ID,MAV_TIPO_PROPRIETARIO,MAV_CPF,MAV_NOME,MAV_PLACA,MAV_RENAVAM,MAV_RENA_UF,MAV_PROP_CPF_CNPJ,MAV_PROP_NOME_RAZAO_SOCIAL,MAV_PROP_NOME_MAE,MAV_PROP_NOME_PAI,MAV_PROP_SEXO,MAV_PROP_DATA_NASCIMENTO,MAV_PROP_RG,MAV_PROP_UF")] Agregado agregado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agregado).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(agregado);
        }

        // GET: Agregados/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agregado agregado = await db.Agregado.FindAsync(id);
            if (agregado == null)
            {
                return HttpNotFound();
            }
            return View(agregado);
        }

        // POST: Agregados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Agregado agregado = await db.Agregado.FindAsync(id);
            db.Agregado.Remove(agregado);
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
