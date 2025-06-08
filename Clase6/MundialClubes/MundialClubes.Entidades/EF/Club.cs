using System;
using System.Collections.Generic;

namespace MundialClubes.Entidades.EF;

public class Club
{
    public int IdClub { get; set; } 

    public string Nombre { get; set; } = null!;

    public int? IdJugadorEstrella { get; set; } 

    public virtual JugadorEstrella? JugadorEstrella { get; set; }
}
