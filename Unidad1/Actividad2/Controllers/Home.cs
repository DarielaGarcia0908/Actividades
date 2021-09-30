using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actividad2.Models;

namespace Actividad2.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index(float c1, float c2, float c3)
        {
            PromedioViewModel promedio = new PromedioViewModel();
            promedio.Calif1 = c1;
            promedio.Calif2 = c2;
            promedio.Calif3 = c3;

            return View(promedio);
        }
    }
}
