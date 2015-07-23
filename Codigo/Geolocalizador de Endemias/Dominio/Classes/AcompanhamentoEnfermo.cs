using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class AcompanhamentoEnfermo
    {
        public int id { get; set; }

        [Display(Name = "Nº do Cartão do SUS")]
        public int numSus { set; get;}

        [Display(Name = "Nº da visita")]
        public int codVisita {get; set;}

        [Display(Name = "Cód da Enfermidade")]
        public int idEnfermidade {get; set;}

        [Display(Name = "Acompanhamento médico")]
        public string acompanhamentoMedico { get; set; } // Alterar de String para Booleano

        [Display(Name = "Acompanhamento psicológico")]
        public string acompanhamentoPsico { get; set; } // Alterar de String para Booleano

        [Display(Name = "Necessidade de medicação")]
        public string medicacao { get; set; } // Alterar de String para Booleano

        [Display(Name = "Procedimento cirúrgico")]
        public string procedimentoCirurgico { get; set; } // Alterar de String para Booleano

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; }
        //public virtual Enfermidade Enfermidade {get; set;}

    }
}
