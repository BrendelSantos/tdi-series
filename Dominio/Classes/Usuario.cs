using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class Usuario
    {
        public int id { get; set; } 
        public String nome { get; set; }
        public String email { get; set; }
        public String senha { get; set; }

        public virtual ICollection<UsuarioSerie> UsuarioSerie { get; set; }
        public virtual ICollection<Visto> Vistos { get; set; }

    }

}

