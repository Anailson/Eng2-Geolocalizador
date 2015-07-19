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
        public string acompanhamentoMedico { get; set; } // Alterar de String para Booleano
        public string acompanhamentoPsico { get; set; } // Alterar de String para Booleano
        public string medicacao { get; set; } // Alterar de String para Booleano
        public string procedimentoCirurgico { get; set; } // Alterar de String para Booleano

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; }
        //public virtual Enfermidade Enfermidade {get; set;}

    }
}
