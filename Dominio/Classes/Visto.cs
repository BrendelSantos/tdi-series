using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Visto
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idEpisodio { get; set; }
        public int avaliacao { get; set; }

        public Episodio Episodio { get; set; }
        public Usuario Usuario { get; set; }

    }
}
