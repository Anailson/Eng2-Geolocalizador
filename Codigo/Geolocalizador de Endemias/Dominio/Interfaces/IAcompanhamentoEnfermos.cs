using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IAcompanhamentoEnfermos : IRepositorio<AcompanhamentoEnfermo>
    {
        void Cadastrar(AcompanhamentoEnfermo acompanhamentoEnfermo);
        void Atualizar(AcompanhamentoEnfermo acompanhamentoEnfermo);
        void Remover(AcompanhamentoEnfermo acompanhamentoEnfermo);

        AcompanhamentoEnfermo ResultadoUnico(int idAcompanhamentoEnfermo);

    }
}
