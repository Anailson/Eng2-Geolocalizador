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
    public class Domicilios: IDomicilios
    {

        private IQueryable<Domicilio> domicilios;
        private IGeolocalizador unidadeTrabalho;

        private  Domicilios(IQueryable<Domicilio> domicilios, IGeolocalizador unidadeTrabalho)
        {
            this.domicilios = domicilios;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Domicilios(IGeolocalizador iGeolocalizador, IGeolocalizador unidadeTrabalho) : 
               this(iGeolocalizador.Domicilios, unidadeTrabalho) { }

        public void Cadastrar(Domicilio domicilio)
        {
            unidadeTrabalho.RegistrarNovo(domicilio);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Domicilio domicilio)
        {
            unidadeTrabalho.RegistrarAlterado(domicilio);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Domicilio domicilio)
        {
            unidadeTrabalho.RegistrarRemovido(domicilio);
            unidadeTrabalho.Salvar();
        }

        public Domicilio ResultadoUnico(int idDomicilio)
        {
            return domicilios.SingleOrDefault(domicilio => domicilio.id == idDomicilio);
        }

        public ICollection<Domicilio> Listar()
        {
            return domicilios.OrderBy(d => d.susProfissional).ToList();
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
