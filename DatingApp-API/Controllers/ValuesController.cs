using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_API.Controllers
{
    // http://localhost:5000/api/Values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();

            return Ok(values);
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/values
        // http://localhost:5000/api/Values
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };

        // }

        // Para generar una Respuesta HTTP usuamos IActionResult
        // GET api/values
        // http://localhost:5000/api/Values
        // [HttpGet]
        // public IActionResult Get()
        // {
        //     var values = _context.Values.ToList();
        //     return Ok(values);

        // }


        // // GET api/values/5
        // // http://localhost:5000/api/Values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value=> " + id;
        // }
        
         // Para generar una Respuesta HTTP usuamos IActionResult en lugar de ActionResult
        // GET api/values/5
        // http://localhost:5000/api/Values/5
        // [HttpGet("{id}")]
        // public IActionResult Get(int id)
        // {
        //     var value = _context.Values.FirstOrDefault( x => x.Id == id);
        //     return Ok(value);
        // }

    }
}
