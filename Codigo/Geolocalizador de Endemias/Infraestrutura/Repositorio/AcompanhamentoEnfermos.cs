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
    public class AcompanhamentoEnfermos: IAcompanhamentoEnfermos
    {

        private IQueryable<AcompanhamentoEnfermo> acompanhamentoEnfermos;
        private IGeolocalizador unidadeTrabalho;

        private  AcompanhamentoEnfermos(IQueryable<AcompanhamentoEnfermo> acompanhamentoEnfermos, IGeolocalizador unidadeTrabalho)
        {
            this.acompanhamentoEnfermos = acompanhamentoEnfermos;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public AcompanhamentoEnfermos(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.AcompanhamentoEnfermos, unidadeTrabalho) { }

        public void Cadastrar(AcompanhamentoEnfermo acompanhamentoEnfermo)
        {
            unidadeTrabalho.RegistrarNovo(acompanhamentoEnfermo);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(AcompanhamentoEnfermo acompanhamentoEnfermo)
        {
            unidadeTrabalho.RegistrarAlterado(acompanhamentoEnfermo);
            unidadeTrabalho.Salvar();
        }

        public void Remover(AcompanhamentoEnfermo acompanhamentoEnfermo)
        {
            unidadeTrabalho.RegistrarRemovido(acompanhamentoEnfermo);
            unidadeTrabalho.Salvar();
        }

        public AcompanhamentoEnfermo ResultadoUnico(int idAcompanhamentoEnfermo)
        {
            return acompanhamentoEnfermos.SingleOrDefault(acompanhamentoEnfermo => acompanhamentoEnfermo.id == idAcompanhamentoEnfermo);
        }

        public ICollection<AcompanhamentoEnfermo> Listar()
        {
            return acompanhamentoEnfermos.OrderBy(a => a.id).ToList();
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
