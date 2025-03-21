﻿using MarvelAplikacija.Data;
using Microsoft.AspNetCore.Mvc;
using MarvelAplikacija.Models;

namespace Timovi.Controllers
{
        [ApiController]
        [Route("api/v1/[controller]")]
        public class TimoviController : ControllerBase
        {

        private readonly MarvelContext _context;

        public TimoviController(MarvelContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_context.Timovi);
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
                    var s = _context.Timovi.Find(sifra);
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
            public IActionResult Post([FromBody] Tim tim, MarvelContext _context)
            {
                try
                {
                    _context.Timovi.Add(tim);
                    _context.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { sifra = tim.Sifra}, tim);

                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpPut]
            [Route("{sifra:int}")]
            [Produces("application/json")]
            public IActionResult Put(int sifra, [FromBody] Tim tim)
            {
                try
                {
                    var s = _context.Timovi.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                    s.Naziv = tim.Naziv;
                    s.Mjesto = tim.Mjesto;


                    _context.Timovi.Update(s);
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
                    var s = _context.Timovi.Find(sifra);
                    if (s == null)
                    {
                        return NotFound();
                    }
                    _context.Timovi.Remove(s);
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



