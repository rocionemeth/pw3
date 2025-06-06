using MundialClubes.Entidades.EF;

namespace MundialClubes.Logica;

public interface IJugadorEstrellaLogica
{
    List<JugadorEstrella> ObtenerTodosLosJugadores();
    
    void AgregarJugador(JugadorEstrella jugador);

    JugadorEstrella ObtenerJugadorPorId(int id);

    void EliminarJugador(int idJugador);
    void Actualizar(JugadorEstrella jugador);
}

    public class JugadorEstrellaLogica : IJugadorEstrellaLogica
    {
        private readonly MundialClubesContext _context;

        public JugadorEstrellaLogica(MundialClubesContext context)
        {
            _context = context;
        }

        public List<JugadorEstrella> ObtenerTodosLosJugadores()
        {
            return _context.JugadorEstrellas.ToList();
        }

        public void AgregarJugador(JugadorEstrella jugador)
        {
            _context.JugadorEstrellas.Add(jugador);
            _context.SaveChanges();
        }

        public JugadorEstrella ObtenerJugadorPorId(int id)
        {
            return _context.JugadorEstrellas.Find(id);
        }

    public void Actualizar(JugadorEstrella jugador)
        {
            var jugadorExistente = _context.JugadorEstrellas.Find(jugador.IdJugadorEstrella);
            if (jugadorExistente != null)
            {
                jugadorExistente.Nombre = jugador.Nombre;
                jugadorExistente.Edad = jugador.Edad;
                jugadorExistente.FotoUrl = jugador.FotoUrl;
                jugadorExistente.Descripcion = jugador.Descripcion;
                _context.SaveChanges();
            }
    }


    public void EliminarJugador(int idJugador)
        {
            var jugador = _context.JugadorEstrellas.Find(idJugador);
            if (jugador != null)
            {
                _context.JugadorEstrellas.Remove(jugador);
                _context.SaveChanges();
            }
        }

    }

