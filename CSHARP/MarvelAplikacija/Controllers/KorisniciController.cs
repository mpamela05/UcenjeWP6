using MarvelAplikacija.Data;
using Microsoft.AspNetCore.Mvc;
using MarvelAplikacija.Models;

namespace Korisnici.Controllers
{
        [ApiController]
        [Route("api/v1/[controller]")]
        public class KorisniciController : ControllerBase
        {

            private readonly MarvelContext _context;

            public KorisniciController(MarvelContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_context.Korisnici);
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
                    var s = _context.Korisnici.Find(sifra);
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
            public IActionResult Post([FromBody] Korisnik korisnik, MarvelContext _context)
            {
                try
                {
                    _context.Korisnici.Add(korisnik);
                    _context.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { sifra = korisnik.Sifra }, korisnik);

            }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }


            [HttpPut]
            [Route("{sifra:int}")]
            [Produces("application/json")]
            public IActionResult Put(int sifra, [FromBody] Korisnik korisnik)
            {
                try
                {
                    var s = _context.Korisnici.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                     s.Nadimak = korisnik.Nadimak;
                     s.Lozinka = korisnik.Lozinka;
                     s.Mail = korisnik.Mail;
                     s.Uloga = korisnik.Uloga;

                _context.Korisnici.Update(s);
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
                    var s = _context.Korisnici.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                    _context.Korisnici.Remove(s);
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
