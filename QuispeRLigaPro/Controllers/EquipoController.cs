using QuispeRLigaPro.Models;
using Microsoft.AspNetCore.Mvc;
using QuispeRLigaPro.Repositories;

namespace QuispeRLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
         EquipoRepository repositorio = new EquipoRepository();
            var equipos= repositorio.DevuelveListadoEquipos();
            return View(equipos);
        }
    }
}

