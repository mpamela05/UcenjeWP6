using MarvelAplikacija.Data;
using Microsoft.AspNetCore.Mvc;

namespace Identitet.Controllers
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
        public IActionResult Get(int sifra)
        {
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
        public IActionResult Post(IdentitetController Identitet)
        {
            try
            {
                _context.Identitet.Add(Identitet);
                _context.SaveChanges();
                return Post(Identitet);

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
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
                s.ime = Identiteti.ime;
                s.prezime = Identiteti.prezime;
                s.godine = Identiteti.godine;
                s.god_rodjenja = Identiteti.god_rodjenja;
                s.god_smrti = Identiteti.god_smrti;


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

    internal class Identiteti
    {
        internal static object ime;
        internal static object prezime;
        internal static object godine;
        internal static object god_rodjenja;
        internal static object god_smrti;
    }
}

