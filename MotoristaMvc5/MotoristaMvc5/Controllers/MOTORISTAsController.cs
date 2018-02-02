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
    public class MOTORISTAsController : Controller
    {
        private Motoristadb db = new Motoristadb();

        // GET: MOTORISTAs
        public ActionResult Index()
        {
            return View(db.MOTORISTAs.ToList());
        }

        // GET: MOTORISTAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOTORISTA Motorista = db.MOTORISTAs.Find(id);
            if (Motorista == null)
            {
                return HttpNotFound();
            }
            return View(Motorista);
        }

        // GET: MOTORISTAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MOTORISTAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MOT_ID,MOT_NACIONALIDADE,MOT_NOME,MOT_SEXO,MOT_DATA_NASCIMENTO,MOT_CPF,MOT_RG_RGE,"+
                                                   "MOT_RG_ORG_EMISSAO,MOT_RG_DATA_EMISSAO,MOT_CNH,MOT_CNH_UF,MOT_P_CNH,MOT_CNH_VALIDADE,"+
                                                   "MOT_CNH_SEGURANCA,MOT_CNH_CAT_ID,MOT_TELEFONE,MOT_CELULAR_I,MOT_CELULAR_II,MOT_EMAIL,"+
                                                   "MOT_FLG_SERASA,MOT_FLG_CRIMINAL,MOT_COD_INT,MOT_DATA_CADASTRO,END_DESCRICAO,END_NUMERO,"+
                                                   "END_CEP,END_COMPLEMENTO,END_UF,END_PAIS,CONT_CELULARII,CONT_TELEFONE,CONT_CELULARI,CONT_REFERENCIA,CONT_NOME")] MOTORISTA Motorista, string checkbox)
        {

            if (!String.IsNullOrEmpty(checkbox))
            {
                Motorista.MOT_NACIONALIDADE = "S";
            }
            else
            {
                Motorista.MOT_NACIONALIDADE = "N";
            }

            if (ModelState.IsValid)
            {
                db.MOTORISTAs.Add(Motorista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Motorista);
        }

        // GET: MOTORISTAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOTORISTA mOTORISTA = db.MOTORISTAs.Find(id);
            if (mOTORISTA == null)
            {
                return HttpNotFound();
            }
            return View(mOTORISTA);
        }

        // POST: MOTORISTAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MOT_ID,MOT_NACIONALIDADE,MOT_NOME,MOT_SEXO,MOT_DATA_NASCIMENTO,MOT_CPF,MOT_RG_RGE,MOT_RG_ORG_EMISSAO,MOT_RG_DATA_EMISSAO,MOT_CNH,MOT_CNH_UF,MOT_P_CNH,MOT_CNH_VALIDADE,MOT_CNH_SEGURANCA,MOT_CNH_CAT_ID,MOT_TELEFONE,MOT_CELULAR_I,MOT_CELULAR_II,MOT_EMAIL,MOT_FLG_SERASA,MOT_FLG_CRIMINAL")] MOTORISTA mOTORISTA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOTORISTA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOTORISTA);
        }

        // GET: MOTORISTAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOTORISTA mOTORISTA = db.MOTORISTAs.Find(id);
            if (mOTORISTA == null)
            {
                return HttpNotFound();
            }
            return View(mOTORISTA);
        }

        // POST: MOTORISTAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOTORISTA mOTORISTA = db.MOTORISTAs.Find(id);
            db.MOTORISTAs.Remove(mOTORISTA);
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
