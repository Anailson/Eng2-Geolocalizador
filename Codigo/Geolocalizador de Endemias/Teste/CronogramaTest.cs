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
    /// Summary description for CronogramaTest
    /// </summary>
    [TestClass]
    public class CronogramaTest
    {
        public Cronograma cronograma { get; set; }
        public ICronogramas cronogramas { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            cronograma.codDomicilio = 10;
            cronograma.dataInicio= DateTime.Now;
            cronograma.dataFim = DateTime.Now;
            cronograma.endereco = "Rua São José";

            cronogramas.Cadastrar(cronograma);
      
        }

        //codigo do domicilio tem que ser valido
        [TestMethod()]
        public void inserirInvalido()
        {
            cronograma.codDomicilio = 100;
            cronograma.dataInicio = DateTime.Now;
            cronograma.dataFim = DateTime.Now;
            cronograma.endereco = "Rua São José";

            cronogramas.Cadastrar(cronograma);

        }

        [TestMethod()]
        public void editarValido()
        {
            cronograma = cronogramas.ResultadoUnico(1);
            cronograma.codDomicilio = 10;
            cronograma.dataInicio = DateTime.Now;
            cronograma.dataFim = DateTime.Now;
            cronograma.endereco = "Rua São Lorenço";

            cronogramas.Atualizar(cronograma);

        }

        //não pode alterar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            cronograma = cronogramas.ResultadoUnico(1);
            cronograma.id = 2;
            cronograma.codDomicilio = 10;
            cronograma.dataInicio = DateTime.Now;
            cronograma.dataFim = DateTime.Now;
            cronograma.endereco = "Rua São Lorenço";

            cronogramas.Atualizar(cronograma);

        }
    }
}
