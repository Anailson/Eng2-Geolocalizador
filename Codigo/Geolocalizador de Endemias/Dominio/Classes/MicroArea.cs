using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class MicroArea
    {
        public int id { get; set; }

        [Display(Name = "Nº da micro área")]
        public int codigo {get; set;}

        [Display(Name = "Nº da área")]
        public int codArea { get; set; }

        public virtual Area Area { get; set; }
        public virtual ICollection<Domicilio> Domicilio { get; set; }
        public virtual ICollection<Equipe> Equipe { get; set; }
        public virtual ICollection<Individuo> Individuo { get; set; }

    }
}
