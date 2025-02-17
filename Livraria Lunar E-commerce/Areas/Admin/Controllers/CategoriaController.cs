﻿using Livraria_Lunar_E_commerce.Business;
using Livraria_Lunar_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livraria_Lunar_E_commerce.Areas.Admin.Controllers
{
    public class CategoriaController : Controller
    {

        // GET: Admin/Categoria
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
        public ActionResult Cadastrar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                CategoriaAcoes acCategoria = new CategoriaAcoes();
                acCategoria.Cadastrar(categoria);
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
           
            CategoriaAcoes acCategoria = new CategoriaAcoes();
            return View(acCategoria.Consultar());
        }

        public ActionResult Editar(int id)
        {
            CategoriaAcoes acCategoria = new CategoriaAcoes();
            return View(acCategoria.Consultar().Find(dto => dto.cd_categoria    == id));
        }

        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            
            if (ModelState.IsValid)
            {
                CategoriaAcoes acCategoria = new CategoriaAcoes();
                acCategoria.Alterar(categoria);
                return RedirectToAction("Consultar");
            }
            return View();
        }


        public ActionResult Excluir(int id)
        {
            CategoriaAcoes acCategoria = new CategoriaAcoes();
            int excluir = acCategoria.Excluir(id);
            TempData["Success"] = "Added Successfully!";
            return RedirectToAction("Consultar", "Categoria");
        }

    }

}