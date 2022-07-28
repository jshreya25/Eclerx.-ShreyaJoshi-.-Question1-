using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test4.Models;

namespace Test4.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
           
            var Registrations = GetRegistrations().ToList();
            return View(Registrations);
        }
        public ActionResult Details(int studentId)
        {
            var Registration = GetRegistrations().FirstOrDefault(X => X.StudentId==studentId);
            if (Registration!=null)
            {
                return View();
            }
            return HttpNotFound();
        } 
        //Data for Registration

        public List<Registration> GetRegistrations()
        {
            return new List<Registration>
            {
               // new Registration{StudentId=1,UserId="101",Password="abc", MobileNumber="8765432145"},
                //new Registration{StudentId=2,UserId="102",Password="xyz", MobileNumber="8765432145"},
                //new Registration{StudentId=3,UserId="103",Password="xxx", MobileNumber="8765432145"},
                //new Registration{StudentId=4,UserId="104",Password="yyy", MobileNumber="8765432145"}
            };

        }
        public ActionResult Create()
        {
            return View();
        }
    
        
    }
}