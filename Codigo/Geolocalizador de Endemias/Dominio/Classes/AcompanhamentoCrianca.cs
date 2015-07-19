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
        public int codVisita {get; set;}
        public string desnutricao { set; get; } // Alterar de String para Booleano
        public string pneumonia { set; get; } // Alterar de String para Booleano
        public string diarreia { set; get; } // Alterar de String para Booleano
        public string vacinacaoEmDia { set; get; } // Alterar de String para Booleano
        public string inflamacaoRep { set; get; } // Alterar de String para Booleano
        public string alimentacaoPeito { set; get; } // Alterar de String para Booleano
        public int peso { set; get; }

        public virtual Visita Visita { get; set;}
        public virtual Individuo Individuo { get; set; } 
    }
}
