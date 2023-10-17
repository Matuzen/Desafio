using Desafio.Data;
using Desafio.Model;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("v1")]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        //public List<DesafioModel> Get([FromServices] AppDbContext context)
        public ActionResult<string> Get()

        {
            return Ok();
        }
    }
}