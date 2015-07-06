using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;
using Dominio.Interfaces;
using System.Data.Entity;

namespace Infraestrutura.Database
{
    public interface IGeolocalizador : IUnidadeTrabalho
    {
        DbSet<Individuo> Individuos { get; }
        DbSet<Domicilio> Domicilios { get; }
      
    }
}
