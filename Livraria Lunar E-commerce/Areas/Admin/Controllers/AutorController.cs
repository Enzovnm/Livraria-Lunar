﻿using Livraria_Lunar_E_commerce.Business;
using Livraria_Lunar_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livraria_Lunar_E_commerce.Areas.Admin.Controllers
{
    public class AutorController : Controller
    {

 
        // GET: Admin/Autor
        public ActionResult Cadastrar()
        {
            if (Session["usuariologado"] == null || Session["senhaLogado"] == null)
            {
                return RedirectToAction("Login", "Login", new { area = "" });
            }

            
            if (Session["tipologado2"] == null && Session["tipologado3"] == null)
            {
                return RedirectToAction("semAcesso", "Login", new { area = "" });
            }
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Autor autor)
        {
            if (ModelState.IsValid)
            {
                AutorAcoes acAutor = new AutorAcoes();
                acAutor.Cadastrar(autor);
                return RedirectToAction("Consultar");
            }

            return View();
        }

        public ActionResult Consultar()
        {
            if (Session["usuariologado"] == null || Session["senhaLogado"] == null)
            {
                return RedirectToAction("Login", "Login", new { area = "" });
            }

            
            if (Session["tipologado2"] == null && Session["tipologado3"] == null)
            {
                return RedirectToAction("semAcesso", "Login", new { area = "" });
            }

            AutorAcoes acAutor = new AutorAcoes();
            return View(acAutor.Consultar());
        }

        public ActionResult Editar(int id)
        {
            AutorAcoes acAutor = new AutorAcoes();
            return View(acAutor.Consultar().Find(dto => dto.cd_autor == id));
        }

        [HttpPost]
        public ActionResult Editar(Autor autor)
        {
            if(ModelState.IsValid)
            {
                AutorAcoes acAutor = new AutorAcoes();
                acAutor.Alterar(autor);
                return RedirectToAction("Consultar"); 
            }

            return View();
        }
    }
}