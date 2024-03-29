using Microsoft.AspNetCore.Mvc;
using Mission11_McAvoy.Models;
using Mission11_McAvoy.Models.ViewModels;
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

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;

            var model = new BooksListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(model);
        }

    }
}
