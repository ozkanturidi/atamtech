using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using test.Models;
namespace test.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {

            var information = c.Admins.FirstOrDefault(x => x.username == ad.username && x.password == ad.password);
            if (information != null)
            {
                FormsAuthentication.SetAuthCookie(information.username, false);
                Session["username"] = information.username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }


        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Login");
        }

    }
}