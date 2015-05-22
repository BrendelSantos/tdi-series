using Dominio.Classes;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Database
{
    public interface ISeries : IUnidadeTrabalho
    {
        DbSet<Usuario> Usuarios { get; }
        DbSet<Episodio> Episodios { get; }
        DbSet<SerieTV> SeriesTV { get; }
        DbSet<UsuarioSerie> UsuarioSeries { get; }
        DbSet<Visto> Vistos { get; }
    }
}
