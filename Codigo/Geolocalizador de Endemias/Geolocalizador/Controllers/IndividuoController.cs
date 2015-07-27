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
    public class IndividuoController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IIndividuos individuos { get; set; }

        //
        // GET: /Domicilio/
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            List<Individuo> i = individuos.Listar().ToList<Individuo>();
            return View(i);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Inserir()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Detalhes(int id)
        {
            Individuo individuo = individuos.ResultadoUnico(id);
            return View(individuo);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Editar(int id)
        {
            Individuo individuo = individuos.ResultadoUnico(id);
            return View(individuo);
        }

        public ActionResult Cadastrar(Individuo individuo)
        {
            individuos.Cadastrar(individuo);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Individuo individuo)
        {
            individuos.Atualizar(individuo);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Remover(int id)
        {
            Individuo individuo = individuos.ResultadoUnico(id);
            return View(individuo);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Individuo individuo)
        {
            individuos.Remover(individuo);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                individuos = individuos.Listar().ToList(),
            });
        }
    }
}
