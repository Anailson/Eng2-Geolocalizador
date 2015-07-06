using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Classes;
using Dominio.Interfaces;

namespace Geolocalizador.Controllers
{
    public class IndividuoController : Controller
    {
        public IIndividuos individuos { get; set; }

        //
        // GET: /Domicilio/
        public ActionResult Index()
        {
            List<Individuo> i = individuos.Listar().ToList<Individuo>();
            return View(i);
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
