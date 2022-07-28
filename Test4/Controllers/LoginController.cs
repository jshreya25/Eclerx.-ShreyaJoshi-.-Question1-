using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test4.Models;

namespace Test4.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            var Login = Getlogins().ToList();
            return View(Login);
        }
        public ActionResult Details(int studentId)
        {
            var Login = Getlogins().FirstOrDefault(X => X.StudentId==studentId);
            if (Login!=null)
            {
                return View();
            }
            return HttpNotFound();
        }
     
    }
}