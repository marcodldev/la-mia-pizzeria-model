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
    }
}
