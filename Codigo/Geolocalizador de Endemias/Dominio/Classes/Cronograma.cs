using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Cronograma
    {
        public int id { get; set; }
        //public int codigo {get; set;}
        public int codDomicilio { get; set; } 
        public DateTime dataInicio{ get; set; }
        public DateTime dataFim { get; set; }
        public string endereco { get; set; }
      

        public virtual Domicilio Domicilio {get; set;}
    }
}
