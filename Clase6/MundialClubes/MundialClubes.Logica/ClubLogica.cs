using MundialClubes.Entidades.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundialClubes.Logica
{
    public interface IClubLogica
    {
        List<Club> ObtenerTodosLosClubs();
        Club ObtenerPorId(int? idClub);
        void AgregarClub(Club club);
    }
    public class ClubLogica : IClubLogica
    {
        private readonly MundialClubesContext _context;
        public ClubLogica(MundialClubesContext context)
        {
            _context = context;
        }
        public Club ObtenerPorId(int? idClub)
        {
            if (idClub == null)
            {
                return null;
            }

            return _context.Clubs.Find(idClub);
        }

        public List<Club> ObtenerTodosLosClubs()
        {
            return _context.Clubs.OrderBy(p => p.Nombre).ToList();
        }

        public void AgregarClub(Club club)
        {
            _context.Clubs.Add(club);
            _context.SaveChanges();
        }
    }
}


