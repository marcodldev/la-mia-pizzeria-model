using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using var ctx = new PizzaContext();

            var pizze = ctx.Pizze.ToArray();

            return View(pizze);
        }

        [HttpGet]
        public IActionResult Show(int Id) 
        {
            using var ctx = new PizzaContext();

            var pizze = ctx.Pizze.SingleOrDefault(p => p.Id == Id);

            if (pizze == null)
            {
                return NotFound($"Pizza {Id} non trovata");
            }

            return View(pizze);
        }
    }
}
