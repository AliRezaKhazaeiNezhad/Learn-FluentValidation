using KhN.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhN.Web.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person model)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                message = $"Hello {model.UserName}";
            }

            return View();
        }
    }
}
