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
    /// Summary description for IndividuoTest
    /// </summary>
    [TestClass]
    public class IndividuoTest
    {
        public Individuo individuo { get; set; }
        public IIndividuos individuos { get; set; }

        [TestMethod()]
        public void inserirValido()
        {
            individuo.codDomicilio = 10;
            individuo.susProfissional = 12345;
            individuo.codCNES = 234;
            individuo.codEquipe = 10;
            individuo.microArea = 1;
            individuo.nome = "Alfredo";
            individuo.numSus = 98765;
            individuo.responsavel = "Sim";
            individuo.susResponsavel = 98765;
            individuo.apelido = "Alfred";
            individuo.nisPis = "765432";
            individuo.dataNascimento = DateTime.Now;
            individuo.sexo= "M";
            individuo.racaCor = "Branca";
            individuo.nomeDaMae = "Marilda";
            individuo.nacionalidade = "Brasileiro";
            individuo.pais = "Chile";
            individuo.telefone = "9987654";
            individuo.municipio = "Aracaju";
            individuo.uf = "São Lorenço";
            individuo.email = "alfred@outlook.com";
            individuo.situacaoDeRua = "sim";
            individuo.tempoSituacaoRua = 2;
            individuo.acompanhamento= "Não";
            individuo.nomeInstituicao = "";
            individuo.beneficiario = "Sim";
            individuo.referenciaFamiliar = "Não";
            individuo.visitaFamiliar = "Não";
            individuo.frequenciaVisita = "";
            individuo.situacaoConj = "casado";
            individuo.ocupacao = "trabalhando";
            individuo.maiorCurso = "Ensino Médio";
            individuo.criancaResponsavel = "Adolescente";
            individuo.curandeiro = "Não";
            individuo.grupoComunitario = "Não";
            individuo.planoSaude = "Sim";
            individuo.comunidadeTradicional = "Não";
            individuo.nomeComunidade = "";
            individuo.informarOrientacao = "Sim";
            individuo.orientacaoSexual = "Heterosexual";

            individuos.Cadastrar(individuo);

        }

        //codigo de domicilio tem que ser valido;
        [TestMethod()]
        public void inserirInvalido()
        {
            individuo.codDomicilio = 100;
            individuo.susProfissional = 12345;
            individuo.codCNES = 234;
            individuo.codEquipe = 10;
            individuo.microArea = 1;
            individuo.nome = "Alfredo";
            individuo.numSus = 98765;
            individuo.responsavel = "Sim";
            individuo.susResponsavel = 98765;
            individuo.apelido = "Alfred";
            individuo.nisPis = "765432";
            individuo.dataNascimento = DateTime.Now;
            individuo.sexo = "M";
            individuo.racaCor = "Branca";
            individuo.nomeDaMae = "Marilda";
            individuo.nacionalidade = "Brasileiro";
            individuo.pais = "Chile";
            individuo.telefone = "9987654";
            individuo.municipio = "Aracaju";
            individuo.uf = "São Lorenço";
            individuo.email = "alfred@outlook.com";
            individuo.situacaoDeRua = "sim";
            individuo.tempoSituacaoRua = 2;
            individuo.acompanhamento = "Não";
            individuo.nomeInstituicao = "";
            individuo.beneficiario = "Sim";
            individuo.referenciaFamiliar = "Não";
            individuo.visitaFamiliar = "Não";
            individuo.frequenciaVisita = "";
            individuo.situacaoConj = "casado";
            individuo.ocupacao = "trabalhando";
            individuo.maiorCurso = "Ensino Médio";
            individuo.criancaResponsavel = "Adolescente";
            individuo.curandeiro = "Não";
            individuo.grupoComunitario = "Não";
            individuo.planoSaude = "Sim";
            individuo.comunidadeTradicional = "Não";
            individuo.nomeComunidade = "";
            individuo.informarOrientacao = "Sim";
            individuo.orientacaoSexual = "Heterosexual";

            individuos.Cadastrar(individuo);

        }

        [TestMethod()]
        public void editarValido()
        {
            individuo = individuos.ResultadoUnico(1);

            individuo.codDomicilio = 10;
            individuo.susProfissional = 12345;
            individuo.codCNES = 234;
            individuo.codEquipe = 10;
            individuo.microArea = 1;
            individuo.nome = "Alfredo João";
            individuo.numSus = 98765;
            individuo.responsavel = "Sim";
            individuo.susResponsavel = 98765;
            individuo.apelido = "Alfred";
            individuo.nisPis = "765432";
            individuo.dataNascimento = DateTime.Now;
            individuo.sexo = "M";
            individuo.racaCor = "Branca";
            individuo.nomeDaMae = "Marilda";
            individuo.nacionalidade = "Brasileiro";
            individuo.pais = "Chile";
            individuo.telefone = "9987654";
            individuo.municipio = "Aracaju";
            individuo.uf = "São Lorenço";
            individuo.email = "alfred@outlook.com";
            individuo.situacaoDeRua = "sim";
            individuo.tempoSituacaoRua = 2;
            individuo.acompanhamento = "Não";
            individuo.nomeInstituicao = "";
            individuo.beneficiario = "Sim";
            individuo.referenciaFamiliar = "Não";
            individuo.visitaFamiliar = "Não";
            individuo.frequenciaVisita = "";
            individuo.situacaoConj = "casado";
            individuo.ocupacao = "trabalhando";
            individuo.maiorCurso = "Ensino Médio";
            individuo.criancaResponsavel = "Adolescente";
            individuo.curandeiro = "Não";
            individuo.grupoComunitario = "Não";
            individuo.planoSaude = "Sim";
            individuo.comunidadeTradicional = "Não";
            individuo.nomeComunidade = "";
            individuo.informarOrientacao = "Sim";
            individuo.orientacaoSexual = "Heterosexual";

            individuos.Atualizar(individuo);

        }

        //não se pode alterar a chave primaria
        [TestMethod()]
        public void editarInvalido()
        {
            individuo = individuos.ResultadoUnico(1);

            individuo.codDomicilio = 10;
            individuo.susProfissional = 12345;
            individuo.codCNES = 234;
            individuo.codEquipe = 10;
            individuo.microArea = 1;
            individuo.nome = "Alfredo João";
            individuo.numSus = 987659;
            individuo.responsavel = "Sim";
            individuo.susResponsavel = 98765;
            individuo.apelido = "Alfred";
            individuo.nisPis = "765432";
            individuo.dataNascimento = DateTime.Now;
            individuo.sexo = "M";
            individuo.racaCor = "Branca";
            individuo.nomeDaMae = "Marilda";
            individuo.nacionalidade = "Brasileiro";
            individuo.pais = "Chile";
            individuo.telefone = "9987654";
            individuo.municipio = "Aracaju";
            individuo.uf = "São Lorenço";
            individuo.email = "alfred@outlook.com";
            individuo.situacaoDeRua = "sim";
            individuo.tempoSituacaoRua = 2;
            individuo.acompanhamento = "Não";
            individuo.nomeInstituicao = "";
            individuo.beneficiario = "Sim";
            individuo.referenciaFamiliar = "Não";
            individuo.visitaFamiliar = "Não";
            individuo.frequenciaVisita = "";
            individuo.situacaoConj = "casado";
            individuo.ocupacao = "trabalhando";
            individuo.maiorCurso = "Ensino Médio";
            individuo.criancaResponsavel = "Adolescente";
            individuo.curandeiro = "Não";
            individuo.grupoComunitario = "Não";
            individuo.planoSaude = "Sim";
            individuo.comunidadeTradicional = "Não";
            individuo.nomeComunidade = "";
            individuo.informarOrientacao = "Sim";
            individuo.orientacaoSexual = "Heterosexual";

            individuos.Atualizar(individuo);

        }
    }
}
