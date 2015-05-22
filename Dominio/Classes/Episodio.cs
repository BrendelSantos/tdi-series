using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Episodio
    {
        public int id { get; set; }
        public int idSerie { get; set; }
        public String nome { get; set; }
        public DateTime exibicao { get; set; }
        public String resumo { get; set; }
        public int temporada { get; set; }

        public ICollection<SerieTV> SerieTV { get; set; }
        public ICollection<Visto> Vistos { get; set; }
    }
}
