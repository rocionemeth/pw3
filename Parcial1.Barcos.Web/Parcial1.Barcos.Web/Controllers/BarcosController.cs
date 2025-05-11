using Microsoft.AspNetCore.Mvc;
using Parcial1.Barcos.Entidades;
using Parcial1.Barcos.Logica;

namespace Parcial1.Barcos.Web.Controllers
{
    public class BarcosController : Controller
    {
        private readonly IBarcosLogica _barcosLogica;

        public BarcosController(IBarcosLogica barcosLogica)
        {
            _barcosLogica = barcosLogica;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Barco barco)
        {
            if (!ModelState.IsValid)
            {
                return View(barco);
            }

            _barcosLogica.RegistrarBarco(barco);
            TempData["Mensaje"] = $"Barco registrado con exito. {barco.NombreBarco}(Tasa: {barco.Tasa})";

            return RedirectToAction("Listados");
        }

        [HttpGet]
        public IActionResult Listados()
        {
            List<Barco> barcos = _barcosLogica.ObtenerBarcos();
            return View(barcos);
        }
    }
}
