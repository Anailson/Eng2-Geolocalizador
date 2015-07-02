using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class PostoSaude
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string rua { set; get; }
        public int numero { set; get; }
        public string bairro { set; get; }
        public string telefone{ set; get; }
    }
}
