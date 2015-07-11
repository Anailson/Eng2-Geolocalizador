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
    public class CronogramaController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public ICronogramas cronogramas { get; set; }

        //
        // GET: /Domicilio/
        public ActionResult Index()
        {
            List<Cronograma> c = cronogramas.Listar().ToList<Cronograma>();
            return View(c);
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
            Cronograma cronograma = cronogramas.ResultadoUnico(id);
            return View(cronograma);
        }


        public ActionResult Editar(int id)
        {
            Cronograma cronograma = cronogramas.ResultadoUnico(id);
            return View(cronograma);
        }

        public ActionResult Cadastrar(Cronograma cronograma)
        {
            cronogramas.Cadastrar(cronograma);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Cronograma cronograma)
        {
            cronogramas.Atualizar(cronograma);
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            Cronograma cronograma = cronogramas.ResultadoUnico(id);
            return View(cronograma);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Cronograma cronograma)
        {
            cronogramas.Remover(cronograma);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                cronogramas = cronogramas.Listar().ToList(),
            });
        }
    }
}
