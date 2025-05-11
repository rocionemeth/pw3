using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Parcial1.Barcos.Entidades
{
    public class Barco
    {
        public Barco() 
        { }

        public int IdBarco { get; set; }

        [Required(ErrorMessage = "El nombre del barco es obligatorio.")]
        [StringLength(40, ErrorMessage = "El nombre del barco no puede exceder los 40 caracteres.")]
        public string NombreBarco { get; set; }

        [Required(ErrorMessage = "La antiguedad es obligatoria.")]
        [Range(1, 49, ErrorMessage = "La antiguedad debe ser mayor a 0 y ser menor a 50.")]
        public int Antiguedad { get; set; }


        [Required(ErrorMessage = "La tripulacion maxima son obligatorias.")]
        [Range(10, 1000, ErrorMessage = "La tripulacion maxima deben estar entre 10 y 1000 inclusive.")]
        public int TripulacionMaxima { get; set; }
        
        public double Tasa { get; set; }

    }
}
