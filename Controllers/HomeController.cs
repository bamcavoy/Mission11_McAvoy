using Microsoft.AspNetCore.Mvc;
using Mission11_McAvoy.Models;
using System.Diagnostics;

namespace Mission11_McAvoy.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
