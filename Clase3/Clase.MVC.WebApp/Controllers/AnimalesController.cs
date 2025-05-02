using Clase3.MVC.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase.MVC.WebApp.Controllers
{
    public class AnimalesController : Controller
    {
        private IAnimalServicio _animalServicio;

        public AnimalesController(IAnimalServicio animalServicio)
        {
            _animalServicio = animalServicio;
        }
        public IActionResult Index()
        {
            return View(_animalServicio.ObtenerAnimales());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agregar(string descripcion, decimal precio)
        {
            _animalServicio.AgregarAnimal(new Clase3.MVC.Entidades.Animal { Descripcion =  descripcion, Precio= precio });
            return RedirectToAction("Index");
        }
    }
}
