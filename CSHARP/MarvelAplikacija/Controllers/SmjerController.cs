using MarvelAplikacija.Data;
using Microsoft.AspNetCore.Mvc;

namespace MarvelAplikacija.Controllers
{
    [ApiController]
    [Route("api/v1/[controller")]
    public class SmjerController : ControllerBase
    {

        private readonly MarvelContext _context;

        public SmjerController(MarvelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Smjerovi);
            }
            catch (Exception e) 
            {
                return BadRequest(e);
            }
        }
    }
}
