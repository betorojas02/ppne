using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pruebanexos.Models;

namespace pruebanexos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamareroController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public CamareroController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        [Route("listCamarero")]
        public ActionResult<Camarero> Get()
        {
            try
            {
                var listCliente = _context.Camarero.ToList();
                return Ok(listCliente);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("save")]
        public ActionResult SaveFactura([FromBody] dynamic dato)
        {
            try
            {

                return Ok(dato);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



   
    }
}
