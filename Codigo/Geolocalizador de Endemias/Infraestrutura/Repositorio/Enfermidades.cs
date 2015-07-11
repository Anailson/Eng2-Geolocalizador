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
    public class Enfermidades: IEnfermidades
    {

        private IQueryable<Enfermidade> enfermidades;
        private IGeolocalizador unidadeTrabalho;

        private  Enfermidades(IQueryable<Enfermidade> enfermidades, IGeolocalizador unidadeTrabalho)
        {
            this.enfermidades = enfermidades;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Enfermidades(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) :
            this(iGeolocalizador.Enfermidades, unidadeTrabalho) { }

        public void Cadastrar(Enfermidade enfermidade)
        {
            unidadeTrabalho.RegistrarNovo(enfermidade);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Enfermidade enfermidade)
        {
            unidadeTrabalho.RegistrarAlterado(enfermidade);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Enfermidade enfermidade)
        {
            unidadeTrabalho.RegistrarRemovido(enfermidade);
            unidadeTrabalho.Salvar();
        }

        public Enfermidade ResultadoUnico(int idEnfermidade)
        {
            return enfermidades.SingleOrDefault(enfermidade => enfermidade.id == idEnfermidade);
        }

        public ICollection<Enfermidade> Listar()
        {
            return enfermidades.OrderBy(e => e.cid).ToList();
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
