using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class AcompanhamentoCrianca
    {
        public int id { set; get;}

        [Display(Name = "Nº do Cartão do SUS")]
        public int numSus { set; get;}

        [Display(Name = "Nº da visita")]
        public int codVisita {get; set;}

        [Display(Name = "Desnutrição")]
        public string desnutricao { set; get; } // Alterar de String para Booleano

        [Display(Name = "Pneumonia")]
        public string pneumonia { set; get; } // Alterar de String para Booleano

        [Display(Name = "Diarreia")]
        public string diarreia { set; get; } // Alterar de String para Booleano

        [Display(Name = "Vascinação em dia")]
        public string vacinacaoEmDia { set; get; } // Alterar de String para Booleano

        [Display(Name = "Inflamação respiratória")]
        public string inflamacaoRep { set; get; } // Alterar de String para Booleano

        [Display(Name = "Alimentação")]
        public string alimentacaoPeito { set; get; } // Alterar de String para Booleano

        [Display(Name = "Peso")]
        public int peso { set; get; }

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; } 
    }
}
