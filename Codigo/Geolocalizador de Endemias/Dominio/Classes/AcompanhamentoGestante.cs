using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class AcompanhamentoGestante
    {

        public int id { set; get; }
        public int numSus { set; get; }
        public int codVisita {get; set;}
        public string prenatalMensal { set; get; }
        public int semanasGestacao{ set; get; }

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; }
    }
}
