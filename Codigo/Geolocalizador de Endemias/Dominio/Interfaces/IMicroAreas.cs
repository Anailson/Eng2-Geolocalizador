using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IMicroAreas : IRepositorio<MicroArea>
    {
        void Cadastrar(MicroArea microArea);
        void Atualizar(MicroArea microArea);
        void Remover(MicroArea microArea);

        MicroArea ResultadoUnico(int idMicroArea);
    }
}
