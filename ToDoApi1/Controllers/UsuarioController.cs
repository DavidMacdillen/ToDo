using Microsoft.AspNetCore.Mvc;
using ToDoApi1.Moldes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<usuarioModel> Get()
        {
            List<usuarioModel> usuarioModel = new List<usuarioModel>();

            usuarioModel.Add(new usuarioModel() { Id = 1, Nome = "David Macdillen", Email = "daviddevitamacdillen@gmail.com"});

            return usuarioModel;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public usuarioModel Get(int id)
        {
            usuarioModel usuario = new usuarioModel() { Id = 1, Nome = "David Macdillen", Email = "daviddevitamacdillen@gmail.com" };
            return usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] usuarioModel usuario)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] usuarioModel usuario)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
