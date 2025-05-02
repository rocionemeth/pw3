using System.Net.NetworkInformation;
using Clase3.MVC.Entidades;

namespace Clase3.MVC.Servicio
{
    public interface IAnimalServicio
    {
        List<Animal> ObtenerAnimales();
        void AgregarAnimal(Animal animal);
    }
    public class AnimalServicio : IAnimalServicio
    {
        private static List<Animal> _animales { get; set; }

        public AnimalServicio()
        {
            if (_animales == null)
            {
                _animales = new List<Animal>();
                _animales.Add(new Animal { Descripcion = "Leon", Precio = 100, Imagen = "/imagenes/imagen1.jpg" });
                _animales.Add(new Animal { Descripcion = "Jirafa", Precio = 200, Imagen = "/imagenes/imagen2.jpg" });
                _animales.Add(new Animal { Descripcion = "Oso", Precio = 300, Imagen = "/imagenes/imagen3.jpg" });

            }
        }
        public List<Animal> ObtenerAnimales()
        {
            return _animales;
        }

        public void AgregarAnimal(Animal animal)
        {
            _animales.Add(animal);  
        }


    }
}
