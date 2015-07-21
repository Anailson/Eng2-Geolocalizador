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
        public int codDomicilio { get; set; }
        public int susProfissional { get; set; }
        public int codCNES { get; set; }
        public int codEquipe { get; set; }
        public int microArea { get; set; }
        public string nome { get; set; }
        public int numSus { get; set; }
        public string responsavel { get; set; }
        public int susResponsavel { get; set; }
        public string apelido { get; set; }
        public string nisPis { set; get; }
        public DateTime dataNascimento { get; set; }
        public string sexo { set; get; }
        public string racaCor { set; get; }
        public string nomeDaMae { set; get; }
        public string nacionalidade { set; get; }
        public string pais { set; get; }
        public string telefone { set; get; }
        public string municipio { set; get; }
        public string uf { set; get; }
        public string email { set; get; }
        public string situacaoDeRua { set; get; }
        public int tempoSituacaoRua { get; set; } 
        public string acompanhamento { get; set; }
        public string nomeInstituicao { get; set; } 
        public string beneficiario { get; set; } 
        public string referenciaFamiliar { get; set; } 
        public string visitaFamiliar { get; set; }
        public string frequenciaVisita { set; get; } 
        public string situacaoConj { set; get; }
        public string ocupacao { set; get; }
        public string maiorCurso { set; get; } 
        public string criancaResponsavel { set; get; }
        public string curandeiro { set; get; } 
        public string grupoComunitario { set; get; }
        public string planoSaude { set; get; } 
        public string comunidadeTradicional { set; get; } 
        public string nomeComunidade { set; get; } 
        public string informarOrientacao { set; get; } 
        public string orientacaoSexual { set; get; }


       
      
        public virtual Domicilio Domicilio { get; set; }
      //  public virtual Equipe Equipe { get; set; }
     //public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<AcompanhamentoCrianca> AcompanhamentoCrianca { get; set; }
        public virtual ICollection<AcompanhamentoGestante> AcompanhamentoGestante { get; set; }
        public virtual ICollection<AcompanhamentoEnfermo> AcompanhamentoEnfermo { get; set; }
    }
}
