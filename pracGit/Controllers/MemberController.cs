using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pracGit.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string account,string password)
        {
            return View("Login");
        }
    }
}