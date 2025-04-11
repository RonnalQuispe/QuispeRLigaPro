using QuispeRLigaPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace QuispeRLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
            List<Equipo> equipos = new List <Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                TotalPuntos = 30,

            };
            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 0,
                PartidosPerdidos = 6,
                TotalPuntos = 3,

            };
            equipos.Add(ldu);
            equipos.Add(bsc);

            return View(equipos);
        }
    }
}
