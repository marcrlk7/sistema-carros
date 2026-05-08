using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AgenciaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Codigo()
        {
            return View();
        }

        public IActionResult Descricao()
        {
            return View();
        }
        //sla
        public IActionResult Cidade()
        {
            return View();
        }

        public IActionResult Estado()
        {
            return View();
        }
    }
}
