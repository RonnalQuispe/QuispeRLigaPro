using QuispeRLigaPro.Models;
using Microsoft.AspNetCore.Mvc;
using QuispeRLigaPro.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuispeRLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public IActionResult List()
        {
            
            var equipos = _repository.DevuelveListadoEquipos();
            return View(equipos);
        }
        public IActionResult EditarEquipo(int Id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(Id);
            return View(equipo);
        }
        [HttpPost]/* guardar informacion */

        public IActionResult EditarEquipo(Equipo equipo)
        {
            try
            {
                var equipoExistente = _repository.DevuelveInformacionEquipo(equipo.Id);

                if (equipoExistente != null)
                {
                    equipoExistente.PartidosJugados = equipo.PartidosJugados;
                    equipoExistente.PartidosGanados = equipo.PartidosGanados;
                    equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                    equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;

                    var actualizado = _repository.ActualizarEquipo(equipoExistente);
                    return RedirectToAction("List");
                }

                ViewData["Mensaje"] = "El equipo no fue encontrado.";
                return View(equipo);
            }
            catch (Exception e)
            {
                ViewData["Mensaje"] = "Ocurrio un error al actualizar el equipo: " + e.Message;
                return View(equipo);
            }


        }
    }
}

