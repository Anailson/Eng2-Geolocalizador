
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
    public class Areas: IAreas
    {

        private IQueryable<Area> areas;
        private IGeolocalizador unidadeTrabalho;

        private  Areas(IQueryable<Area> areas, IGeolocalizador unidadeTrabalho)
        {
            this.areas = areas;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Areas(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.Areas, unidadeTrabalho) { }

        public void Cadastrar(Area area)
        {
            unidadeTrabalho.RegistrarNovo(area);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Area area)
        {
            unidadeTrabalho.RegistrarAlterado(area);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Area area)
        {
            unidadeTrabalho.RegistrarRemovido(area);
            unidadeTrabalho.Salvar();
        }

        public Area ResultadoUnico(int idArea)
        {
            return areas.SingleOrDefault(area => area.id == idArea);
        }

        public ICollection<Area> Listar()
        {
            return areas.OrderBy(a => a.id).ToList();
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
