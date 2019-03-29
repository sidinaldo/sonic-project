using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;
        private readonly IBairroAppService _bairroApp;

        public UsuarioController(IUsuarioAppService usuarioApp, IBairroAppService bairroApp )
        {
            _usuarioApp = usuarioApp;
            _bairroApp = bairroApp;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApp.GetAll());
            return View(usuarioViewModel);
        }

        public ActionResult Especiais()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApp.ObterUsuarioEspecial());
            return View(usuarioViewModel);

            //ViewBag.UsuarioId = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApp.ObterUsuarioEspecial());
            //return View();
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioWiewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioWiewModel);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro");
            return View();
                        
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Add(usuarioDomain);

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioWiewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", usuarioWiewModel.BairroId);
            return View(usuarioWiewModel);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Update(usuarioDomain);

                return RedirectToAction("Index");
            }

            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", usuario.BairroId);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            _usuarioApp.Remove(usuario);

            return RedirectToAction("Index");
        }
    }
}
