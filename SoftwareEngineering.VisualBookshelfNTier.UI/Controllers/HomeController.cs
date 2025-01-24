using Microsoft.AspNetCore.Mvc;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using SoftwareEngineering.VisualBookshelfNTier.UI.Models;

namespace SoftwareEngineering.VisualBookshelfNTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        private readonly IBookshelfService _bookshelfService;

        public HomeController(IAuthorService authorService, IBookService bookService, IBookshelfService bookshelfService)
        {
            _authorService = authorService;
            _bookService = bookService;
            _bookshelfService = bookshelfService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> SignUp()
        {
            
            var model = new UserCreateModel{};
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserCreateModel model)
        {
            var user = new AppUser
            {
                Email = model.Email,
                Firstname = model.Firstname,
                Password = model.Password,
                Surname = model.Surname,
                Username = model.Username
            };

            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
