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

        DbSet<AcompanhamentoCrianca> AcompanhamentoCriancas { get; }
        DbSet<AcompanhamentoEnfermo> AcompanhamentoEnfermos { get; }
        DbSet<AcompanhamentoGestante> AcompanhamentoGestantes { get;}
        DbSet<Area> Areas { get; }
        DbSet<MicroArea> MicroAreas { get; }
        DbSet<Cronograma> Cronogramas { get; }
        DbSet<Domicilio> Domicilios { get; }
        DbSet<Enfermidade> Enfermidades { get; }
        DbSet<Equipe> Equipes { get; }
        DbSet<Individuo> Individuos { get; }
        DbSet<Visita> Visitas { get; }
      
    }
}
