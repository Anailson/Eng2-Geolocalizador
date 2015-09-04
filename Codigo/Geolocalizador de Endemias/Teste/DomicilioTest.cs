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
    /// Summary description for DomicilioTest
    /// </summary>
    [TestClass]
    public class DomicilioTest
    {
        public Domicilio domicilio { get; set; }
        public IDomicilios domicilios { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
             domicilio.codigo = 20;
             domicilio.susProfissional = 12345;
             domicilio.codCNES = 234;
             domicilio.codEquipe = 10;
             domicilio. microArea = 1;
             domicilio.rua = "São José";
             domicilio.numero= "34";
             domicilio.bairro = "São Raimundo";
             domicilio.situacaoMoradia = "Casa";
             domicilio.tipoMoradia = "Apartamento";
             domicilio.localizacao = "Centro";
             domicilio.condicaoRural = "sim";
             domicilio.acessoDomicilio = "Asfalto";
             domicilio.material = "Cimento";
             domicilio.numProntuario = 10;
             domicilio.susResponsavel = 786544;
             domicilio.nascimentoResponsavel = DateTime.Now;
             domicilio.rendaFamiliar = 1000;
             domicilio.numMembro = 2;
             domicilio.quantComodos = 2;
             domicilio.quantMoradores = 2;
             domicilio.energiaEletrica = "sim";
             domicilio.abastecimentoAgua = "sim";
             domicilio.tratamentoAgua = "sim";
             domicilio.escoamentoBanheiro = "sim";
             domicilio.lixo = "sim";

             domicilios.Cadastrar(domicilio);
        }

        //o codigo da Micro area deve ser valido
        [TestMethod()]
        public void inserirInvalido()
        {
            domicilio.codigo = 20;
            domicilio.susProfissional = 12345;
            domicilio.codCNES = 234;
            domicilio.codEquipe = 10;
            domicilio.microArea = 20;
            domicilio.rua = "São José";
            domicilio.numero = "34";
            domicilio.bairro = "São Raimundo";
            domicilio.situacaoMoradia = "Casa";
            domicilio.tipoMoradia = "Apartamento";
            domicilio.localizacao = "Centro";
            domicilio.condicaoRural = "sim";
            domicilio.acessoDomicilio = "Asfalto";
            domicilio.material = "Cimento";
            domicilio.numProntuario = 10;
            domicilio.susResponsavel = 786544;
            domicilio.nascimentoResponsavel = DateTime.Now;
            domicilio.rendaFamiliar = 1000;
            domicilio.numMembro = 2;
            domicilio.quantComodos = 2;
            domicilio.quantMoradores = 2;
            domicilio.energiaEletrica = "sim";
            domicilio.abastecimentoAgua = "sim";
            domicilio.tratamentoAgua = "sim";
            domicilio.escoamentoBanheiro = "sim";
            domicilio.lixo = "sim";

            domicilios.Cadastrar(domicilio);
        }

        [TestMethod()]
        public void editarValido()
        {
            domicilio = domicilios.ResultadoUnico(1);

            domicilio.codigo = 20;
            domicilio.susProfissional = 12345;
            domicilio.codCNES = 234;
            domicilio.codEquipe = 10;
            domicilio.microArea = 1;
            domicilio.rua = "São José";
            domicilio.numero = "64";
            domicilio.bairro = "São Raimundo";
            domicilio.situacaoMoradia = "Casa";
            domicilio.tipoMoradia = "Apartamento";
            domicilio.localizacao = "Centro";
            domicilio.condicaoRural = "sim";
            domicilio.acessoDomicilio = "Asfalto";
            domicilio.material = "Cimento";
            domicilio.numProntuario = 10;
            domicilio.susResponsavel = 786544;
            domicilio.nascimentoResponsavel = DateTime.Now;
            domicilio.rendaFamiliar = 1000;
            domicilio.numMembro = 2;
            domicilio.quantComodos = 2;
            domicilio.quantMoradores = 2;
            domicilio.energiaEletrica = "sim";
            domicilio.abastecimentoAgua = "sim";
            domicilio.tratamentoAgua = "sim";
            domicilio.escoamentoBanheiro = "sim";
            domicilio.lixo = "sim";

            domicilios.Atualizar(domicilio);
        }

        //Não pode editar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            domicilio = domicilios.ResultadoUnico(1);

            domicilio.codigo = 30;
            domicilio.susProfissional = 12345;
            domicilio.codCNES = 234;
            domicilio.codEquipe = 10;
            domicilio.microArea = 1;
            domicilio.rua = "São José";
            domicilio.numero = "64";
            domicilio.bairro = "São Raimundo";
            domicilio.situacaoMoradia = "Casa";
            domicilio.tipoMoradia = "Apartamento";
            domicilio.localizacao = "Centro";
            domicilio.condicaoRural = "sim";
            domicilio.acessoDomicilio = "Asfalto";
            domicilio.material = "Cimento";
            domicilio.numProntuario = 10;
            domicilio.susResponsavel = 786544;
            domicilio.nascimentoResponsavel = DateTime.Now;
            domicilio.rendaFamiliar = 1000;
            domicilio.numMembro = 2;
            domicilio.quantComodos = 2;
            domicilio.quantMoradores = 2;
            domicilio.energiaEletrica = "sim";
            domicilio.abastecimentoAgua = "sim";
            domicilio.tratamentoAgua = "sim";
            domicilio.escoamentoBanheiro = "sim";
            domicilio.lixo = "sim";

            domicilios.Atualizar(domicilio);
        }
    }
}
