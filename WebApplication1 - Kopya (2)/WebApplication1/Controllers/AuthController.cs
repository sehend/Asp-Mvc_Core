using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public  IActionResult Login(   )
        {
        



            return Created("", new TokenGeneroter().GenerateToken("Admin"));
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Get()
        {




            return Ok();
        }
    }
}
