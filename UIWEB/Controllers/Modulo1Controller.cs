using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIWEB.Controllers
{
    public class Modulo1Controller : Controller
    {        
        public IActionResult VistaDocente()
        {
            return View();
        }
        public IActionResult VistaCursos()
        {
            return View();
        }
        public IActionResult VistaAlumnos()
        {
            return View();
        }
        public IActionResult VistaCalificaciones()
        {
            return View();
        }
    }
}
