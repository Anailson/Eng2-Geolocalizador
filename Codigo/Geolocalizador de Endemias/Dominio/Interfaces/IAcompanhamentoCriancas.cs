using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IAcompanhamentoCriancas : IRepositorio<AcompanhamentoCrianca>
    {
        void Cadastrar(AcompanhamentoCrianca acompanhamentoCrianca);
        void Atualizar(AcompanhamentoCrianca acompanhamentoCrianca);
        void Remover(AcompanhamentoCrianca acompanhamentoCrianca);

        AcompanhamentoCrianca ResultadoUnico(int idAcompanhamentoCrianca);
    }
}
