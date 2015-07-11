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
    public class AcompanhamentoEnfermoController : Controller
    {

        public IGeolocalizador IGeolocalizador { get; set; }
        public IAcompanhamentoEnfermos acompanhamentoEnfermos { get; set; }

        //
        // GET: /Domicilio/
        public ActionResult Index()
        {
            List<AcompanhamentoEnfermo> a = acompanhamentoEnfermos.Listar().ToList<AcompanhamentoEnfermo>();
            return View(a);
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
            AcompanhamentoEnfermo acompanhamentoEnfermo = acompanhamentoEnfermos.ResultadoUnico(id);
            return View(acompanhamentoEnfermo);
        }


        public ActionResult Editar(int id)
        {
            AcompanhamentoEnfermo acompanhamentoEnfermo = acompanhamentoEnfermos.ResultadoUnico(id);
            return View(acompanhamentoEnfermo);
        }

        public ActionResult Cadastrar(AcompanhamentoEnfermo acompanhamentoEnfermo)
        {
            acompanhamentoEnfermos.Cadastrar(acompanhamentoEnfermo);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(AcompanhamentoEnfermo acompanhamentoEnfermo)
        {
            acompanhamentoEnfermos.Atualizar(acompanhamentoEnfermo);
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            AcompanhamentoEnfermo acompanhamentoEnfermo = acompanhamentoEnfermos.ResultadoUnico(id);
            return View(acompanhamentoEnfermo);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(AcompanhamentoEnfermo acompanhamentoEnfermo)
        {
            acompanhamentoEnfermos.Remover(acompanhamentoEnfermo);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                acompanhamentoEnfermos = acompanhamentoEnfermos.Listar().ToList(),
            });
        }
    }
}
