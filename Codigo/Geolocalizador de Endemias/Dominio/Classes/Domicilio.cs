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

        [Display(Name = "Nº do domicilio")]
        public int codigo { get; set; }

        [Display(Name = "Cartão do SUS do profissional")]
        public int susProfissional { get; set; }

        [Display(Name = "Cód. CNES Unidade")]
        public int codCNES { get; set; }

        [Display(Name = "Cód. da equipe")]
        public int codEquipe { get; set; }

        [Display(Name = "Micro área")]
        public int microArea { get; set; }

        [Display(Name = "Endereço")]
        public string rua { get; set; }

        [Display(Name = "Número")]
        public string numero { get; set; }

        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Display(Name = "Situação de moradia")]
        public string situacaoMoradia { set; get; }

        [Display(Name = "Tipo de moradia")]
        public string tipoMoradia { set; get; }

        [Display(Name = "Localização")]
        public string localizacao { set; get; }

        [Display(Name = "Condição rural")]
        public string condicaoRural { set; get; }

        [Display(Name = "Acesso ao domicilio")]
        public string acessoDomicilio { set; get; }

        [Display(Name = "Material do domicilio")]
        public string material { set; get; }

        [Display(Name = "Nº do prontuário familiar")]
        public int numProntuario { get; set; }

        [Display(Name = "Nº SUS do Responsavel")]
        public int susResponsavel { get; set; }

        [Display(Name = "Data de nascimento do responsável")]
        public DateTime nascimentoResponsavel { get; set; }

        [Display(Name = "Renda familiar")]
        public int rendaFamiliar { get; set; }

        [Display(Name = "Nº de membros da familia")]
        public int numMembro { get; set; }

        [Display(Name = "Nº de cômodos")]
        public int quantComodos { set; get; }

        [Display(Name = "Nº de moradores")]
        public int quantMoradores { set; get; }

        [Display(Name = "Energia elétrica")]
        public string energiaEletrica { set; get; }

        [Display(Name = "Abastecimento de água")]
        public string abastecimentoAgua { set; get; }

        [Display(Name = "Tratamento de água")]
        public string tratamentoAgua { set; get; }

        [Display(Name = "Escoamento do banheiro")]
        public string escoamentoBanheiro { set; get; }

        [Display(Name = "Lixo")]
        public string lixo { set; get; } 

        public virtual Equipe Equipe { get; set; }
        //public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<Individuo> Individuo { get; set; }
        public virtual ICollection<Cronograma> Cronograma { get; set; }
        public virtual ICollection<Visita> Visita { get; set; }



    }
}
