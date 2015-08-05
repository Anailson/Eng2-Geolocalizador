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
    public class EquipeController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IEquipes equipes { get; set; }

        //
        // GET: /Domicilio/
        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Index()
        {
            List<Equipe> e = equipes.Listar().ToList<Equipe>();
            return View(e);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Inserir()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Detalhes(int id)
        {
            Equipe equipe = equipes.ResultadoUnico(id);
            return View(equipe);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Editar(int id)
        {
            Equipe equipe = equipes.ResultadoUnico(id);
            return View(equipe);
        }

        public ActionResult Cadastrar(Equipe equipe)
        {
            equipes.Cadastrar(equipe);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Equipe equipe)
        {
            equipes.Atualizar(equipe);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Remover(int id)
        {
            Equipe equipe = equipes.ResultadoUnico(id);
            return View(equipe);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Equipe equipe)
        {
            equipes.Remover(equipe);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                equipes = equipes.Listar().ToList(),
            });
        }
    }
}
