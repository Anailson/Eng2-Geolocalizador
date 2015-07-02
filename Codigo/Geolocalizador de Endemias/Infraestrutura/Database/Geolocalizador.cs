using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;
using System.Data.Entity;

namespace Infraestrutura.Database
{
    public class Geolocalizador:UnidadeTrabalho, IGeolocalizador
    {

        public Geolocalizador()
            : base("name=GeolocalizadorEntities")
        {
        }

        public DbSet<Individuo> Individuos { get; set; }
    }
}
