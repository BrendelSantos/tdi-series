using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class UsuarioSerie
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idSerie { get; set; }
        public int preferencia { get; set; }

        public SerieTV SerieTV { get; set; }
        public Usuario Usuario { get; set; }
    }
}
