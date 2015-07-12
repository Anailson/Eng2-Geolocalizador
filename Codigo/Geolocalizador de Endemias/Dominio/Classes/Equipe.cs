using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Equipe
    {
        public int id { get; set; }
        public int codigo {get; set;}
        public int numSus {get; set;}
        public int codMicroArea { get; set; }
        public string funcao { get; set; }

        public virtual ICollection<Domicilio> Domicilio { get; set; }
        public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<Individuo> Individuo { get; set; }
  
    }
}
