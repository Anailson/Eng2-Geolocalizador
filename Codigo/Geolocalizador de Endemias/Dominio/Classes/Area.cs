using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Area
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public int quantMicroAreas{ set; get; }

        public virtual ICollection<MicroArea> MicroArea { get; set; }
   
    }
}
