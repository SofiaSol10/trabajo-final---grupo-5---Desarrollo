using Microsoft.AspNetCore.Mvc;

namespace Inkafarma___trabajo_final.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Método para la sección de Ventas
        public IActionResult Ventas()
        {
            return View();
        }

        // Método para Pedidos Digitales
        public IActionResult PedidosDigitales()
        {
            return View();
        }

        // Método para Inventario
        public IActionResult Inventario()
        {
            return View();
        }
    }
}
