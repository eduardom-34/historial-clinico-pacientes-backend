using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entidades;

namespace API.Controllers
{
    [Route("api/[controller]")] // api/usuario HttpGet, HttpPost
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public UsuarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet] // api/usuario y retorna una lista de usuarios
        public ActionResult<IEnumerable<Usuario>> GetUsuarios()
        {
            var usuarios = _db.Usuarios.ToList();
            return Ok(usuarios);
        }

        [HttpGet("{id}")] // api/usuario/1
        public ActionResult<Usuario> GetUsuario(int id)
        {
            var usuario = _db.Usuarios.Find(id);
            return Ok(usuario);
        }
    }
}
 