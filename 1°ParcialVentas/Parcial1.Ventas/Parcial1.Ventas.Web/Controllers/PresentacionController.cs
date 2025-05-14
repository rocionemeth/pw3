using Microsoft.AspNetCore.Mvc;

namespace Parcial1.Ventas.Web.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
