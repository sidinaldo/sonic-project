﻿using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.Controllers
{
    public class EstadoController : Controller
    {
        private readonly IEstadoAppService _estadoApp;

        public EstadoController(IEstadoAppService estadoApp)
        {
            _estadoApp = estadoApp;
        }

        // GET: Estado
        public ActionResult Index()
        {
            var estadoViewModel = Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoViewModel>>(_estadoApp.GetAll());
            return View(estadoViewModel);
        }

        // GET: Estado/Details/5
        public ActionResult Details(int id)
        {
            var estado = _estadoApp.GetById(id);
            var estadoWiewModel = Mapper.Map<Estado, EstadoViewModel>(estado);

            return View(estadoWiewModel);
        }

        // GET: Estado/Create
        public ActionResult Create()
        {
           return View();
        }

        // POST: Estado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstadoViewModel estado)
        {
            if (ModelState.IsValid)
            {
                var estadoDomain = Mapper.Map<EstadoViewModel, Estado>(estado);
                _estadoApp.Add(estadoDomain);

                return RedirectToAction("Index");
            }
            return View(estado);
        }

        // GET: Estado/Edit/5
        public ActionResult Edit(int id)
        {
            var estado = _estadoApp.GetById(id);
            var estadoViewModel = Mapper.Map<Estado, EstadoViewModel>(estado);
           
            return View(estadoViewModel);
        }

        // POST: Estado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstadoViewModel estado)
        {
            if (ModelState.IsValid)
            {
                var estadoDomain = Mapper.Map<EstadoViewModel, Estado>(estado);
                _estadoApp.Update(estadoDomain);

                return RedirectToAction("Index");
            }

            return View(estado);
        }

        // GET: Estado/Delete/5
        public ActionResult Delete(int id)
        {
            var estado = _estadoApp.GetById(id);
            var estadoViewModel = Mapper.Map<Estado, EstadoViewModel>(estado);

            return View(estadoViewModel);
        }

        // POST: Estado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var estado = _estadoApp.GetById(id);
            _estadoApp.Remove(estado);

            return RedirectToAction("Index");
        }
    }
}
