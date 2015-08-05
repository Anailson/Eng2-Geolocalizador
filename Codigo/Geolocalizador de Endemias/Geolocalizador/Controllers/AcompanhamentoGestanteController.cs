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
    public class AcompanhamentoGestanteController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IAcompanhamentoGestantes acompanhamentoGestantes { get; set; }

        //
        // GET: /Domicilio/
        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Index()
        {
            List<AcompanhamentoGestante> a = acompanhamentoGestantes.Listar().ToList<AcompanhamentoGestante>();
            return View(a);
        }

        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Inserir()
        {
            return View();
        }


        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Detalhes(int id)
        {
            AcompanhamentoGestante acompanhamentoGestante = acompanhamentoGestantes.ResultadoUnico(id);
            return View(acompanhamentoGestante);
        }


        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Editar(int id)
        {
            AcompanhamentoGestante acompanhamentoGestante = acompanhamentoGestantes.ResultadoUnico(id);
            return View(acompanhamentoGestante);
        }

        public ActionResult Cadastrar(AcompanhamentoGestante acompanhamentoGestante)
        {
            acompanhamentoGestantes.Cadastrar(acompanhamentoGestante);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(AcompanhamentoGestante acompanhamentoGestante)
        {
            acompanhamentoGestantes.Atualizar(acompanhamentoGestante);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Remover(int id)
        {
            AcompanhamentoGestante acompanhamentoGestante = acompanhamentoGestantes.ResultadoUnico(id);
            return View(acompanhamentoGestante);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(AcompanhamentoGestante acompanhamentoGestante)
        {
            acompanhamentoGestantes.Remover(acompanhamentoGestante);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                acompanhamentoGestantes = acompanhamentoGestantes.Listar().ToList(),
            });
        }
    }
}
