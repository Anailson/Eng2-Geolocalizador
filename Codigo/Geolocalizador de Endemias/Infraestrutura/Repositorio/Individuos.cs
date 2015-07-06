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
    public class Individuos: IIndividuos
    {
        private IQueryable<Individuo> individuos;
        private IGeolocalizador unidadeTrabalho;

        private  Individuos(IQueryable<Individuo> individuos, IGeolocalizador unidadeTrabalho)
        {
            this.individuos = individuos;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Individuos(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) : 
               this(iGeolocalizador.Individuos, unidadeTrabalho) { }

        public void Cadastrar(Individuo individuo)
        {
            unidadeTrabalho.RegistrarNovo(individuo);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Individuo individuo)
        {
            unidadeTrabalho.RegistrarAlterado(individuo);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Individuo individuo)
        {
            unidadeTrabalho.RegistrarRemovido(individuo);
            unidadeTrabalho.Salvar();
        }

        public Individuo ResultadoUnico(int idIndividuo)
        {
            return individuos.SingleOrDefault(individuo => individuo.id == idIndividuo);
        }

        public ICollection<Individuo> Listar()
        {
            return individuos.OrderBy(i => i.nome).ToList();
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
