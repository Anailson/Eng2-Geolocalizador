using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Domicilio
    {
        public int id { get; set; }
        public string susProfissional { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }

        public virtual ICollection<Individuo> Individuo { get; set; }
        
    }
}
