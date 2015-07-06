using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Individuo
    {
        public int id { get; set; }
        public int idDomicilio { get; set; }
        public string nome { get; set; }
        public string numSus { get; set; }
        public string apelido { get; set; }
        public string municipio { get; set; }

        public Domicilio Domicilio { get; set; }
   }
}
