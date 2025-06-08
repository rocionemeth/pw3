using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;

namespace MundialClubes.Web.Controllers
{
    public class JugadorEstrellaController : Controller
    {
        private readonly IJugadorEstrellaLogica _jugadorEstrellaLogica;
        private readonly IClubLogica _clubLogica;

        public JugadorEstrellaController(IJugadorEstrellaLogica jugadorEstrellaLogica, IClubLogica clubLogica)
        {
            _jugadorEstrellaLogica = jugadorEstrellaLogica;
            _clubLogica = clubLogica;
        }

        public IActionResult Lista()
        {
            return View(_jugadorEstrellaLogica.ObtenerTodosLosJugadores());
        }

        public IActionResult Agregar()
        {
            CargarViewBagClubs();
            return View();
        }

        private void CargarViewBagClubs(int? idClub = null)
        {
            List<Club> clubs = _clubLogica.ObtenerTodosLosClubs();
            var clubsItems = new SelectList(clubs.ToList(), "IdClub", "Nombre", idClub);
            ViewBag.Clubs = clubsItems;
        }

        [HttpPost]
        public IActionResult Agregar(JugadorEstrella jugador, int? IdClub, string? NuevoClub)
        {
            if (ModelState.IsValid)
            {
                // Verificar si se ingresó un nuevo club
                AsignarClubAJugador(jugador, IdClub, NuevoClub);
                _jugadorEstrellaLogica.AgregarJugador(jugador);
                return Redirect("Lista");
            }
            CargarViewBagClubs();
            return View(jugador);
        }

        private void AsignarClubAJugador(JugadorEstrella jugadorEstrella, int? IdClub, string? NuevoClub)
        {
            if (!string.IsNullOrEmpty(NuevoClub))
            {
                jugadorEstrella.Club = new Club
                {
                    Nombre = NuevoClub,
                    IdJugadorEstrella = jugadorEstrella.IdJugadorEstrella 
                };
            }
            else if (IdClub != null)
            {
                var club = _clubLogica.ObtenerPorId(IdClub);
                jugadorEstrella.Club = club;
            }
            else
            {
                jugadorEstrella.Club = null;
            }
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
