using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    interface IAreas : IRepositorio<Area>
    {
        void Cadastrar(Area area);
        void Atualizar(Area area);
        void Remover(Area area);

        Area ResultadoUnico(int idArea);
    }
}
