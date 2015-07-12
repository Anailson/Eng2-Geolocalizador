using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class AcompanhamentoEnfermo
    {
        public int id { get; set; }
        public int numSus { set; get;}
        public int codVisita {get; set;}
        public int idEnfermidade {get; set;}
        public string acompanhamentoMedico { get; set; }
        public string acompanhamentoPsico { get; set; }
        public string medicacao { get; set; }
        public string procedimentoCirurgico { get; set; }

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; }
        //public virtual Enfermidade Enfermidade {get; set;}

    }
}
