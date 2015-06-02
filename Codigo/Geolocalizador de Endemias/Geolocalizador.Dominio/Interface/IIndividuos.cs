using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geolocalizador.Dominio.Classes;


namespace Geolocalizador.Dominio.Interface
{
    interface IIndividuos : IRepositorio<Individuo>
    {
        void Cadastrar(Individuo individuo);
        void Atualizar(Individuo individuo);
        void Remover(Individuo individuo);

        Individuo ResultadoUnico(int idIndividuo);
    }
}
