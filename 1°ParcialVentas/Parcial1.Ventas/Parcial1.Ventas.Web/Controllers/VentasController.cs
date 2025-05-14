using Microsoft.AspNetCore.Mvc;
using Parcial1.Ventas.Entidades;
using Parcial1.Ventas.Logica;

namespace Parcial1.Ventas.Web.Controllers
{
    public class VentasController : Controller
    {
        private readonly IVentasLogica _ventasLogica;

        public VentasController(IVentasLogica ventasLogica)
        {
            _ventasLogica = ventasLogica;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Venta venta)
        {
            if (!ModelState.IsValid)
            {
                return View(venta);
            }

            _ventasLogica.RegistrarVenta(venta);
            TempData["Mensaje"] = $"Venta registrada con exito. {venta.Cliente} (Total de venta: {venta.TotalVenta})";

            return RedirectToAction("Resultados");
        }

        [HttpGet]
        public IActionResult Resultados()
        {
            List<Venta> ventas = _ventasLogica.ObtenerVentas();
            return View(ventas);
        }
    }
}