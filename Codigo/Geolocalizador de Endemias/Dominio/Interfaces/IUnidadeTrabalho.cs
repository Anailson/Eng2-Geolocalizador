using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IUnidadeTrabalho
    {
        void RegistrarNovo(object objeto);
        void RegistrarAlterado(object objeto);
        void RegistrarRemovido(object objeto);
        void Salvar();
        void RemoverContexto(object objeto);
    }
}
