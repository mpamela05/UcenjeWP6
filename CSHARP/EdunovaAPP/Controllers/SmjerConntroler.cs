using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerConntroler : ControllerBase
    {
        private readonly EdunovaContext _context;

        public SmjerConntroler(EdunovaContext context)
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
