using Dominio.Classes;
using Dominio.Interfaces;
using Infraestrutura.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio
{
    public class Usuarios : IUsuarios
    {

        private IQueryable<Usuario> usuarios;
        private ISeries unidadeTrabalho;

        private  Usuarios(IQueryable<Usuario> usuarios, ISeries unidadeTrabalho)
        {
            this.usuarios = usuarios;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Usuarios(ISeries iSeries, ISeries unidadeTrabalho) : 
               this(iSeries.Usuarios, unidadeTrabalho) { }

        public void Cadastrar(Usuario usuario)
        {
            unidadeTrabalho.RegistrarNovo(usuario);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Usuario usuario)
        {
            unidadeTrabalho.RegistrarAlterado(usuario);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Usuario usuario)
        {
            unidadeTrabalho.RegistrarRemovido(usuario);
            unidadeTrabalho.Salvar();
        }

        public Usuario ResultadoUnico(int idUsuario)
        {
            return usuarios.SingleOrDefault(usuario => usuario.id == idUsuario);
        }

        public ICollection<Usuario> Listar()
        {
            return usuarios.OrderBy(u => u.nome).ToList();
        }

        public bool ContemRegistro()
        {
            throw new NotImplementedException();
        }

        public int TotalRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
