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
    public class Visitas: IVisitas
    {

        private IQueryable<Visita> visitas;
        private IGeolocalizador unidadeTrabalho;

        private  Visitas(IQueryable<Visita> visitas, IGeolocalizador unidadeTrabalho)
        {
            this.visitas = visitas;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Visitas(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.Visitas, unidadeTrabalho) { }

        public void Cadastrar(Visita visita)
        {
            unidadeTrabalho.RegistrarNovo(visita);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Visita visita)
        {
            unidadeTrabalho.RegistrarAlterado(visita);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Visita visita)
        {
            unidadeTrabalho.RegistrarRemovido(visita);
            unidadeTrabalho.Salvar();
        }

        public Visita ResultadoUnico(int idVisita)
        {
            return visitas.SingleOrDefault(visita => visita.id == idVisita);
        }

        public ICollection<Visita> Listar()
        {
            return visitas.OrderBy(e => e.id).ToList();
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
