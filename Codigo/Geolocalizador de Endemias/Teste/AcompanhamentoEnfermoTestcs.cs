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
    /// Summary description for AcompanhamentoEnfermoTest
    /// </summary>
    [TestClass]
    public class AcompanhamentoEnfermoTestcs
    {
        public AcompanhamentoEnfermo enfermo { get; set; }
        public IAcompanhamentoEnfermos enfermos { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            enfermo.numSus = 12345;
            enfermo.codVisita = 10;
            enfermo.idEnfermidade = 5;
            enfermo.acompanhamentoMedico = "Sim";
            enfermo.acompanhamentoPsico = "Não"; 
            enfermo.medicacao = "Sim";
            enfermo.procedimentoCirurgico = "Não";

            enfermos.Cadastrar(enfermo);
        }

        //numero do sus e codigo da visita devem ser validos
        [TestMethod()]
        public void inserirInvalido()
        {
            enfermo.numSus = 123485;
            enfermo.codVisita = 10;
            enfermo.idEnfermidade = 5;
            enfermo.acompanhamentoMedico = "Sim";
            enfermo.acompanhamentoPsico = "Não";
            enfermo.medicacao = "Sim";
            enfermo.procedimentoCirurgico = "Não";

            enfermos.Cadastrar(enfermo);
        }

        [TestMethod()]
        public void editarValido()
        {
            enfermo = enfermos.ResultadoUnico(1);

            enfermo.numSus = 12345;
            enfermo.codVisita = 10;
            enfermo.idEnfermidade = 5;
            enfermo.acompanhamentoMedico = "Sim";
            enfermo.acompanhamentoPsico = "Não";
            enfermo.medicacao = "Sim";
            enfermo.procedimentoCirurgico = "Não";

            enfermos.Atualizar(enfermo);
        }

        //não pode alterar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            enfermo = enfermos.ResultadoUnico(1);

            enfermo.id = 2;
            enfermo.numSus = 12345;
            enfermo.codVisita = 10;
            enfermo.idEnfermidade = 5;
            enfermo.acompanhamentoMedico = "Sim";
            enfermo.acompanhamentoPsico = "Não";
            enfermo.medicacao = "Sim";
            enfermo.procedimentoCirurgico = "Não";

            enfermos.Atualizar(enfermo);
        }

    }
}
