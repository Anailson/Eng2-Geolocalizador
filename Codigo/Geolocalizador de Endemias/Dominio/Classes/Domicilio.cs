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
        public int codigo { get; set; }
        public int susProfissional { get; set; }
        public int codCNES { get; set; }
        public int codEquipe { get; set; }
        public int microArea { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string situacaoMoradia { set; get; }
        public string tipoMoradia { set; get; }
        public string localizacao { set; get; } //Falta inserir no banco
        public string condicaoRural { set; get; } //Falta inserir no banco
        public string acessoDomicilio { set; get; } //Falta inserir no banco
        public string material { set; get; } //Falta inserir no banco
        public int numProntuario { get; set; }
        public int susResponsavel { get; set; }
        public DateTime nascimentoResponsavel { get; set; }
        public int rendaFamiliar { get; set; }
        public int numMembro { get; set; }
        public int quantComodos { set; get; }
        public int quantMoradores { set; get; }
        public string energiaEletrica { set; get; }
        public string abastecimentoAgua { set; get; }
        public string tratamentoAgua { set; get; } //Falta inserir no banco
        public string escoamentoBanheiro { set; get; } //Falta inserir no banco
        public string lixo { set; get; } //Falta inserir no banco

        public virtual Equipe Equipe { get; set; }
        public virtual MicroArea MicroArea { get; set; }
        public virtual ICollection<Individuo> Individuo { get; set; }
        public virtual ICollection<Cronograma> Cronograma { get; set; }
        public virtual ICollection<Visita> Visita { get; set; }



    }
}
