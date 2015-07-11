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
        public int idDomicilio { get; set;}
        public int susProfissional { get; set; }
        public int codCNES {get; set;}
        public int codEquipe {get; set;}
        public int microArea {get; set;}
        public string nome { get; set; }
        public int numSus { get; set; }
        public int susResponsavel { get; set; }
        public string apelido { get; set; }
        public string nisPis { set; get; }
        public DateTime dataNascimento {get; set;}
        public string sexo { set; get; }
        public string racaCor { set; get; }
        public string nomeDaMae { set; get; }
        public string nacionalidade { set; get; }
        public string pais { set; get; }
        public string telefone { set; get; }
        public string municipio { set; get; }
        public string uf { set; get; }
        public string email { set; get; }
        public string nivelEscolar { set; get; }
        public string situacaoDeRua { set; get; }
        public string situacaoConj { set; get; }
        public string ocupacao { set; get; }
        public string orientacaoSexual { set; get; }

        public virtual Domicilio Domicilio { get; set; }
        public virtual Equipe Equipe { get; set; }
        public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<AcompanhamentoCrianca> AcompanhamentoCrianca { get; set; }
        public virtual ICollection<AcompanhamentoGestante> AcompanhamentoGestante { get; set; }
        public virtual ICollection<AcompanhamentoEnfermo> AcompanhamentoEnfermo { get; set; }
   }
}
