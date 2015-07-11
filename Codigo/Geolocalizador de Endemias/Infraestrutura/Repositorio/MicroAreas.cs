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
    public class MicroAreas: IMicroAreas
    {

        private IQueryable<MicroArea> microAreas;
        private IGeolocalizador unidadeTrabalho;

        private  MicroAreas(IQueryable<MicroArea> microAreas, IGeolocalizador unidadeTrabalho)
        {
            this.microAreas = microAreas;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public MicroAreas(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.MicroAreas, unidadeTrabalho) { }

        public void Cadastrar(MicroArea microArea)
        {
            unidadeTrabalho.RegistrarNovo(microArea);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(MicroArea microArea)
        {
            unidadeTrabalho.RegistrarAlterado(microArea);
            unidadeTrabalho.Salvar();
        }

        public void Remover(MicroArea microArea)
        {
            unidadeTrabalho.RegistrarRemovido(microArea);
            unidadeTrabalho.Salvar();
        }

        public MicroArea ResultadoUnico(int idMicroArea)
        {
            return microAreas.SingleOrDefault(microArea => microArea.id == idMicroArea);
        }

        public ICollection<MicroArea> Listar()
        {
            return microAreas.OrderBy(m => m.id).ToList();
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
