using Parcial1.Ventas.Entidades;
namespace Parcial1.Ventas.Logica
{
    public interface IVentasLogica
    {
        void RegistrarVenta(Venta venta);
        List<Venta> ObtenerVentas();

    }

    public class VentasLogica : IVentasLogica
    {
        private static List<Venta> _ventas = new List<Venta> ();

        private int GenerarNuevoIdVenta()
        {
            int ultimoId = _ventas.Count > 0 ? _ventas.Max(m => m.IdVenta) : 0;
            return ultimoId + 1;
        }
        public double CalcularTotalVenta(int cantidadVendida, int precioUnitario)
        {
            if (precioUnitario == 0)
            {
                throw new ArgumentException("El precio unitario no puede ser 0");
            }

            return Math.Round(((double)cantidadVendida * precioUnitario), 2);
        }

        public void RegistrarVenta(Venta venta)
        {
            venta.TotalVenta = CalcularTotalVenta(venta.CantidadVendida, venta.PrecioUnitario);
            venta.IdVenta = GenerarNuevoIdVenta();
            _ventas.Add(venta);
        }

        public List<Venta> ObtenerVentas()
        {
            return _ventas
                .OrderBy(m => m.IdVenta)
                .ToList();
        }

    }
}
