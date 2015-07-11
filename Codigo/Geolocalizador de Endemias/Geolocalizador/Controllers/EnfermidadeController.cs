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
    public class EnfermidadeController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IEnfermidades enfermidades { get; set; }

        //
        // GET: /Domicilio/
        public ActionResult Index()
        {
            List<Enfermidade> e = enfermidades.Listar().ToList<Enfermidade>();
            return View(e);
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
            Enfermidade enfermidade = enfermidades.ResultadoUnico(id);
            return View(enfermidade);
        }


        public ActionResult Editar(int id)
        {
            Enfermidade enfermidade = enfermidades.ResultadoUnico(id);
            return View(enfermidade);
        }

        public ActionResult Cadastrar(Enfermidade enfermidade)
        {
            enfermidades.Cadastrar(enfermidade);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Enfermidade enfermidade)
        {
            enfermidades.Atualizar(enfermidade);
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            Enfermidade enfermidade = enfermidades.ResultadoUnico(id);
            return View(enfermidade);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Enfermidade enfermidade)
        {
            enfermidades.Remover(enfermidade);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                enfermidades = enfermidades.Listar().ToList(),
            });
        }
    }
}
