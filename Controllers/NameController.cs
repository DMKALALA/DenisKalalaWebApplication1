using Microsoft.AspNetCore.Mvc;

namespace DenisKalalaWebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var name = new { FirstName = "Denis", LastName = "Kalala" };
            return Ok(name);
        }
    }
}
