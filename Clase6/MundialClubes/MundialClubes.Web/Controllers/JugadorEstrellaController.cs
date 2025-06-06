using Microsoft.AspNetCore.Mvc;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;

namespace MundialClubes.Web.Controllers
{
    public class JugadorEstrellaController : Controller
    {
        private readonly IJugadorEstrellaLogica _jugadorEstrellaLogica;

        public JugadorEstrellaController(IJugadorEstrellaLogica jugadorEstrellaLogica)
        {
            _jugadorEstrellaLogica = jugadorEstrellaLogica;
        }

        public IActionResult Lista()
        {
            return View(_jugadorEstrellaLogica.ObtenerTodosLosJugadores());
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(JugadorEstrella jugador)
        {
            if (ModelState.IsValid)
            {
                _jugadorEstrellaLogica.AgregarJugador(jugador);
                return Redirect("Lista");
            }
            return View();
        }

        public IActionResult Editar(int id)
        {
            var jugador = _jugadorEstrellaLogica.ObtenerJugadorPorId(id);
            if (jugador == null)
            {
                return NotFound();
            }
            return View(jugador);
        }

        [HttpPost]
        public IActionResult Editar(JugadorEstrella jugador)
        {
            if (ModelState.IsValid)
            {
                _jugadorEstrellaLogica.Actualizar(jugador);
                return RedirectToAction("Lista");
            }
            return View(jugador);
        }

        public IActionResult Eliminar(int id)
        {  
            _jugadorEstrellaLogica.EliminarJugador(id);
            return RedirectToAction("Lista"); 
        }

    }
}
