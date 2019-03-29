using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.Controllers
{
    public class ClubeController : Controller
    {

        private readonly IBairroAppService _bairroApp;
        private readonly IClubeAppService _clubeApp;

        public ClubeController(IClubeAppService clubeAppService, IBairroAppService bairroAppService)
        {
            _clubeApp = clubeAppService;
            _bairroApp = bairroAppService;
        }

        // GET: Clube
        public ActionResult Index()
        {
            var clubeViewModel = Mapper.Map<IEnumerable<Clube>, IEnumerable<ClubeViewModel>>(_clubeApp.GetAll());
            return View(clubeViewModel);
        }

        // GET: Clube/Details/5
        public ActionResult Details(int id)
        {
            var clube = _clubeApp.GetById(id);
            var clubeViewModel = Mapper.Map<Clube, ClubeViewModel>(clube);

            return View(clubeViewModel);
        }

        // GET: Clube/Create
        public ActionResult Create()
        {
            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro");
            return View();
        }

        // POST: Clube/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClubeViewModel clube)
        {
            if (ModelState.IsValid)
            {
                var clubeDomain = Mapper.Map<ClubeViewModel, Clube>(clube);
                _clubeApp.Add(clubeDomain);

                return RedirectToAction("Index");
            }
            return View(clube);
        }

        // GET: Clube/Edit/5
        public ActionResult Edit(int id)
        {
             var clube = _clubeApp.GetById(id);
            var clubeViewModel = Mapper.Map<Clube, ClubeViewModel>(clube);

            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", clubeViewModel.BairroId);
            return View(clubeViewModel);
        }

        // POST: Clube/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClubeViewModel clube)
        {
            if (ModelState.IsValid)
            {
                var clubeDomain = Mapper.Map<ClubeViewModel, Clube>(clube);
                _clubeApp.Update(clubeDomain);

                return RedirectToAction("Index");
            }

            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", clube.BairroId);
            return View(clube);
        }

        // GET: Clube/Delete/5
        public ActionResult Delete(int id)
        {
            var clube = _clubeApp.GetById(id);
            var clubeViewModel = Mapper.Map<Clube, ClubeViewModel>(clube);

            return View(clubeViewModel);
        }

        // POST: Clube/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var clube = _clubeApp.GetById(id);
            _clubeApp.Remove(clube);

            return RedirectToAction("Index");
        }
       
    }
}
