
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;
using System.Diagnostics;
using ProjetoSonic.Infra.Data.Contexto;
using System.Data.SqlClient;

namespace ProjetoSonic.MVC.Controllers
{
    public class AdministradorController : Controller
    {
        //invocando os métodos da interface        

        private readonly IAdministradorAppService _administradorApp;
        private readonly IUsuarioAppService _usuarioApp;
        private readonly IFuncaoAppService _funcaoApp;

        public AdministradorController(IAdministradorAppService administradorApp, IUsuarioAppService usuarioApp, IFuncaoAppService funcaoApp)
        {
            _administradorApp = administradorApp;
            _usuarioApp =  usuarioApp;
            _funcaoApp = funcaoApp;           
        }

        // GET: Administrador
        public ActionResult Index()
        {
            var administradorViewModel = Mapper.Map<IEnumerable<Administrador>, IEnumerable<AdministradorViewModel>>(_administradorApp.GetAll());
            return View(administradorViewModel);
        }

        // GET: Administrador/Details/5
        public ActionResult Details(int id)
        {
            var administrador = _administradorApp.GetById(id);
            var administradorWiewModel = Mapper.Map<Administrador, AdministradorViewModel>(administrador);

            return View(administradorWiewModel);
        }

        // GET: Administrador/Create
        public ActionResult Create()
        {
            ViewBag.FuncaoId = new SelectList(_funcaoApp.GetAll(), "FuncaoId", "NomeFuncao");
            ViewBag.UsuarioId = new SelectList(_usuarioApp.GetAll(), "UsuarioId", "NomeUsuario");
            return View();
        }

        // POST: Administrador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdministradorViewModel administrador)
        {
            if (ModelState.IsValid)
            {
                             
                var administradorDomain = Mapper.Map<AdministradorViewModel, Administrador>(administrador);
                _administradorApp.Add(administradorDomain);

                return RedirectToAction("Index");
            }
            return View(administrador);
        }

        // GET: Administrador/Edit/5
        public ActionResult Edit(int id)
        {
            var administrador = _administradorApp.GetById(id);
            var administradorViewModel = Mapper.Map<Administrador, AdministradorViewModel>(administrador);

            ViewBag.UsuarioId = new SelectList(_usuarioApp.GetAll(), "UsuarioId", "NomeUsuario", administradorViewModel.UsuarioId);
            ViewBag.FuncaoId = new SelectList(_funcaoApp.GetAll(), "FuncaoId", "NomeFuncao", administradorViewModel.FuncaoId);
            return View(administradorViewModel);
        }

        // POST: Administrador/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AdministradorViewModel administrador)
        {
            if (ModelState.IsValid)
            {
                var administradorDomain = Mapper.Map<AdministradorViewModel, Administrador>(administrador);
                _administradorApp.Update(administradorDomain);

                return RedirectToAction("Index");
            }

            ViewBag.UsuarioId = new SelectList(_usuarioApp.GetAll(), "UsuarioId", "NomeUsuario", administrador.UsuarioId);
            ViewBag.FuncaoId = new SelectList(_funcaoApp.GetAll(), "FuncaoId", "NomeFuncao", administrador.FuncaoId);
            return View(administrador);
        }

        // GET: Administrador/Delete/5
        public ActionResult Delete(int id)
        {
            var administrador = _administradorApp.GetById(id);
            var administradorViewModel = Mapper.Map<Administrador, AdministradorViewModel>(administrador);

            return View(administradorViewModel);
        }

        // POST: Administrador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var administrador = _administradorApp.GetById(id);
            _administradorApp.Remove(administrador);

            return RedirectToAction("Index");
        }
    }
}
