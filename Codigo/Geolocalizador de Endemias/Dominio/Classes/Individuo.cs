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
        public string nome { set; get; }
        public string numSus { set; get; }
        public string apelido { set; get; }
        public string nisPis { set; get; }
        public byte sexo { set; get; }
        public string racaCor { set; get; }
        public string nomeDaMae { set; get; }
        public string nacionalidade { set; get; }
        public string pais { set; get; }
        public string telefone { set; get; }
        public string municipio { set; get; }
        public string uf { set; get; }
        public string email { set; get; }
        public string nivelEscolar { set; get; }
        public Boolean situacaoDeRua { set; get; }
        public string situacaoConj { set; get; }
        public string ocupacao { set; get; }
        public string orientacaoSexual { set; get; }
    }
}
