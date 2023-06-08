using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jewelry_ShoppingCart_.Controllers
{
    public class CatController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
