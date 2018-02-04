﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LoginConsulta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DefinirLinguagemPadrao();
            return View();
        }

        //private void DefinirLinguagemPadrao()
        //{
        //    if (Request.Cookies[Cookie.LinguagemSelecionada] != null)
        //    {
        //        return;
        //    }

        //    var linguagem = CulturaHelpers.LinguagemPadrao;

        //    if (Request.UserLanguages != null &&
        //        Request.UserLanguages[0] != string.Empty)
        //    {
        //        linguagem = Request.UserLanguages[0];
        //    }

        //    var linguagemSelecionadaCookie =
        //        new HttpCookie(Cookie.LinguagemSelecionada, linguagem);
        //    linguagemSelecionadaCookie.Expires = DateTime.MaxValue;
        //    Response.Cookies.Add(linguagemSelecionadaCookie);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult DefinirLinguagem(string linguagem)
        //{
        //    Response.Cookies[Cookie.LinguagemSelecionada].Value = linguagem;
        //    return Redirect(Request.UrlReferrer.ToString());
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}