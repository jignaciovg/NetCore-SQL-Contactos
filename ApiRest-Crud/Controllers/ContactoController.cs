using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiRest_Crud.Context;
using ApiRest_Crud.Models;

namespace ApiRest_Crud.Controllers
{
    [ApiController]
    public class ContactoController : ControllerBase
    {
        private readonly ContactoContext _context;

        public ContactoController(ContactoContext context)
        {
            _context = context;
        }

        // GET: Contactos
        [HttpGet]
        [Route("api/[controller]")]
        public async Task<ActionResult<IEnumerable<Contacto>>> GetAll()
        {
            return await _context.Contacto.ToListAsync();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public Contacto GetById(int id)
        {
            var contacto = _context.Contacto.FirstOrDefault(p => p.Id == id);
            return contacto;
        }

        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult Post([FromBody] Contacto contacto)
        {
            try
            {
                _context.Contacto.Add(contacto);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public ActionResult Post(int id, [FromBody] Contacto contacto)
        {
            try
            {
                if (contacto.Id == id)
                {
                    _context.Entry(contacto).State = EntityState.Modified;
                    _context.SaveChanges();
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public ActionResult Delete(int id)
        {
            var contacto = _context.Contacto.FirstOrDefault(c => c.Id == id);
            if (contacto != null)
            {
                _context.Contacto.Remove(contacto);
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
