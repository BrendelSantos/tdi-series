using Infraestrutura.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Classes;
using Dominio.Interfaces;

namespace Series.Controllers
{
    public class UsuarioController : Controller
    {

        public ISeries ISeries { get; set; }
        public IUsuarios usuarios { get; set; }

        //
        // GET: /Usuario/
        public ActionResult Index()
        {
           List<Usuario> u = usuarios.Listar().ToList<Usuario>();
            return View(u);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult Inserir3()
        {
            return View();
        }
        public ActionResult Inserir2()
        {
            return View();
        }

        public ActionResult Editar(int id)
        {
            Usuario usuario = usuarios.ResultadoUnico(id);
            return View(usuario);
        }

        public ActionResult Cadastrar(Usuario usuario)
        {
            usuarios.Cadastrar(usuario);
            return RedirectToAction("Index");
        }

        public ActionResult Atualizar(Usuario usuario)
        {
            usuarios.Atualizar(usuario);
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            Usuario usuario = usuarios.ResultadoUnico(id);
            return View(usuario);
        }

        [ActionName("Excluir")]
        public ActionResult Remover(Usuario usuario)
        {
            usuarios.Remover(usuario);
            return RedirectToAction("Index");
        }

        public ActionResult Listar()
        {
            return Json(new
            {
                usuarios = usuarios.Listar().ToList(),
            });
        }


    }
}
