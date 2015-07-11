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
    public class AcompanhamentoGestantes: IAcompanhamentoGestantes
    {

        private IQueryable<AcompanhamentoGestante> acompanhamentoGestantes;
        private IGeolocalizador unidadeTrabalho;

        private  AcompanhamentoGestantes(IQueryable<AcompanhamentoGestante> acompanhamentoGestantes, IGeolocalizador unidadeTrabalho)
        {
            this.acompanhamentoGestantes = acompanhamentoGestantes;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public AcompanhamentoGestantes(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.AcompanhamentoGestantes, unidadeTrabalho) { }

        public void Cadastrar(AcompanhamentoGestante acompanhamentoGestante)
        {
            unidadeTrabalho.RegistrarNovo(acompanhamentoGestante);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(AcompanhamentoGestante acompanhamentoGestante)
        {
            unidadeTrabalho.RegistrarAlterado(acompanhamentoGestante);
            unidadeTrabalho.Salvar();
        }

        public void Remover(AcompanhamentoGestante acompanhamentoGestante)
        {
            unidadeTrabalho.RegistrarRemovido(acompanhamentoGestante);
            unidadeTrabalho.Salvar();
        }

        public AcompanhamentoGestante ResultadoUnico(int idAcompanhamentoGestante)
        {
            return acompanhamentoGestantes.SingleOrDefault(acompanhamentoGestante => acompanhamentoGestante.id == idAcompanhamentoGestante);
        }

        public ICollection<AcompanhamentoGestante> Listar()
        {
            return acompanhamentoGestantes.OrderBy(a => a.id).ToList();
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
