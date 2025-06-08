using System;
using System.Collections.Generic;

namespace MundialClubes.Entidades.EF;

public class JugadorEstrella
{
    public int IdJugadorEstrella { get; set; } 

    public string Nombre { get; set; } = null!;

    public int Edad { get; set; }

    public string FotoUrl { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual Club? Club { get; set; }
}
