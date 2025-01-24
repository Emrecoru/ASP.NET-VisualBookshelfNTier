using Microsoft.AspNetCore.Mvc;

namespace SoftwareEngineering.VisualBookshelfNTier.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
