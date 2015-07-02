using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IDomicilios : IRepositorio<Domicilio>
    {
        void Cadastrar(Domicilio domicilio);
        void Atualizar(Domicilio domicilio);
        void Remover(Domicilio domicilio);

        Domicilio ResultadoUnico(int idDomicilio);
    }
}
