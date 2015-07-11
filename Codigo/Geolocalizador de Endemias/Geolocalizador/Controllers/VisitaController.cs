﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Classes;
using Dominio.Interfaces;
using Infraestrutura.Database;

namespace Geolocalizador.Controllers
{
    public class VisitaController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IVisitas visitas { get; set; }

        //
        // GET: /Domicilio/
        public ActionResult Index()
        {
            List<Visita> v = visitas.Listar().ToList<Visita>();
            return View(v);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult Inserir3()
        {
            return View();
        }
        public ActionResult Inserir2()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            Visita visita = visitas.ResultadoUnico(id);
            return View(visita);
        }

        public ActionResult Editar(int id)
        {
            Visita visita = visitas.ResultadoUnico(id);
            return View(visita);
        }

        public ActionResult Cadastrar(Visita visita)
        {
            visitas.Cadastrar(visita);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Visita visita)
        {
            visitas.Atualizar(visita);
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            Visita visita = visitas.ResultadoUnico(id);
            return View(visita);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Visita visita)
        {
            visitas.Remover(visita);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                visitas = visitas.Listar().ToList(),
            });
        }
    }
}
