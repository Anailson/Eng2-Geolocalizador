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
        public bool responsavel { get; set; } //Falta inserir no banco
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
        public string nivelEscolar { set; get; }
        public string situacaoDeRua { set; get; }
        public int tempoSituacaoRua { get; set; } //Falta inserir no banco (o valor de entrada é em meses)
        public bool acompanhamento { get; set; } //Falta inserir no banco
        public string nomeInstituicao { get; set; } //Falta inserir no banco
        public bool beneficiario { get; set; } //Falta inserir no banco
        public bool referenciaFamiliar { get; set; } //Falta inserir no banco
        public bool visitaFamiliar { get; set; } //Falta inserir no banco
        public string frequenciaVisita { set; get; } //Falta inserir no banco
        public string situacaoConj { set; get; }
        public string ocupacao { set; get; }
        public string maiorCurso { set; get; } //Falta inserir no banco
        public string criancaResponsavel { set; get; }
        public bool curandeiro { set; get; } //Falta inserir no banco
        public bool grupoComunitario { set; get; } //Falta inserir no banco
        public bool planoSaude { set; get; } //Falta inserir no banco
        public bool comunidadeTradicional { set; get; } //Falta inserir no banco
        public string nomeComunidade { set; get; } //Falta inserir no banco
        public bool informarOrientacao { set; get; } //Falta inserir no banco
        public string orientacaoSexual { set; get; }

        public virtual Domicilio Domicilio { get; set; }
        public virtual Equipe Equipe { get; set; }
        public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<AcompanhamentoCrianca> AcompanhamentoCrianca { get; set; }
        public virtual ICollection<AcompanhamentoGestante> AcompanhamentoGestante { get; set; }
        public virtual ICollection<AcompanhamentoEnfermo> AcompanhamentoEnfermo { get; set; }
    }
}
