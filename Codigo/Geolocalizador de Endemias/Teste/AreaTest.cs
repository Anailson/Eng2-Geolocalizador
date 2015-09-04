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
    /// Summary description for AreaTest
    /// </summary>
    [TestClass]
    public class AreaTest
    {
        public Area area { get; set; }
        public IAreas areas { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            area.codigo = 6;
            area.bairro = "São José";
            area.endereco = "Itabaiana";
            area.nome = "Area 6";
            area.numero = "10";
            area.quantMicroAreas = 5;
            area.telefone = "99876543";

            areas.Cadastrar(area);

        }
        
        //todos os atributos requeridos tem que ser inseridos
        [TestMethod()]
        public void inserirInvalido()
        {
            area.codigo = 7;
            area.bairro = "São José";
            area.endereco = "Itabaiana";
            area.nome = "Area 6";
            area.numero = "10";
            area.telefone = "99876543";

            areas.Cadastrar(area);

        }

        [TestMethod()]
        public void editarValido()
        {
            area = areas.ResultadoUnico(6);
            area.bairro = "Santo Antonio";
            area.endereco = "Itabaiana";
            area.nome = "Area 6";
            area.numero = "10";
            area.quantMicroAreas = 5;
            area.telefone = "99876543";

            areas.Atualizar(area);
        }

        //não pode editar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            area = areas.ResultadoUnico(6);
            area.codigo = 7;
            area.bairro = "Santo Antonio";
            area.endereco = "Itabaiana";
            area.nome = "Area 6";
            area.numero = "10";
            area.quantMicroAreas = 5;
            area.telefone = "99876543";

            areas.Atualizar(area);
        }

    }
}
