using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoSonic.MVC.Controllers
{
    public class CampoController : Controller
    {
        private readonly ICampoAppService _campoApp;
        private readonly IBairroAppService _bairroApp;

        public CampoController(ICampoAppService campoApp, IBairroAppService bairroApp)
        {
            _campoApp = campoApp;
            _bairroApp = bairroApp;
        }

        // GET: Campo
        public ActionResult Index()
        {
            var campoViewModel = Mapper.Map<IEnumerable<Campo>, IEnumerable<CampoViewModel>>(_campoApp.GetAll());
            return View(campoViewModel);
        }

        // GET: Campo/Details/5
        public ActionResult Details(int id)
        {
            var campo = _campoApp.GetById(id);
            var campoWiewModel = Mapper.Map<Campo, CampoViewModel>(campo);

            return View(campoWiewModel);
        }

        // GET: Campo/Create
        public ActionResult Create()
        {
            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro");           
            return View();
        }

        // POST: Campo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CampoViewModel campo)
        {
            if (ModelState.IsValid)
            {

                var campoDomain = Mapper.Map<CampoViewModel, Campo>(campo);
                _campoApp.Add(campoDomain);

                return RedirectToAction("Index");
            }
            return View(campo);
        }

        // GET: Campo/Edit/5
        public ActionResult Edit(int id)
        {
            var campo = _campoApp.GetById(id);
            var campoViewModel = Mapper.Map<Campo, CampoViewModel>(campo);

            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", campoViewModel.BairroId);
           
            return View(campoViewModel);
        }

        // POST: Campo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CampoViewModel campo)
        {
            if (ModelState.IsValid)
            {
                var campoDomain = Mapper.Map<CampoViewModel, Campo>(campo);
                _campoApp.Update(campoDomain);

                return RedirectToAction("Index");
            }


            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", campo.BairroId);
            return View(campo);
        }

        // GET: Campo/Delete/5
        public ActionResult Delete(int id)
        {
            var campo = _campoApp.GetById(id);
            var campoViewModel = Mapper.Map<Campo, CampoViewModel>(campo);

            return View(campoViewModel);
        }

        // POST: Campo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var campo = _campoApp.GetById(id);
            _campoApp.Remove(campo);

            return RedirectToAction("Index");
        }
    }
}
