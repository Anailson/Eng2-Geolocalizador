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
    public class Equipes: IEquipes
    {

        private IQueryable<Equipe> equipes;
        private IGeolocalizador unidadeTrabalho;

        private  Equipes(IQueryable<Equipe> equipes, IGeolocalizador unidadeTrabalho)
        {
            this.equipes = equipes;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Equipes(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.Equipes, unidadeTrabalho) { }

        public void Cadastrar(Equipe equipe)
        {
            unidadeTrabalho.RegistrarNovo(equipe);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Equipe equipe)
        {
            unidadeTrabalho.RegistrarAlterado(equipe);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Equipe equipe)
        {
            unidadeTrabalho.RegistrarRemovido(equipe);
            unidadeTrabalho.Salvar();
        }

        public Equipe ResultadoUnico(int idEquipe)
        {
            return equipes.SingleOrDefault(equipe => equipe.numSus == idEquipe);
        }

        public ICollection<Equipe> Listar()
        {
            return equipes.OrderBy(e => e.id).ToList();
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
