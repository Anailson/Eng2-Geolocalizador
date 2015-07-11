using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;
using Dominio.Interfaces;
using Infraestrutura.Database;

namespace Infraestrutura.Repositorio
{
    public class AcompanhamentoCriancas: IAcompanhamentoCriancas
    {

        private IQueryable<AcompanhamentoCrianca> acompanhamentoCriancas;
        private IGeolocalizador unidadeTrabalho;

        private  AcompanhamentoCriancas(IQueryable<AcompanhamentoCrianca> acompanhamentoCriancas, IGeolocalizador unidadeTrabalho)
        {
            this.acompanhamentoCriancas = acompanhamentoCriancas;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public AcompanhamentoCriancas(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.AcompanhamentoCriancas, unidadeTrabalho) { }

        public void Cadastrar(AcompanhamentoCrianca acompanhamentoCrianca)
        {
            unidadeTrabalho.RegistrarNovo(acompanhamentoCrianca);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(AcompanhamentoCrianca acompanhamentoCrianca)
        {
            unidadeTrabalho.RegistrarAlterado(acompanhamentoCrianca);
            unidadeTrabalho.Salvar();
        }

        public void Remover(AcompanhamentoCrianca acompanhamentoCrianca)
        {
            unidadeTrabalho.RegistrarRemovido(acompanhamentoCrianca);
            unidadeTrabalho.Salvar();
        }

        public AcompanhamentoCrianca ResultadoUnico(int idAcompanhamentoCrianca)
        {
            return acompanhamentoCriancas.SingleOrDefault(acompanhamentoCrianca => acompanhamentoCrianca.id == idAcompanhamentoCrianca);
        }

        public ICollection<AcompanhamentoCrianca> Listar()
        {
            return acompanhamentoCriancas.OrderBy(a => a.id).ToList();
        }

        public bool ContemRegistro()
        {
            throw new NotImplementedException();
        }

        public int TotalRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
