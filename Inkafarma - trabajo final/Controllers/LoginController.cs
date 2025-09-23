using Microsoft.AspNetCore.Mvc;

namespace Inkafarma___trabajo_final.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(string usuario, string contraseña)
        {
            // Aquí validarías las credenciales
            if (usuario == "admin" && contraseña == "123") // Ejemplo simple
            {
                return RedirectToAction("Index", "Dashboard");
            }

            // Si falla, regresa al login
            return View();
        }
    }
}
