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
        public DateTime dataVisita { get; set;}
        public DateTime dataProxVisita { get; set;}
        public string resumo { get; set;}
        public string detalhes { get; set;}
    }
}
