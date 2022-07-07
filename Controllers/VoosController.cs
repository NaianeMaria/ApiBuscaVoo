using ApiBuscaVoos.Context;
using ApiBuscaVoos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBuscaVoos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoosController : ControllerBase
    {
        private readonly ApiDbContext _context; 
        public VoosController(ApiDbContext context)
        {
            _context = context; 

        }

        //[HttpGet("")]
       // public IEnumerable<Voo> Get()
       // {

        //}
    }
}
