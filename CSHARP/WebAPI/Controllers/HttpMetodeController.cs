using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {

        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [HttpGet]
        [Route("helloworld")]
        public string HelloWorld(string ime)
        {
            return $"Hello {ime}!";
        }


        [HttpGet]
        [Route("json")]
        public IActionResult Json(int sifra, string ime)
        {
            return Ok(new { Sifra = sifra, Ime = ime });
        }


        [HttpPost]
        public IActionResult Post(Identiteti identiteti)
        {
            identiteti.ime = "Hello " + identiteti.ime;
            return StatusCode(201, identiteti);
            
        }

        [HttpPut]
        public IActionResult Put(Identiteti identiteti)
        {
            identiteti.ime = "Hello " + identiteti.ime;
            return StatusCode(StatusCodes.Status206PartialContent, identiteti);
        }


        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new {poruka="Sifra mora biti veca od 0" });
            }
                return StatusCode(StatusCodes.Status204NoContent);
                
        }



    }
}
