using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Visita
    {
        public int id { get; set; }
        public int codigo {get; set;}
        public int codDomicilio { get; set; }
        public DateTime dataVisita { get; set;}
        public DateTime dataProxVisita { get; set;}
        public string resumo { get; set;}
        public string detalhes { get; set;}
       

        public virtual Domicilio Domicilio {get; set;}
        public virtual ICollection<AcompanhamentoCrianca> AcompanhamentoCrianca {get; set;}
        public virtual ICollection<AcompanhamentoEnfermo> AcompanhamentoEnfermo { get; set; }
        public virtual ICollection<AcompanhamentoGestante> AcompanhamentoGestante { get; set; }

    }
}
