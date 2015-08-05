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
    public class AreaController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IAreas areas { get; set; }

        //
        // GET: /Domicilio/
        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Index()
        {
            List<Area> a = areas.Listar().ToList<Area>();
            return View(a);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Inserir()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Detalhes(int id)
        {
            Area area = areas.ResultadoUnico(id);
            return View(area);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Editar(int id)
        {
            Area area = areas.ResultadoUnico(id);
            return View(area);
        }

        public ActionResult Cadastrar(Area area)
        {
            areas.Cadastrar(area);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Area area)
        {
            areas.Atualizar(area);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Remover(int id)
        {
            Area area = areas.ResultadoUnico(id);
            return View(area);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Area area)
        {
            areas.Remover(area);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                areas = areas.Listar().ToList(),
            });
        }
    }
}
