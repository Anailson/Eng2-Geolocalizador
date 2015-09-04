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
    /// Summary description for MicroAreaTest
    /// </summary>
    [TestClass]
    public class MicroAreaTest
    {
        public MicroArea microArea { get; set; }
        public IMicroAreas microAreas { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            microArea.codigo = 5;
            microArea.codArea = 1;

            microAreas.Cadastrar(microArea);
        }

        //Tem que existir uma area criada
        [TestMethod()]
        public void inserirInvalido()
        {
            microArea.codigo = 5;
            microArea.codArea = 20;

            microAreas.Cadastrar(microArea);
        }

        [TestMethod()]
        public void editarValido()
        {
            microArea = microAreas.ResultadoUnico(1);

            microArea.codigo = 5;
            microArea.codArea = 2;

            microAreas.Atualizar(microArea);
        }


        //Não pode alterar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            microArea = microAreas.ResultadoUnico(1);

            microArea.codigo = 6;
            microArea.codArea = 1;

            microAreas.Atualizar(microArea);
        }
    }
}
