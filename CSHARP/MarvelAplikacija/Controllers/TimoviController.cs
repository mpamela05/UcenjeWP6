using MarvelAplikacija.Data;
using Microsoft.AspNetCore.Mvc;

namespace Timovi.Controllers
{
   
        [ApiController]
        [Route("api/v1/[controller")]
        public class TimoviController : ControllerBase
        {

            private readonly MarvelContext _context;
        private object naziv;
        private object mjesto;

        public TimoviController(MarvelContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_context.timovi);
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            [HttpGet]
            [Route("{sifra:int}")]
            public IActionResult Get(int sifra)
            {
                try
                {
                    var s = _context.Timovi.Find(sifra);
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

        public MarvelContext Get_context()
        {
            return _context;
        }

        [HttpPost]
            public IActionResult Post(TimoviController timovi, MarvelContext _context)
            {
                try
                {
                _context.Timovi.Add(timovi);
                    _context.SaveChanges();
                    return Post(timovi, Get_context());

                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }

            [HttpPut]
            [Route("{sifra:int}")]
            [Produces("application/json")]
            public IActionResult Put(int sifra, TimoviController timovi)
            {
                try
                {
                    var s = _context.timovi.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                    s.naziv = timovi.naziv;
                    s.mjesto = timovi.mjesto;


                    _context.timovi.Update(s);
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
                    var s = _context.timovi.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                    _context.timovi.Remove(s);
                    _context.SaveChanges();
                    return Ok(new { poruka = "Uspjesno obrisano" });
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }



            }
        }
    }



