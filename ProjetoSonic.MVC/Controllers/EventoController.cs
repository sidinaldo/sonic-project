using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.Controllers
{
    public class EventoController : Controller
    {
        private readonly IEventoAppService _eventoApp;

        public EventoController(IEventoAppService eventoApp)
        {
            _eventoApp = eventoApp;
        }

        // GET: Evento
        public ActionResult Index()
        {
            var eventoViewModel = Mapper.Map<IEnumerable<Evento>, IEnumerable<EventoViewModel>>(_eventoApp.GetAll());
            return View(eventoViewModel);
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            var evento = _eventoApp.GetById(id);
            var eventoWiewModel = Mapper.Map<Evento, EventoViewModel>(evento);

            return View(eventoWiewModel);
        }

        // GET: Evento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventoViewModel evento)
        {
            if (ModelState.IsValid)
            {
                var eventoDomain = Mapper.Map<EventoViewModel, Evento>(evento);
                _eventoApp.Add(eventoDomain);

                return RedirectToAction("Index");
            }
            return View(evento);
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            var evento = _eventoApp.GetById(id);
            var eventoViewModel = Mapper.Map<Evento, EventoViewModel>(evento);

            return View(eventoViewModel);
        }

        // POST: Evento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EventoViewModel evento)
        {
            if (ModelState.IsValid)
            {
                var eventoDomain = Mapper.Map<EventoViewModel, Evento>(evento);
                _eventoApp.Update(eventoDomain);

                return RedirectToAction("Index");
            }

            return View(evento);
        }

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            var evento = _eventoApp.GetById(id);
            var eventoViewModel = Mapper.Map<Evento, EventoViewModel>(evento);

            return View(eventoViewModel);
        }

        // POST: Estado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var evento = _eventoApp.GetById(id);
            _eventoApp.Remove(evento);

            return RedirectToAction("Index");
        }
    }
}
