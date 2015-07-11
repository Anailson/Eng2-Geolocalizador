using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IEquipes : IRepositorio<Equipe>
    {
        void Cadastrar(Equipe equipe);
        void Atualizar(Equipe equipe);
        void Remover(Equipe equipe);

        Equipe ResultadoUnico(int idEquipe);
    }
}
