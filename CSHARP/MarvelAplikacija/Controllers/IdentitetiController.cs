using MarvelAplikacija.Data;
using Microsoft.AspNetCore.Mvc;
using MarvelAplikacija.Models;

namespace MarvelAplikacija.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IdentitetiController : ControllerBase
    {

        private readonly MarvelContext _context;

        public IdentitetiController(MarvelContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Identiteti);
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
                var s = _context.Identiteti.Find(sifra);
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
        public IActionResult Post([FromBody] Identiteti identitet)
        {
            try
            {
                _context.Identiteti.Add(identitet);
                _context.SaveChanges();
                return CreatedAtAction(nameof(Get), new { sifra = identitet.Sifra }, identitet);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, [FromBody] Identiteti identitet)
        {
            try
            {
                var s = _context.Identiteti.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                s.Ime = identitet.Ime;
                s.Prezime = identitet.Prezime;
                s.Godine = identitet.Godine;
                s.God_rodjenja = identitet.God_rodjenja;
                s.God_smrti = identitet.God_smrti;


                _context.Identiteti.Update(s);
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
                var s = _context.Identiteti.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                _context.Identiteti.Remove(s);
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

