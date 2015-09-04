using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Classes;
using Dominio.Interfaces;

namespace Teste
{
    /// <summary>
    /// Summary description for VisitaTest
    /// </summary>
    [TestClass]
    public class VisitaTest
    {
        public Visita visita { get; set; }
        public IVisitas visitas { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            visita.codigo = 10;
            visita.codDomicilio = 10;
            visita.dataVisita = DateTime.Now;
            visita.dataProxVisita = DateTime.Today;
            visita.melhorHorario = "manhã";
            visita.resumo = "Tudo bem";
            visita.detalhes = "Só tomar bastante agua";

            visitas.Cadastrar(visita);
        }

        //codido de domicilio tem de ser valido
        [TestMethod()]
        public void inserirInvalido()
        {
            visita.codigo = 10;
            visita.codDomicilio = 100;
            visita.dataVisita = DateTime.Now;
            visita.dataProxVisita = DateTime.Today;
            visita.melhorHorario = "manhã";
            visita.resumo = "Tudo bem";
            visita.detalhes = "Só tomar bastante agua";

            visitas.Cadastrar(visita);
        }

        [TestMethod()]
        public void editarValido()
        {
            visita = visitas.ResultadoUnico(1);
            visita.codigo = 10;
            visita.codDomicilio = 10;
            visita.dataVisita = DateTime.Now;
            visita.dataProxVisita = DateTime.Today;
            visita.melhorHorario = "tarde";
            visita.resumo = "Tudo bem";
            visita.detalhes = "Só tomar bastante agua";

            visitas.Atualizar(visita);
        }

        //não pode editar a sua chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            visita = visitas.ResultadoUnico(1);
            visita.codigo = 100;
            visita.codDomicilio = 10;
            visita.dataVisita = DateTime.Now;
            visita.dataProxVisita = DateTime.Today;
            visita.melhorHorario = "tarde";
            visita.resumo = "Tudo bem";
            visita.detalhes = "Só tomar bastante agua";

            visitas.Atualizar(visita);
        }
   
    }
}
