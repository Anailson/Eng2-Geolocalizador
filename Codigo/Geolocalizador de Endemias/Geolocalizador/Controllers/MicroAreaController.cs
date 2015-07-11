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
    public class MicroAreaController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IMicroAreas microAreas { get; set; }

        //
        // GET: /Domicilio/
        public ActionResult Index()
        {
            List<MicroArea> m = microAreas.Listar().ToList<MicroArea>();
            return View(m);
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
            MicroArea microArea = microAreas.ResultadoUnico(id);
            return View(microArea);
        }


        public ActionResult Editar(int id)
        {
            MicroArea microArea = microAreas.ResultadoUnico(id);
            return View(microArea);
        }

        public ActionResult Cadastrar(MicroArea microArea)
        {
            microAreas.Cadastrar(microArea);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(MicroArea microArea)
        {
            microAreas.Atualizar(microArea);
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            MicroArea microArea = microAreas.ResultadoUnico(id);
            return View(microArea);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(MicroArea microArea)
        {
            microAreas.Remover(microArea);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                microAreas = microAreas.Listar().ToList(),
            });
        }
    }
}