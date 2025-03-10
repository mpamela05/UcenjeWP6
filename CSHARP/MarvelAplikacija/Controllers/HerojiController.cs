using MarvelAplikacija.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarvelAplikacija.Models;

namespace MarvelAplikacija.Controllers
{

        [ApiController]
        [Route("api/v1/[controller]")]
        public class HerojiController : ControllerBase
        {

        private readonly MarvelContext _context;

        public HerojiController(MarvelContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                var heroji = _context.Heroji.Include(h => h.Identitet).Include(h => h.Tim).ToList();
                return Ok(heroji);
                //return Ok(_context.Heroji);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            [HttpGet]
            [Route("{sifra:int}")]
            public IActionResult Get(int sifra)
            {
                try
                {
                var s = _context.Heroji
                    .Include(h => h.Identitet)
                    .Include(h => h.Tim)
                    .FirstOrDefault(h => h.Sifra == sifra);
                if (s == null)
                {
                    return NotFound();
                }
                    return base.Ok(s);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }

            }

        [HttpPost]
            public IActionResult Post([FromBody] Heroji heroj)
            {
                try
                {
                    _context.Heroji.Add(heroj);
                    _context.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { sifra = heroj.Sifra }, heroj);


                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }


            [HttpPut]
            [Route("{sifra:int}")]
            [Produces("application/json")]
            public IActionResult Put(int sifra, [FromBody] Heroji heroj)
            {
                try
                {
                    var s = _context.Heroji.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                    s.Ime = heroj.Ime;
                    s.Moc = heroj.Moc;
                    s.Mjesto = heroj.Mjesto;
                    s.Osobnost = heroj.Osobnost;
                    s.G_dolaska = heroj.G_dolaska;


                    _context.Heroji.Update(s);
                    _context.SaveChanges();
                    return Ok(new { poruka = "Uspjesno promjenjeno" });
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            [HttpDelete]
            [Route("{sifra:int}")]
            public IActionResult Delete(int sifra)
            {
                try
                {
                    var s = _context.Heroji.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                    _context.Heroji.Remove(s);
                    _context.SaveChanges();
                    return Ok(new { poruka = "Uspjesno obrisano" });
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }



            }
        }
}



