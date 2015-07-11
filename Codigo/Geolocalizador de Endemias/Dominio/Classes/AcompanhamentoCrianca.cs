using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class AcompanhamentoCrianca
    {
        public int id { set; get;}
        public int numSus { set; get;}
        public int idVisita {get; set;}
        public string desnutricao { set; get; }
        public string pneumonia { set; get; }
        public string diarreia { set; get; }
        public string vacinacaoEmDia { set; get; }
        public string inflamacaoRep { set; get; }
        public string alimentacaoPeito { set; get; }
        public int peso{ set; get; }

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; } 
    }
}
