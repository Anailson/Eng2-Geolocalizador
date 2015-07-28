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

        [Required]
        [Display(Name = "Nº do Domicilio")]
        public int codDomicilio { get; set; }

        [Required]
        [Display(Name = "Cartão do SUS do profissional")]
        public int susProfissional { get; set; }

        [Required]
        [Display(Name = "Cód. CNES Unidade")]
        public int codCNES { get; set; }

        [Required]
        [Display(Name = "Cód. da equipe")]
        public int codEquipe { get; set; }

        [Required]
        [Display(Name = "Micro área")]
        public int microArea { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Nome completo")]
        public string nome { get; set; }

        [Required]
        [Display(Name = "Cartão do SUS")]
        public int numSus { get; set; }

        [Required, StringLength(4)]
        [Display(Name = "Responsavel")]
        public string responsavel { get; set; }

        [Display(Name = "Cartão do SUS")]
        public int susResponsavel { get; set; }

        [StringLength(20)]
        [Display(Name = "Apelido / Nome social")]
        public string apelido { get; set; }

        [StringLength(15)]
        [Display(Name = "NIS (PIS / PASEP)")]
        public string nisPis { set; get; }

        [Required]
        [Display(Name = "Data de nascimento")]
        public DateTime dataNascimento { get; set; }

        [Required, StringLength(1)]
        [Display(Name = "Sexo")]
        public string sexo { set; get; }

        [Required, StringLength(15)]
        [Display(Name = "Raça / Cor")]
        public string racaCor { set; get; }

        [Required, StringLength(50)]
        [Display(Name = "Nome completo da mãe")]
        public string nomeDaMae { set; get; }

        [Required, StringLength(20)]
        [Display(Name = "Nacionalidade")]
        public string nacionalidade { set; get; }

        [Required, StringLength(20)]
        [Display(Name = "País de nascimento")]
        public string pais { set; get; }

        [StringLength(15)]
        [Display(Name = "Telefone celular")]
        public string telefone { set; get; }

        [Required, StringLength(20)]
        [Display(Name = "Municipio")]
        public string municipio { set; get; }

        [Required, StringLength(20)]
        [Display(Name = "UF de nascimento")]
        public string uf { set; get; }

        [EmailAddress, StringLength(50)]
        [Display(Name = "E-mail")]
        public string email { set; get; }

        [Required, StringLength(30)]
        [Display(Name = "Situação de rua")]
        public string situacaoDeRua { set; get; }

        [Display(Name = "Tempo em situação de rua")]
        public int tempoSituacaoRua { get; set; }

        [Required, StringLength(4)]
        [Display(Name = "Acompanhamento por instituição")]
        public string acompanhamento { get; set; }

        [StringLength(30)]
        [Display(Name = "Nome da instituição")]
        public string nomeInstituicao { get; set; }

        [Required, StringLength(4)]
        [Display(Name = "Benificiário")]
        public string beneficiario { get; set; }

        [Required, StringLength(4)]
        [Display(Name = "Referência familiar")]
        public string referenciaFamiliar { get; set; }

        [Required, StringLength(4)]
        [Display(Name = "Visita familiar")]
        public string visitaFamiliar { get; set; }

        [StringLength(20)]
        [Display(Name = "Frequência da visita")]
        public string frequenciaVisita { set; get; }

        [Required, StringLength(50)]
        [Display(Name = "Situação conjugal")]
        public string situacaoConj { set; get; }

        [Required, StringLength(30)]
        [Display(Name = "Ocupação")]
        public string ocupacao { set; get; }

        [Required, StringLength(100)]
        [Display(Name = "Nivel escolar")]
        public string maiorCurso { set; get; }

        [Required, StringLength(30)]
        [Display(Name = "Responsavel pela criança")]
        public string criancaResponsavel { set; get; }

        [Required, StringLength(4)]
        [Display(Name = "Curandeiro")]
        public string curandeiro { set; get; }

        [Required, StringLength(4)]
        [Display(Name = "Grupo comunitario")]
        public string grupoComunitario { set; get; }

        [Required, StringLength(4)]
        [Display(Name = "Plano de saúde")]
        public string planoSaude { set; get; }

        [Required, StringLength(4)]
        [Display(Name = "Comunidade tradicional")]
        public string comunidadeTradicional { set; get; }

        [StringLength(30)]
        [Display(Name = "Nome da comunidade")]
        public string nomeComunidade { set; get; }

        [Required, StringLength(4)]
        [Display(Name = "Informar orientação sexual")]
        public string informarOrientacao { set; get; }

        [StringLength(30)]
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
