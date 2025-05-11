using Parcial1.Barcos.Entidades;

namespace Parcial1.Barcos.Logica;

    public interface IBarcosLogica
    {
        void RegistrarBarco(Barco barco);
        List<Barco> ObtenerBarcos();
    }

    public class BarcosLogica : IBarcosLogica
    {
        private static List<Barco> _barcos = new List<Barco>();

        private void ValidarBarco(Barco barco)
        {
        //validar que no sea null
            if (barco == null)
            {
                throw new ArgumentNullException(nameof(barco), "El barco no puede ser nulo.");
            }

            // Validar los parámetros de entrada
            if (string.IsNullOrEmpty(barco.NombreBarco))
            {
                throw new ArgumentNullException("El nombre del barco no puede estar vacio");
            }

            if (barco.Antiguedad < 0)
            {
                throw new ArgumentOutOfRangeException("La antiguedad no puede ser negativa");
            }

            if (barco.TripulacionMaxima < 0)
            {
                throw new ArgumentOutOfRangeException("La tripulacion maxima no puede ser negativa");
            }
        }

        private int GenerarNuevoIdBarco()
        {
            // Obtener el último ID de barco registrado
            int ultimoId = _barcos.Count > 0 ? _barcos.Max(m => m.IdBarco) : 0;
            // Asignar un nuevo ID a la nueva misión
            return ultimoId + 1;
        }

        public double CalcularTasa(int antiguedad, int tripulacionMaxima)
        {
            if (tripulacionMaxima == 0)
            {
                throw new ArgumentException("Los tripulacion Maxima no pueden ser 0");
            }
            return Math.Round((antiguedad*0.25) + (tripulacionMaxima/3.0), 2);
        }

        public void RegistrarBarco(Barco barco)
        {
            ValidarBarco(barco);

            // Calcular el índice de eficiencia
            barco.Tasa = CalcularTasa(barco.Antiguedad, barco.TripulacionMaxima);
            barco.IdBarco = GenerarNuevoIdBarco();

            // Guardar nuevoBarco en la base de datos o lista
            _barcos.Add(barco);

        }

        public List<Barco> ObtenerBarcos()
        {
            return _barcos
                .OrderBy(m => m.IdBarco)
                .ToList();
        }
    }
