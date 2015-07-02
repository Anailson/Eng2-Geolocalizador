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
        public int susProfissional{ set; get; }
        public string rua { set; get; }
        public int numero { set; get; }
        public string bairro { set; get; }
        public char situacaoMoradia{ set; get; }
        public char tipoMoradia { set; get; }
        public int quantComodos { set; get; }
        public int quantmoradores { set; get; }
        public Boolean energiaEletrica { set; get; }
        public char abastecimentoAgua { set; get; }
    }
}
