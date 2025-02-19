using MarvelAplikacija.Data;
using MarvelAplikacija.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelAplikacija.Controllers
{
    [ApiController]
    [Route("api/v1/[controller")]
    public class IdentitetController : ControllerBase
    {

        private readonly MarvelContext _context;

        public IdentitetController(MarvelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Identitet);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult Get(int sifra) {
            try
            {
                var s = _context.Identitet.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                return base.Ok(s);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpPost]
        public IActionResult Post(identiteti identitet)
        {
            try
            {
                _context.Identitet.Add(identitet);
                _context.SaveChanges();
                return Post(identitet);

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        private IActionResult Post(identiteti identitet)
        {
            return StatusCode(StatusCode.Status201Created, identitet);
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, IdentitetController identitet)
        {
            try
            {
                var s = _context.Identitet.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                s.ime = identitet.ime;
                s.prezime = identitet.prezime;
                s.godine = identitet.godine;
                s.god_rodjenja = identitet.god_rodjenja;
                s.god_smrti = identitet.god_smrti;


                _context.Identitet.Update(s);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspjesno promjenjeno" });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpDelete]
        [Route("{sifra:int}")]
        public IActionResult Delete(int sifra)
        {
            try
            {
                var s = _context.Identitet.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                _context.Identitet.Remove(s);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspjesno obrisano" });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }



        }
    }

