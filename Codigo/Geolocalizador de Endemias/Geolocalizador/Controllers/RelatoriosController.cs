using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using Dominio.Interfaces;
using ReportViewerForMvc;

namespace Geolocalizador.Controllers
{
    public class RelatoriosController : Controller
    {
        public IVisitas visitas { get; set; }
        public IAcompanhamentoCriancas acompanhamentoCriancas { get; set; }
        public IAcompanhamentoGestantes acompanhamentoGestantes { get; set; }
        public IAcompanhamentoGestantes acompanhamentoEnfermos { get; set; }

        // GET: Relatorios
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult relatorioVisita()
        {
            ReportViewer reporter = new ReportViewer();
            reporter.ProcessingMode = ProcessingMode.Local;

            reporter.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Views\Relatorios\RelatorioVisita.rdlc";

            reporter.LocalReport.DataSources
                .Add(new ReportDataSource("DataSetGeolocalizador", visitas.Listar()));

            reporter.AsyncRendering = false;
            reporter.SizeToReportContent = true;
            ViewBag.ReporterViewer = reporter;
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult relatorioAcompanhamentoCrianca()
        {
            ReportViewer reporter = new ReportViewer();
            reporter.ProcessingMode = ProcessingMode.Local;

            reporter.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Views\Relatorios\RelatorioAcompanhamentoCrianca.rdlc";

            reporter.LocalReport.DataSources
                .Add(new ReportDataSource("DataSetGeolocalizador", acompanhamentoCriancas.Listar()));

            reporter.AsyncRendering = false;
            reporter.SizeToReportContent = true;
            ViewBag.ReporterViewer = reporter;
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult relatorioAcompanhamentoGestante()
        {
            ReportViewer reporter = new ReportViewer();
            reporter.ProcessingMode = ProcessingMode.Local;

            reporter.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Views\Relatorios\RelatorioAcompanhamentoGestante.rdlc";

            reporter.LocalReport.DataSources
                .Add(new ReportDataSource("DataSetGeolocalizador", acompanhamentoGestantes.Listar()));

            reporter.AsyncRendering = false;
            reporter.SizeToReportContent = true;
            ViewBag.ReporterViewer = reporter;
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult relatorioAcompanhamentoEnfermo()
        {
            ReportViewer reporter = new ReportViewer();
            reporter.ProcessingMode = ProcessingMode.Local;

            reporter.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Views\Relatorios\RelatorioAcompanhamentoEnfermo.rdlc";

            reporter.LocalReport.DataSources
                .Add(new ReportDataSource("DataSetGeolocalizador", acompanhamentoEnfermos.Listar()));

            reporter.AsyncRendering = false;
            reporter.SizeToReportContent = true;
            ViewBag.ReporterViewer = reporter;
            return View();
        }
    }
}