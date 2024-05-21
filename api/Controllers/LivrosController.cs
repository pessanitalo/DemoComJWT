using DemoJWT.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly DataContext _context;

        public LivrosController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get() 
        { 
            var livros = _context.Livros.ToList();
            return Ok(livros);
        }
    }
}
