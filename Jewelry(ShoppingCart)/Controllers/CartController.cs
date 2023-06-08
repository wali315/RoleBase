using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jewelry_ShoppingCart_.Controllers
{
    public class CartController : Controller
    {
        [Authorize(Policy ="ManagerOrAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
