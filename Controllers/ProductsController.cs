using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Product.Controllers
{

    public class PorductController : Controller
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
