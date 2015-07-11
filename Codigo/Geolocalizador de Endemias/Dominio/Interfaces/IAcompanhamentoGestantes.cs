using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IAcompanhamentoGestantes : IRepositorio<AcompanhamentoGestante>
    {
        void Cadastrar(AcompanhamentoGestante acompanhamentoGestante);
        void Atualizar(AcompanhamentoGestante acompanhamentoGestante);
        void Remover(AcompanhamentoGestante acompanhamentoGestante);

        AcompanhamentoGestante ResultadoUnico(int idAcompanhamentoGestante);


    }
}
