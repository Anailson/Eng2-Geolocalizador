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

        // GET: Relatorios
        public ActionResult Index()
        {
            return View();
        }

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

    }
}