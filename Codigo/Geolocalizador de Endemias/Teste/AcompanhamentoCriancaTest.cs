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
    /// Summary description for AcompanhamentoCriancaTest
    /// </summary>
    [TestClass]
    public class AcompanhamentoCriancaTest
    {
        public AcompanhamentoCrianca crianca { get; set; }
        public IAcompanhamentoCriancas criancas { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            crianca.numSus = 12345;
            crianca.codVisita = 10;
            crianca.desnutricao = "Não";
            crianca.pneumonia = "Não";
            crianca.diarreia = "Sim";
            crianca.vacinacaoEmDia = "Sim";
            crianca.inflamacaoRep = "Não";
            crianca.alimentacaoPeito = "Sim";
            crianca.peso = 20;

            criancas.Cadastrar(crianca);
        }

        //numero do sus e codigo da visita devem existir
        [TestMethod()]
        public void inserirInvalido()
        {
            crianca.numSus = 123459;
            crianca.codVisita = 100;
            crianca.desnutricao = "Não";
            crianca.pneumonia = "Não";
            crianca.diarreia = "Sim";
            crianca.vacinacaoEmDia = "Sim";
            crianca.inflamacaoRep = "Não";
            crianca.alimentacaoPeito = "Sim";
            crianca.peso = 20;

            criancas.Cadastrar(crianca);
        }

        [TestMethod()]
        public void editarValido()
        {
            crianca = criancas.ResultadoUnico(1);
            crianca.numSus = 12345;
            crianca.codVisita = 10;
            crianca.desnutricao = "Sim";
            crianca.pneumonia = "Não";
            crianca.diarreia = "Sim";
            crianca.vacinacaoEmDia = "Sim";
            crianca.inflamacaoRep = "Não";
            crianca.alimentacaoPeito = "Sim";
            crianca.peso = 20;

            criancas.Atualizar(crianca);
        }

        //não pode alterar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            crianca = criancas.ResultadoUnico(1);

            crianca.id = 2;
            crianca.numSus = 12345;
            crianca.codVisita = 10;
            crianca.desnutricao = "Não";
            crianca.pneumonia = "Não";
            crianca.diarreia = "Sim";
            crianca.vacinacaoEmDia = "Sim";
            crianca.inflamacaoRep = "Não";
            crianca.alimentacaoPeito = "Sim";
            crianca.peso = 20;

            criancas.Atualizar(crianca);
        }
    }
}
