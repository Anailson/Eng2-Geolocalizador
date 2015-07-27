using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class Domicilio
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Nº do domicilio")]
        public int codigo { get; set; }

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

        [Required]
        [Display(Name = "Rua")]
        public string rua { get; set; }

        [Required]
        [Display(Name = "Número")]
        public string numero { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Required]
        [Display(Name = "Situação de moradia")]
        public string situacaoMoradia { set; get; }

        [Required]
        [Display(Name = "Tipo de moradia")]
        public string tipoMoradia { set; get; }

        [Required]
        [Display(Name = "Localização")]
        public string localizacao { set; get; }

        [Required]
        [Display(Name = "Condição rural")]
        public string condicaoRural { set; get; }

        [Required]
        [Display(Name = "Acesso ao domicilio")]
        public string acessoDomicilio { set; get; }

        [Required]
        [Display(Name = "Material do domicilio")]
        public string material { set; get; }

        [Required]
        [Display(Name = "Nº do prontuário familiar")]
        public int numProntuario { get; set; }

        [Required]
        [Display(Name = "Nº SUS do Responsavel")]
        public int susResponsavel { get; set; }

        [Required]
        [Display(Name = "Data de nascimento do responsável")]
        public DateTime nascimentoResponsavel { get; set; }

        [Required]
        [Display(Name = "Renda familiar")]
        public int rendaFamiliar { get; set; }

        [Required]
        [Display(Name = "Nº de membros da familia")]
        public int numMembro { get; set; }

        [Required]
        [Display(Name = "Nº de cômodos")]
        public int quantComodos { set; get; }

        [Required]
        [Display(Name = "Nº de moradores")]
        public int quantMoradores { set; get; }

        [Required]
        [Display(Name = "Energia elétrica")]
        public string energiaEletrica { set; get; }

        [Required]
        [Display(Name = "Abastecimento de água")]
        public string abastecimentoAgua { set; get; }

        [Required]
        [Display(Name = "Tratamento de água")]
        public string tratamentoAgua { set; get; }

        [Required]
        [Display(Name = "Escoamento do banheiro")]
        public string escoamentoBanheiro { set; get; }

        [Required]
        [Display(Name = "Lixo")]
        public string lixo { set; get; } 

        public virtual Equipe Equipe { get; set; }
        //public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<Individuo> Individuo { get; set; }
        public virtual ICollection<Cronograma> Cronograma { get; set; }
        public virtual ICollection<Visita> Visita { get; set; }



    }
}
