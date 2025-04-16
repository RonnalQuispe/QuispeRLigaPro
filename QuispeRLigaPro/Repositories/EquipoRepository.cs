using QuispeRLigaPro.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuispeRLigaPro.Repositories
{
    public class EquipoRepository
    {
        private static List<Equipo> _equipos = new List<Equipo>
        {
            new Equipo { Id = 1, Nombre = "Barcelona", 
                PartidosJugados = 5, 
                PartidosGanados = 3, 
                PartidosEmpatados = 1, 
                PartidosPerdidos = 1 },
            new Equipo { Id = 2, Nombre = "Liga de Quito",
                PartidosJugados = 5, 
                PartidosGanados = 2,
                PartidosEmpatados = 2, 
                PartidosPerdidos = 1 }
        };

        public List<Equipo> DevuelveListadoEquipos()
        {
            return _equipos;
        }

        public Equipo DevuelveInformacionEquipo(int id)
        {
            return _equipos.FirstOrDefault(e => e.Id == id);
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            var equipoExistente = _equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if (equipoExistente != null)
            {
                equipoExistente.PartidosJugados = equipo.PartidosJugados;
                equipoExistente.PartidosGanados = equipo.PartidosGanados;
                equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;
                return true;
            }
            return false;
        }
    }
}
