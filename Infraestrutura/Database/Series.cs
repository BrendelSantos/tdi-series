using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Classes;
using System.Data.Entity;

namespace Infraestrutura.Database
{
    public class Series :UnidadeTrabalho, ISeries
    {

        public Series()
            : base("name=SeriesDatabaseEntities")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Episodio> Episodios { get; set; }
        public DbSet<SerieTV> SeriesTV { get; set; }
        public DbSet<UsuarioSerie> UsuarioSeries { get; set; }
        public DbSet<Visto> Vistos { get; set; }

    }
}
