using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio.Classes
{
    public class SerieTV
    {
        public int id { get; set; }
        
        public String nome { get; set; }
        public String status { get; set; }
        public String emissora { get; set; }
        public int dia { get; set; }
        public TimeSpan horario { get; set; }
        public String sinopse { get; set; }
        public int ano { get; set; }

        public ICollection<Episodio> Episodios { get; set; }
        public ICollection<UsuarioSerie> UsuarioSerie { get; set; }

    }
}
