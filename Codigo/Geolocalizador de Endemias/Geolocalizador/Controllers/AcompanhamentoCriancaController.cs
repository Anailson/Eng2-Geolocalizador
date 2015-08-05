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
    public class AcompanhamentoCriancaController : Controller
    {
        public IGeolocalizador IGeolocalizador { get; set; }
        public IAcompanhamentoCriancas acompanhamentoCriancas { get; set; }

        //
        // GET: /Domicilio/
        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Index()
        {
            List<AcompanhamentoCrianca> a = acompanhamentoCriancas.Listar().ToList<AcompanhamentoCrianca>();
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
            AcompanhamentoCrianca acompanhamentoCrianca = acompanhamentoCriancas.ResultadoUnico(id);
            return View(acompanhamentoCrianca);
        }


        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Editar(int id)
        {
            AcompanhamentoCrianca acompanhamentoCrianca = acompanhamentoCriancas.ResultadoUnico(id);
            return View(acompanhamentoCrianca);
        }

        public ActionResult Cadastrar(AcompanhamentoCrianca acompanhamentoCrianca)
        {
            acompanhamentoCriancas.Cadastrar(acompanhamentoCrianca);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(AcompanhamentoCrianca acompanhamentoCrianca)
        {
            acompanhamentoCriancas.Atualizar(acompanhamentoCrianca);
            return RedirectToAction("Index");
        }


        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Remover(int id)
        {
            AcompanhamentoCrianca acompanhamentoCrianca = acompanhamentoCriancas.ResultadoUnico(id);
            return View(acompanhamentoCrianca);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(AcompanhamentoCrianca acompanhamentoCrianca)
        {
            acompanhamentoCriancas.Remover(acompanhamentoCrianca);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                acompanhamentoCriancas = acompanhamentoCriancas.Listar().ToList(),
            });
        }
    }
}
