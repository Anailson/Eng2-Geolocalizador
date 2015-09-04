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
    /// Summary description for EquipeTest
    /// </summary>
    [TestClass]
    public class EquipeTest
    {
        public Equipe equipe {get; set;}
        public IEquipes equipes {get; set;}

        [TestMethod()]
        public void inserirValido()
        {
            equipe.codigo = 10;
            equipe.numSus = 12345;
            equipe.codMicroArea = 1;
            equipe.funcao = "Médico";

            equipes.Cadastrar(equipe);
        }
       
        //deve existir uma micro area válida
        [TestMethod()]
        public void inserirInvalido()
        {
            equipe.codigo = 10;
            equipe.numSus = 12345;
            equipe.codMicroArea = 20;
            equipe.funcao = "Médico";

            equipes.Cadastrar(equipe);
        }

        [TestMethod()]
        public void editarValido()
        {
            equipe = equipes.ResultadoUnico(1);
            equipe.codigo = 10;
            equipe.numSus = 12345;
            equipe.codMicroArea = 5;
            equipe.funcao = "Médico";

            equipes.Cadastrar(equipe);
        }

        //não pode alterar o codigo, pois é chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            equipe = equipes.ResultadoUnico(1);
            equipe.codigo = 15;
            equipe.numSus = 12345;
            equipe.codMicroArea = 5;
            equipe.funcao = "Médico";

            equipes.Cadastrar(equipe);
        }
    }
}
