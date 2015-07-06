using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorio { }

    public interface IRepositorio<T> : IRepositorio where T : class
    {
        ICollection<T> Listar();
        bool ContemRegistro();
        int TotalRegistros();
    }
}
