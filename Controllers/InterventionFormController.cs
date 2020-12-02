using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Rocket_Elevators_Customer_Portal.Controllers
{


    public class InterventionFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
    }
}