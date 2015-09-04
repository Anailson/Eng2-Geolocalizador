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
    /// Summary description for AcompanhamentoGestanteTest
    /// </summary>
    [TestClass]
    public class AcompanhamentoGestanteTest
    {
        public AcompanhamentoGestante gestante { get; set; }
        public IAcompanhamentoGestantes gestantes { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            gestante.numSus = 12345;
            gestante.codVisita = 10;
            gestante.prenatalMensal = "Sim";
            gestante.semanasGestacao = 5;

            gestantes.Cadastrar(gestante);

        }

        //numero do sus e codigo de visita devem ser validos
        [TestMethod()]
        public void inserirIvnalido()
        {
            gestante.numSus = 123458;
            gestante.codVisita = 100;
            gestante.prenatalMensal = "Sim";
            gestante.semanasGestacao = 5;

            gestantes.Cadastrar(gestante);

        }

        [TestMethod()]
        public void editarValido()
        {
            gestante = gestantes.ResultadoUnico(1);
            gestante.numSus = 12345;
            gestante.codVisita = 10;
            gestante.prenatalMensal = "Sim";
            gestante.semanasGestacao = 8;

            gestantes.Atualizar(gestante);

        }

        //não pode alterar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            gestante = gestantes.ResultadoUnico(1);
            gestante.id = 2;
            gestante.numSus = 12345;
            gestante.codVisita = 10;
            gestante.prenatalMensal = "Sim";
            gestante.semanasGestacao = 8;

            gestantes.Atualizar(gestante);

        }
    }
}
