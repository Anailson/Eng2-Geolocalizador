using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Classes;
using Dominio.Interfaces;
using Infraestrutura.Database;

namespace Geolocalizador.Controllers
{
    public class DomicilioController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IDomicilios domicilios { get; set; }

        //
        // GET: /Domicilio/
        public ActionResult Index()
        {
            List<Domicilio> d = domicilios.Listar().ToList<Domicilio>();
            return View(d);
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
            Domicilio domicilio = domicilios.ResultadoUnico(id);
            return View(domicilio);
        }


        public ActionResult Editar(int id)
        {
            Domicilio domicilio = domicilios.ResultadoUnico(id);
            return View(domicilio);
        }

        public ActionResult Cadastrar(Domicilio domicilio)
        {
            domicilios.Cadastrar(domicilio);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Domicilio domicilio)
        {
            domicilios.Atualizar(domicilio);
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            Domicilio domicilio = domicilios.ResultadoUnico(id);
            return View(domicilio);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Domicilio domicilio)
        {
            domicilios.Remover(domicilio);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                domicilios = domicilios.Listar().ToList(),
            });
        }
    }
}
