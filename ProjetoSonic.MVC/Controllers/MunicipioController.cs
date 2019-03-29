using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.Controllers
{
    public class MunicipioController : Controller
    {
        private readonly IMunicipioAppService _municipioApp;
        private readonly IEstadoAppService _estadoApp;

        public MunicipioController(IMunicipioAppService municipioApp, IEstadoAppService estadoApp)
        {
            _municipioApp = municipioApp;
            _estadoApp = estadoApp;
        }


        // GET: Municipio
        public ActionResult Index()
        {
            var municipioViewModel = Mapper.Map<IEnumerable<Municipio>, IEnumerable<MunicipioViewModel>>(_municipioApp.GetAll());
            return View(municipioViewModel);
        }

        // GET: Municipio/Details/5
        public ActionResult Details(int id)
        {
            var municipio = _municipioApp.GetById(id);
            var municipioAppWiewModel = Mapper.Map<Municipio, MunicipioViewModel>(municipio);

            return View(municipioAppWiewModel);
        }

        // GET: Municipio/Create
        public ActionResult Create()
        {
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado");
            return View();
        }

        // POST: Municipio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MunicipioViewModel municipio)
        {
            if (ModelState.IsValid)
            {
                var municipioDomain = Mapper.Map<MunicipioViewModel, Municipio>(municipio);
                _municipioApp.Add(municipioDomain);

                return RedirectToAction("Index");
            }
            return View(municipio);
        }

        // GET: Municipio/Edit/5
        public ActionResult Edit(int id)
        {
            var municipio = _municipioApp.GetById(id);
            var municipioWiewModel = Mapper.Map<Municipio, MunicipioViewModel>(municipio);

            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado", municipioWiewModel.EstadoId);
            return View(municipioWiewModel);
        }

        // POST: Municipio/Edit/5
        [HttpPost]
        public ActionResult Edit(MunicipioViewModel municipio)
        {
            if (ModelState.IsValid)
            {
                var municipioDomain = Mapper.Map<MunicipioViewModel, Municipio>(municipio);
                _municipioApp.Update(municipioDomain);

                return RedirectToAction("Index");
            }

            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado", municipio.EstadoId);
            return View(municipio);
        }

        // GET: Municipio/Delete/5
        public ActionResult Delete(int id)
        {
            var municipio = _municipioApp.GetById(id);
            var municipioViewModel = Mapper.Map<Municipio, MunicipioViewModel>(municipio);

            return View(municipioViewModel);
        }

        // POST: Municipio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var municipio = _municipioApp.GetById(id);
            _municipioApp.Remove(municipio);

            return RedirectToAction("Index");
        }
    }
}
