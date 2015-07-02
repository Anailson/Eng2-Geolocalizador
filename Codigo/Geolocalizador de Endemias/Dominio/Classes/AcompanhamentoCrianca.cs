using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class AcompanhamentoCrianca
    {
        public int susResponsavel { set; get;}
        public Boolean desnutricao { set; get;}
        public Boolean pneumonia { set; get;}
        public Boolean diarreia { set; get; } 
        public Boolean vacinacaoEmDia{ set; get; }
        public Boolean inflamacaoRep { set; get; }
        public Boolean alimentacaoPeito { set; get; }
        public float peso{ set; get; }
    }
}
