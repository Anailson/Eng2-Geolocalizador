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
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            List<Enfermidade> e = enfermidades.Listar().ToList<Enfermidade>();
            return View(e);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Inserir()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Detalhes(int id)
        {
            Enfermidade enfermidade = enfermidades.ResultadoUnico(id);
            return View(enfermidade);
        }

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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
