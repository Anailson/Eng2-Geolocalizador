using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IIndividuos : IRepositorio<Individuo>
    {
        void Cadastrar(Individuo individuo);
        void Atualizar(Individuo individuo);
        void Remover(Individuo individuo);

        Individuo ResultadoUnico(int idIndividuo);
    }
}
