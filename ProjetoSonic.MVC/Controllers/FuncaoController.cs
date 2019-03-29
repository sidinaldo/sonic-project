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
    public class FuncaoController : Controller
    {

        private readonly IFuncaoAppService _funcaoApp;

        public FuncaoController(IFuncaoAppService funcaoApp)
        {
            _funcaoApp = funcaoApp;
        }

        // GET: Funcao
        public ActionResult Index()
        {
            var funcaoViewModel = Mapper.Map<IEnumerable<Funcao>, IEnumerable<FuncaoViewModel>>(_funcaoApp.GetAll());
            return View(funcaoViewModel);
        }

        // GET: Funcao/Details/5
        public ActionResult Details(int id)
        {
            var funcao = _funcaoApp.GetById(id);
            var funcaoWiewModel = Mapper.Map<Funcao, FuncaoViewModel>(funcao);

            return View(funcaoWiewModel);
        }

        // GET: Funcao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FuncaoViewModel funcao)
        {
            if (ModelState.IsValid)
            {
                var funcaoDomain = Mapper.Map<FuncaoViewModel, Funcao>(funcao);
                _funcaoApp.Add(funcaoDomain);

                return RedirectToAction("Index");
            }
            return View(funcao);
        }

        // GET: Funcao/Edit/5
        public ActionResult Edit(int id)
        {
            var funcao = _funcaoApp.GetById(id);
            var funcaoViewModel = Mapper.Map<Funcao, FuncaoViewModel>(funcao);

            return View(funcaoViewModel);
        }

        // POST: Funcao/Edit/5
        [HttpPost]
        public ActionResult Edit(FuncaoViewModel funcao)
        {
            if (ModelState.IsValid)
            {
                var funcaoDomain = Mapper.Map<FuncaoViewModel, Funcao>(funcao);
                _funcaoApp.Update(funcaoDomain);

                return RedirectToAction("Index");
            }

            return View(funcao);
        }

        // GET: Funcao/Delete/5
        public ActionResult Delete(int id)
        {
            var funcao = _funcaoApp.GetById(id);
            var funcaoViewModel = Mapper.Map<Funcao, FuncaoViewModel>(funcao);

            return View(funcaoViewModel);
        }

        // POST: Funcao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var funcao = _funcaoApp.GetById(id);
            _funcaoApp.Remove(funcao);

            return RedirectToAction("Index");
        }
    }
}
