using QuispeRLigaPro.Models;
using Microsoft.AspNetCore.Mvc;
using QuispeRLigaPro.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuispeRLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
            EquipoRepository repositorio = new EquipoRepository();
            var equipos = repositorio.DevuelveListadoEquipos();
            return View(equipos);
        }
        public IActionResult EditarEquipo()
        {
            Equipo ldu = new Equipo { 
            Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                TotalPuntos = 30,
                };
            return View(ldu);
    }
    }
}

