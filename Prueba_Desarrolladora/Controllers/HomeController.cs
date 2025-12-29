using Microsoft.AspNetCore.Mvc;
using Prueba_Desarrollador.Models.Db;
using Prueba_Desarrolladora.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Prueba_Desarrolladora.Controllers
{
    public class HomeController : Controller
    {
        private readonly GestionBibliotecaContext _context;

        public HomeController(GestionBibliotecaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var gestionBibliotecaContext = _context.Libros.Include(l => l.Autor);
            return View(await gestionBibliotecaContext.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
