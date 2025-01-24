using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.UI.Extensions;
using SoftwareEngineering.VisualBookshelfNTier.UI.Helpers;
using SoftwareEngineering.VisualBookshelfNTier.UI.Models;
using System.Security.Claims;

namespace SoftwareEngineering.VisualBookshelfNTier.UI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookshelfService _bookshelfService;
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookshelfService bookshelfService, IBookService bookService, IMapper mapper)
        {
            _bookshelfService = bookshelfService;
            _bookService = bookService;
            _mapper = mapper;
        }

        public IActionResult Search()
        {
            BookListResult bookListResult = new();
            return View(bookListResult);
        }

        [HttpPost]
        public async Task<IActionResult> Search(string searchTerm)
        {
            var result = await ApiHelper.SearchBooksAsync(searchTerm);
            return View(result);
        }

        public async Task<IActionResult> Favorite(int Id)
        {
            var userId = int.Parse((User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)).Value);
            await ApiHelper.CreateBookAsync(_bookshelfService, Id, userId);
            return View();
        }

        public async Task<IActionResult> Read(string txtUrl)
        {
            var text = await ApiHelper.ReadBookAsync(txtUrl);
            ViewBag.Text = text;
            return View();
        }

        [HttpPost]
        public IActionResult Read()
        {
            return View();
        }

        public async Task<IActionResult> GetFavorites()
        {
            var userId = int.Parse((User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)).Value);
            var response = await _bookService.GetBooksAsync(userId);

            return this.ResponseView(response);
        }

        [HttpPost]
        public async Task<IActionResult> GetFavorites(BookListResult bookListResult)
        {
            return View();
        }

        public async Task<IActionResult> Delete(int bookId)
        {
            var response = await _bookService.RemoveAsync(bookId);
            return RedirectToAction("GetFavorites");
        }
    }
}