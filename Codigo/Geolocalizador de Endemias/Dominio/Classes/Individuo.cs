using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class Individuo
    {
        public int id { get; set; }

        [Display(Name = "Nº do Domicilio")]
        public int codDomicilio { get; set; }

        [Display(Name = "Cartão do SUS do profissional")]
        public int susProfissional { get; set; }

        [Display(Name = "Cód. CNES Unidade")]
        public int codCNES { get; set; }

        [Display(Name = "Cód. da equipe")]
        public int codEquipe { get; set; }

        [Display(Name = "Micro área")]
        public int microArea { get; set; }

        [Display(Name = "Nome completo")]
        public string nome { get; set; }

        [Display(Name = "Cartão do SUS")]
        public int numSus { get; set; }

        [Display(Name = "Responsavel")]
        public string responsavel { get; set; }

        [Display(Name = "Cartão do SUS")]
        public int susResponsavel { get; set; }

        [Display(Name = "Apelido / Nome social")]
        public string apelido { get; set; }

        [Display(Name = "NIS (PIS / PASEP)")]
        public string nisPis { set; get; }

        [Display(Name = "Data de nascimento")]
        public DateTime dataNascimento { get; set; }

        [Display(Name = "Sexo")]
        public string sexo { set; get; }

        [Display(Name = "Raça / Cor")]
        public string racaCor { set; get; }

        [Display(Name = "Nome completo da mãe")]
        public string nomeDaMae { set; get; }

        [Display(Name = "Nacionalidade")]
        public string nacionalidade { set; get; }

        [Display(Name = "País de nascimento")]
        public string pais { set; get; }

        [Display(Name = "Telefone celular")]
        public string telefone { set; get; }

        [Display(Name = "Municipio")]
        public string municipio { set; get; }

        [Display(Name = "UF de nascimento")]
        public string uf { set; get; }

        [Display(Name = "E-mail")]
        public string email { set; get; }

        [Display(Name = "Situação de rua")]
        public string situacaoDeRua { set; get; }

        [Display(Name = "Tempo em situação de rua")]
        public int tempoSituacaoRua { get; set; }

        [Display(Name = "Acompanhamento por instituição")]
        public string acompanhamento { get; set; }

        [Display(Name = "Nome da instituição")]
        public string nomeInstituicao { get; set; }

        [Display(Name = "Benificiário")]
        public string beneficiario { get; set; }

        [Display(Name = "Referência familiar")]
        public string referenciaFamiliar { get; set; }

        [Display(Name = "Visita familiar")]
        public string visitaFamiliar { get; set; }

        [Display(Name = "Frequência da visita")]
        public string frequenciaVisita { set; get; }

        [Display(Name = "Situação conjugal")]
        public string situacaoConj { set; get; }

        [Display(Name = "Ocupação")]
        public string ocupacao { set; get; }

        [Display(Name = "Nivel escolar")]
        public string maiorCurso { set; get; }

        [Display(Name = "Responsavel pela criança")]
        public string criancaResponsavel { set; get; }

        [Display(Name = "Curandeiro")]
        public string curandeiro { set; get; }

        [Display(Name = "Grupo comunitario")]
        public string grupoComunitario { set; get; }

        [Display(Name = "Plano de saúde")]
        public string planoSaude { set; get; }

        [Display(Name = "Comunidade tradicional")]
        public string comunidadeTradicional { set; get; }

        [Display(Name = "Nome da comunidade")]
        public string nomeComunidade { set; get; }

        [Display(Name = "Informar orientação sexual")]
        public string informarOrientacao { set; get; }

        [Display(Name = "Orientação sexual")]
        public string orientacaoSexual { set; get; }


       
      
        public virtual Domicilio Domicilio { get; set; }
      //  public virtual Equipe Equipe { get; set; }
     //public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<AcompanhamentoCrianca> AcompanhamentoCrianca { get; set; }
        public virtual ICollection<AcompanhamentoGestante> AcompanhamentoGestante { get; set; }
        public virtual ICollection<AcompanhamentoEnfermo> AcompanhamentoEnfermo { get; set; }
    }
}
