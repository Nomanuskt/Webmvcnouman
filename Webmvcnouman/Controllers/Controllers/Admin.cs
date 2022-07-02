using Microsoft.AspNetCore.Mvc;

namespace Webmvcnouman.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1(string fname, string lname, string email, string phone, string gender, string departmwnt)
        {
            if (fname == "text" && email == "email")
            {
                ViewBag.message = "data recieved";
            }
            else
            {
                ViewBag.message = "data not recieved";
            }
            return View("Index1");
        }

    }

}
