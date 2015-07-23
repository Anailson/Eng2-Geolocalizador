using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class AcompanhamentoGestante
    {

        public int id { set; get; }

        [Display(Name = "Nº do Cartão do SUS")]
        public int numSus { set; get; }

        [Display(Name = "Nº da visita")]
        public int codVisita {get; set;}

        [Display(Name = "Pré natal")]
        public string prenatalMensal { set; get; } // Alterar de String para Booleano

        [Display(Name = "Semanas de gestação")]
        public int semanasGestacao{ set; get; }

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; }
    }
}
