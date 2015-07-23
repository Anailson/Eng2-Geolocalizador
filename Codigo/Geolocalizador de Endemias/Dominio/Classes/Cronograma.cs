using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class Cronograma
    {
        public int id { get; set; }

        [Display(Name = "Nº do domicilio")]
        public int codDomicilio { get; set; }

        [Display(Name = "Data inicial")]
        public DateTime dataInicio{ get; set; }

        [Display(Name = "Data final")]
        public DateTime dataFim { get; set; }

        [Display(Name = "Endereço")]
        public string endereco { get; set; }
      

        public virtual Domicilio Domicilio {get; set;}
    }
}
