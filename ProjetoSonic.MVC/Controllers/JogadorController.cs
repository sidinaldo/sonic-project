using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace ProjetoSonic.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private readonly IClubeAppService _clubeApp;
        private readonly IUsuarioAppService _usuarioApp;
        private readonly IJogadorAppService _jogadorApp;

        public JogadorController(IClubeAppService clubeApp, IUsuarioAppService usuarioApp, IJogadorAppService jogadorApp)
        {
            _clubeApp = clubeApp;
            _usuarioApp = usuarioApp;
            _jogadorApp = jogadorApp;

        }

        // GET: Jogador
        public ActionResult Index()
        {
            var jogadorViewModel = Mapper.Map<IEnumerable<Jogador>, IEnumerable<JogadorViewModel>>(_jogadorApp.GetAll());
            return View(jogadorViewModel);
        }

        // GET: Jogador/Details/5
        public ActionResult Details(int id)
        {
            var jogador = _jogadorApp.GetById(id);
            var jogadorWiewModel = Mapper.Map<Jogador, JogadorViewModel>(jogador);

            return View(jogador);
        }

        // GET: Jogador/Create
        public ActionResult Create()
        {
            ViewBag.UsuarioId = new SelectList(_usuarioApp.GetAll(), "UsuarioId", "NomeUsuario");
            ViewBag.ClubeId = new SelectList(_clubeApp.GetAll(), "ClubeId", "NomeClube");
            return View();
        }

        // POST: Jogador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JogadorViewModel jogador)
        {
            if (ModelState.IsValid)
            {
                var jogadorDomain = Mapper.Map<JogadorViewModel, Jogador>(jogador);
                _jogadorApp.Add(jogadorDomain);

                return RedirectToAction("Index");
            }
            return View(jogador);
        }

        // GET: Jogador/Edit/5
        public ActionResult Edit(int id, int id2)
        {
            var clube = _clubeApp.GetById(id);
            var clubeViewModel = Mapper.Map<Clube,ClubeViewModel>(clube);

            var usuario = _usuarioApp.GetById(id2);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            ViewBag.UsuarioId = new SelectList(_usuarioApp.GetAll(), "UsuarioId", "NomeUsuario", usuarioViewModel.UsuarioId);
            ViewBag.ClubeId = new SelectList(_clubeApp.GetAll(), "ClubeId", "NomeClube", clubeViewModel.ClubeId);

            return View(clubeViewModel, usuarioViewModel);
        }

        private ActionResult View(ClubeViewModel clubeViewModel, UsuarioViewModel usuarioViewModel)
        {
            return View();
        }

        // POST: Jogador/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(JogadorViewModel jogador)
        {
            if (ModelState.IsValid)
            {
                var jogadorDomain = Mapper.Map<JogadorViewModel, Jogador>(jogador);
                _jogadorApp.Update(jogadorDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClubeId = new SelectList(_jogadorApp.GetAll(), "ClubeId", "NomeClube", jogador.ClubeId);
            ViewBag.UsuarioId = new SelectList(_usuarioApp.GetAll(), "UsuarioId", "NomeUsuario", jogador.UsuarioId);

            return View(jogador);
        }

        // GET: Jogador/Delete/5
        public ActionResult Delete(int id)
        {
            var jogador = _jogadorApp.GetById(id);
            var jogadorViewModel = Mapper.Map<Jogador, JogadorViewModel>(jogador);

            return View(jogadorViewModel);
        }

        // POST: Jogador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var jogador = _jogadorApp.GetById(id);
            _jogadorApp.Remove(jogador);

            return RedirectToAction("Index");
        }
    }
}
