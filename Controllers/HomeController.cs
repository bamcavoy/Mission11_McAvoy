using Microsoft.AspNetCore.Mvc;
using Mission11_McAvoy.Models;
using System.Diagnostics;

namespace Mission11_McAvoy.Controllers
{

    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository tmp)
        {
            _repo = tmp;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
