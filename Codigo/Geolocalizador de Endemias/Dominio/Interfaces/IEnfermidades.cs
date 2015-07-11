using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IEnfermidades : IRepositorio<Enfermidade>
    {
        void Cadastrar(Enfermidade enfermidade);
        void Atualizar(Enfermidade enfermidade);
        void Remover(Enfermidade enfermidade);

        Enfermidade ResultadoUnico(int idEnfermidade);

    }
}
