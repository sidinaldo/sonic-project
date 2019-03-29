using System.Web.Mvc;

namespace ProjetoSonic.MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {            
            var currentUserCookie = Request.Cookies["ProjetoSonic"];

            if (currentUserCookie != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        //[HttpPost]
        //public ActionResult Index(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            //var result = IsAuthenticated(model.Login, model.Password);

        //            var json = BasePostAsync("auth/operadorexterno", model);

        //            if (json.status.Equals(HttpStatusCode.OK))
        //            {
        //                Logar(json.obj.ToString());
        //                return JavaScriptRedirect("Index", "Home");
        //            }

        //            if (json.status.Equals(HttpStatusCode.BadRequest) && json.message.Equals("Trocar Senha"))
        //            {
        //                var changePasswordModel = new ChangePasswordViewModel { Login = model.Login };
        //                return Json(new { success = true, issue = model, html = RenderPartialViewToString("_changePassword", changePasswordModel) });
        //            }

        //            return Json(new { success = false, issue = model, errors = json.message });
        //        }
        //        catch (Exception ex)
        //        {
        //            return Json(new { success = false, issue = model, errors = GetErrorMessage(ex) });
        //        }
        //    }

        //    return Json(new { success = false, issue = model, errors = GetErrosFromModelState() });
        //}

        //public void Logar(string encTicket)
        //{
        //    //CRIANDO O COOKIE
        //    var faCookie = new HttpCookie("TcePortalGestor", encTicket);
        //    Response.Cookies.Add(faCookie);
        //}

        //public bool IsAuthenticated(string username, string pwd)
        //{
        //    var _path = "LDAP://dc=tce,dc=govrn";

        //    var domainAndUsername = "tce.rn.gov.br" + @"\" + username;
        //    var entry = new DirectoryEntry(_path, domainAndUsername, pwd);

        //    try
        //    {
        //        //Bind to the native AdsObject to force authentication.
        //        var obj = entry.NativeObject;

        //        var search = new DirectorySearcher(entry);

        //        search.Filter = "(SAMAccountName=" + username + ")";
        //        search.PropertiesToLoad.Add("cn");
        //        var result = search.FindOne();

        //        if (null == result)
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error authenticating user. " + ex.Message);
        //    }

        //    return true;
        //}

        //[HttpPost]
        //public ActionResult ChangePassword(ChangePasswordViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            //var result = IsAuthenticated(model.Login, model.Password);

        //            var json = BasePostAsync("operadorexterno/changepassword", model);

        //            if (json.status.Equals(HttpStatusCode.OK))
        //            {
        //                Logar(json.obj.ToString());
        //                return JavaScriptRedirect("Index", "Home");
        //            }

        //            return Json(new { success = false, issue = model, errors = json.message });
        //        }
        //        catch (Exception ex)
        //        {
        //            return Json(new { success = false, issue = model, errors = GetErrorMessage(ex) });
        //        }
        //    }

        //    return Json(new { success = false, issue = model, errors = GetErrosFromModelState() });
        //}


        //[HttpGet]
        //public ActionResult ForgotPassword()
        //{
        //    return PartialView("_ForgotPassword");
        //}

        //[HttpPost]
        //public ActionResult ForgotPassword(EsqueceuSenhaViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            //var result = IsAuthenticated(model.Login, model.Password);

        //            var json = BasePostAsync("operadorexterno/resetpassword", model);

        //            if (json.status.Equals(HttpStatusCode.OK))
        //            {
        //                //Logar(json.obj.ToString());
        //                return JavaScriptRedirect("Index", "Login");
        //            }

        //            return Json(new { success = false, issue = model, errors = json.message });
        //        }
        //        catch (Exception ex)
        //        {
        //            return Json(new { success = false, issue = model, errors = GetErrorMessage(ex) });
        //        }
        //    }

        //    return Json(new { success = false, issue = model, errors = GetErrosFromModelState() });
        //}

    }
}