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
        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Index()
        {
            List<Domicilio> d = domicilios.Listar().ToList<Domicilio>();
            return View(d);
        }

        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Inserir()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Detalhes(int id)
        {
            Domicilio domicilio = domicilios.ResultadoUnico(id);
            return View(domicilio);
        }

        [Authorize(Roles = "Administrator, Operator")]
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

        [Authorize(Roles = "Administrator, Operator")]
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
