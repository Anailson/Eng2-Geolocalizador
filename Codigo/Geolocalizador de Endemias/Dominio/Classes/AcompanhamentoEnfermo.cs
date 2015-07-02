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
        public Boolean AcompanhamentoMedico { get; set; }
        public Boolean AcompanhamentoPsico { get; set; }
        public Boolean medicacao {get; set; }
        public Boolean procedimentoCirurgico { get; set;}

    }
}
