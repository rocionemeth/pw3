using System.ComponentModel.DataAnnotations;

namespace Parcial1.Ventas.Entidades
{
    public class Venta
    {
        public Venta()
        { }

        public int IdVenta {get; set;}

        [Required(ErrorMessage = "El cliente es obligatorio")]
        [StringLength(50, ErrorMessage = "El cliente no puede superar los 50 caracteres")]
        public string Cliente {get; set;}

        [Required(ErrorMessage = "La cantidad vendida es obligatoria")]
        [Range(2, 299, ErrorMessage = "La cantidad vendida debe ser mayor a 1 y menor a 300")]
        public int CantidadVendida { get; set;}

        [Required(ErrorMessage = "El precio unitario es obligatorio")]
        [Range(10, 999, ErrorMessage = "El precio unitario debe ser mayor o igual a 10 y menor a 1000")]
        public int PrecioUnitario { get; set; }

        public double TotalVenta { get; set; }
    }
}
