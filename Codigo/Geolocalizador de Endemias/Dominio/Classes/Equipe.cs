using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class Equipe
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Nº da equipe")]
        public int codigo {get; set;}

        [Required]
        [Display(Name = "Nº do SUS")]
        public int numSus {get; set;}

        [Required]
        [Display(Name = "Nº da micro área")]
        public int codMicroArea { get; set; }

        [Required]
        [Display(Name = "Função")]
        public string funcao { get; set; }

        public virtual ICollection<Domicilio> Domicilio { get; set; }
        public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<Individuo> Individuo { get; set; }
  
    }
}
