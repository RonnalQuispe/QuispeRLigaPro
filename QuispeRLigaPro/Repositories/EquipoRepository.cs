using QuispeRLigaPro.Models;

namespace QuispeRLigaPro.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                

            };
        Equipo bsc = new Equipo
        {
            Id = 2,
            Nombre = "BSC",
            PartidosJugados = 10,
            PartidosGanados = 1,
            PartidosEmpatados = 0,
            PartidosPerdidos = 6,
            

        };
            equipos.Add(ldu);
            equipos.Add(bsc);
            equipos = equipos.OrderByDescending(item => item.TotalPuntos).ToList();
            return equipos;

        }
        public Equipo DevuelveInformacionEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.First(item => item.Id == Id );
            return equipo;
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            return true;
        }
}
}
