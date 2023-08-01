using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Models;
using BusinessLayer; 


namespace ThreeTierApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel userModel) {
            if (!ModelState.IsValid) {
                return View(); 
            }
            Service service = new Service();
            service.AddUser(userModel); 
            
            return View("Display", userModel); 
        }

        /*
        public ActionResult Display() {
            Service service = new Service();
            List<UserModel> users = service.GetAllUsers();
            return View("Display", users.ToList());
        }
        */

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}