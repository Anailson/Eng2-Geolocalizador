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
        public ActionResult Index()
        {
            List<AcompanhamentoCrianca> a = acompanhamentoCriancas.Listar().ToList<AcompanhamentoCrianca>();
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
            AcompanhamentoCrianca acompanhamentoCrianca = acompanhamentoCriancas.ResultadoUnico(id);
            return View(acompanhamentoCrianca);
        }


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
