using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface ICronogramas : IRepositorio<Cronograma>
    {
        void Cadastrar(Cronograma cronograma);
        void Atualizar(Cronograma cronograma);
        void Remover(Cronograma cronograma);

        Cronograma ResultadoUnico(int idCronograma);

    }
}
