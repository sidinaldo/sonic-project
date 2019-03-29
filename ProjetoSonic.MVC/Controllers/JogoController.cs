using AutoMapper;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoSonic.MVC.Controllers
{
    public class JogoController : Controller
    {
        private readonly IClubeAppService _clubeApp;
        private readonly IBairroAppService _bairroApp;
        private readonly ICampoAppService _campoApp;
        private readonly IJogoAppService _jogoApp;

        public JogoController(IClubeAppService clubeApp, IBairroAppService bairroApp, ICampoAppService campoApp, IJogoAppService jogoApp)
        {
            _bairroApp = bairroApp;
            _campoApp = campoApp;
            _clubeApp = clubeApp;
            _jogoApp = jogoApp;

        }

        // GET: Jogo
        public ActionResult Index()
        {
            var jogoViewModel = Mapper.Map<IEnumerable<Jogo>, IEnumerable<JogoViewModel>>(_jogoApp.GetAll());
            return View(jogoViewModel);
        }

        // GET: Jogo/Details/5
        public ActionResult Details(int id)
        {
            var jogo =_jogoApp.GetById(id);
            var jogoWiewModel = Mapper.Map<Jogo,JogoViewModel>(jogo);

            return View(jogoWiewModel);
        }

        // GET: Jogo/Create
        public ActionResult Create()
        {
            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro");
            ViewBag.CampoId = new SelectList(_campoApp.GetAll(), "CampoId", "NomeCampo");
            ViewBag.TimeA = new SelectList(_clubeApp.GetAll(), "ClubeId", "NomeClube");
           // ViewBag.TimeB = new SelectList(_clubeApp.GetAll(), "ClubeId", "NomeClube");

            return View();
        }

        // POST: Jogo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JogoViewModel jogo)
        {
            if (ModelState.IsValid)
            {
                var jogoDomain = Mapper.Map<JogoViewModel, Jogo>(jogo);
                _jogoApp.Add(jogoDomain);

                //var query = "";
                //query += "insert into JogoJogador (JogoId) ";
                //query += string.Format("values ('{0}'", jogo.JogoId);

                    return RedirectToAction("Index");
            }
            return View(jogo);
        }

        // GET: Jogo/Edit/5
        public ActionResult Edit(int id)
        {
            var jogo = _jogoApp.GetById(id);
            var jogoViewModel = Mapper.Map<Jogo, JogoViewModel>(jogo);

            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", jogoViewModel.BairroId);
            ViewBag.CampoId = new SelectList(_campoApp.GetAll(), "CampoId", "NomeCampo", jogoViewModel.CampoId);
            ViewBag.ClubeId = new SelectList(_clubeApp.GetAll(), "ClubeId", "NomeClube", jogoViewModel.TimeA);
            ViewBag.ClubeId = new SelectList(_clubeApp.GetAll(), "ClubeId", "NomeClube", jogoViewModel.TimeB);
            return View(jogoViewModel);
        }

        // POST: Jogo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(JogoViewModel jogo)
        {
            if (ModelState.IsValid)
            {
                var jogoDomain = Mapper.Map<JogoViewModel, Jogo>(jogo);
                _jogoApp.Update(jogoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.BairroId = new SelectList(_bairroApp.GetAll(), "BairroId", "NomeBairro", jogo.BairroId);
            ViewBag.ClubeId = new SelectList(_clubeApp.GetAll(), "ClubeId", "NomeClube", jogo.Clube.ClubeId);
            ViewBag.CampoId = new SelectList(_campoApp.GetAll(), "CampoId", "NomeCampo", jogo.CampoId);

            return View(jogo);

        }

        // GET: Jogo/Delete/5
        public ActionResult Delete(int id)
        {
            var jogo = _jogoApp.GetById(id);
            var jogoViewModel = Mapper.Map<Jogo, JogoViewModel>(jogo);

            return View(jogoViewModel);
        }

        // POST: Jogo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var jogo = _jogoApp.GetById(id);
            _jogoApp.Remove(jogo);

            return RedirectToAction("Index");
        }
    }
}
