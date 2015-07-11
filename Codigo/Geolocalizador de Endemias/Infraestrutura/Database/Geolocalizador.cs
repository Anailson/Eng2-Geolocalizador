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


        public DbSet<AcompanhamentoCrianca> AcompanhamentoCriancas { get; set; }
        public DbSet<AcompanhamentoEnfermo> AcompanhamentoEnfermos { get; set; }
        public DbSet<AcompanhamentoGestante> AcompanhamentoGestantes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<MicroArea> MicroAreas { get; set; }
        public DbSet<Cronograma> Cronogramas { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Enfermidade> Enfermidades { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Individuo> Individuos { get; set; }
        public DbSet<Visita> Visitas { get; set; }


    }
}
