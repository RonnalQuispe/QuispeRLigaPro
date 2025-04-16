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
            EquipoRepository repository = new EquipoRepository();
            var equipo = _repository.DevuelveInformacionEquipo(Id);
            return View(equipo);
    }
        [HttpPost]/* guardar informacion */

        public IActionResult EditarEquipo(Equipo equipo)
        {
            try
            {
                var actualizar = _repository.ActualizarEquipo(equipo);
                return View();
            }
            catch(Exception e)
            {
                ViewData["Mensaje"] = "Ocurri un error al actualizar el equipo";
                return View();
            }
        }
    }
}

