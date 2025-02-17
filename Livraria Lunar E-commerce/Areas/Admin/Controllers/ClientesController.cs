﻿using Livraria_Lunar_E_commerce.Business;
using Livraria_Lunar_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livraria_Lunar_E_commerce.Areas.Admin.Controllers
{
    public class ClientesController : Controller
    {
 
        // GET: Admin/Clientes
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
        public ActionResult Cadastrar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ClientesAcoes acCliente = new ClientesAcoes();
                acCliente.Cadastrar(cliente);
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

            ClientesAcoes acCliente = new ClientesAcoes(); 
            return View(acCliente.Consultar());
        }

        public ActionResult Editar(int id)
        {
            ClientesAcoes acCliente = new ClientesAcoes();
            return View(acCliente.Consultar().Find(dto => dto.cd_cliente == id));
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ClientesAcoes acCliente = new ClientesAcoes();
                acCliente.Alterar(cliente);
                return RedirectToAction("Consultar");
            }
            return View();
        }


        public ActionResult Excluir(int id)
        {
            ClientesAcoes acCliente = new ClientesAcoes();
            acCliente.Excluir(id);
            return RedirectToAction("Consultar");
        }
    }
}