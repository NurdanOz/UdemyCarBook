using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.ServiceDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.v1 ="Hİzmetler" ;
            ViewBag.v2 = "Hizmetlerimiz";
            return View();
        }
    }
}
