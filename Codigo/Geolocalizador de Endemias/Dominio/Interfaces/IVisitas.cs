using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IVisitas : IRepositorio<Visita>
    {
        void Cadastrar(Visita visita);
        void Atualizar(Visita visita);
        void Remover(Visita visita);

        Visita ResultadoUnico(int idVisita);
    }
}
