using KhN.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhN.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        public PersonController()
        {
        }

        [HttpPost]
        public string Hello([FromBody]Person model)
        {
            string message = $"Hello {model.UserName}";
            return message;
        }
    }
}