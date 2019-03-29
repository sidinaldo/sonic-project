using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.Controllers
{
    public class BairroController : Controller
    {
        private readonly IBairroAppService _bairroApp;
        private readonly IMunicipioAppService _municipioApp;

        public BairroController(IBairroAppService bairroApp, IMunicipioAppService municipioApp)
        {
            _bairroApp = bairroApp;
            _municipioApp = municipioApp;

        }
        
        // GET: Bairro
        public ActionResult Index()
        {
            var bairroViewModel = Mapper.Map<IEnumerable<Bairro>, IEnumerable < BairroViewModel >> (_bairroApp.GetAll());
            return View(bairroViewModel);
        }

        // GET: Bairro/Details/5
        public ActionResult Details(int id)
        {
            var bairro = _bairroApp.GetById(id);
            var bairroViewModel = Mapper.Map<Bairro, BairroViewModel>(bairro);

            return View(bairroViewModel);
        }

        // GET: Bairro/Create
        public ActionResult Create()
        {
            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio");
            return View();
        }

        // POST: Bairro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BairroViewModel bairro)
        {
            if (ModelState.IsValid)
            {
                var bairroDomain = Mapper.Map<BairroViewModel, Bairro>(bairro);
                _bairroApp.Add(bairroDomain);

                return RedirectToAction("Index");
            }
            return View(bairro);
        }

        // GET: Bairro/Edit/5
        public ActionResult Edit(int id)
        {
            var bairro = _bairroApp.GetById(id);
            var bairroViewModel = Mapper.Map<Bairro, BairroViewModel>(bairro);

            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", bairroViewModel.MunicipioId);
            return View(bairroViewModel);
        }

        // POST: Bairro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BairroViewModel bairro)
        {
            if (ModelState.IsValid)
            {
                var bairroDomain = Mapper.Map<BairroViewModel, Bairro>(bairro);
                _bairroApp.Update(bairroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", bairro.MunicipioId);
            return View(bairro);
        }

        // GET: Bairro/Delete/5
        public ActionResult Delete(int id)
        {
            var bairro = _bairroApp.GetById(id);
            var bairroViewModel = Mapper.Map<Bairro, BairroViewModel>(bairro);

            return View(bairroViewModel);
        }

        // POST: Bairro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var bairro = _bairroApp.GetById(id);
            _bairroApp.Remove(bairro);

            return RedirectToAction("Index");

        }
    }
}
