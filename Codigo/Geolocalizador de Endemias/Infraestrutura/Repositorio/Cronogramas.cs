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
    public class Cronogramas: ICronogramas
    {

        private IQueryable<Cronograma> cronogramas;
        private IGeolocalizador unidadeTrabalho;

        private  Cronogramas(IQueryable<Cronograma> cronogramas, IGeolocalizador unidadeTrabalho)
        {
            this.cronogramas = cronogramas;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Cronogramas(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.Cronogramas, unidadeTrabalho) { }

        public void Cadastrar(Cronograma cronograma)
        {
            unidadeTrabalho.RegistrarNovo(cronograma);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Cronograma cronograma)
        {
            unidadeTrabalho.RegistrarAlterado(cronograma);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Cronograma cronograma)
        {
            unidadeTrabalho.RegistrarRemovido(cronograma);
            unidadeTrabalho.Salvar();
        }

        public Cronograma ResultadoUnico(int idCronograma)
        {
            return cronogramas.SingleOrDefault(cronograma => cronograma.id == idCronograma);
        }

        public ICollection<Cronograma> Listar()
        {
            return cronogramas.OrderBy(c => c.id).ToList();
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
