using ApiBuscaVoos.Context;
using ApiBuscaVoos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiBuscaVoos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AeroportosController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public AeroportosController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet] 
        public ActionResult<IEnumerable<Aeroporto>> Get()
        {
            var aeroportos = _context.Aeroportos.AsNoTracking().ToList();
            if(aeroportos is null)
            {
                return NotFound();
            }

            return aeroportos;
        }

    }
}
