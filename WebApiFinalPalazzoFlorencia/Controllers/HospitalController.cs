using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFinalPalazzoFlorencia.Data;
using System.Linq;

namespace WebApiFinalPalazzoFlorencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly DBHospitalContext _context;
        public HospitalController(DBHospitalContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public dynamic Get()
        {
            dynamic hospitales = (from d in _context.Hospitales select new { d.Nombre, d.Telefono, d.NumCama }).ToList();
            return hospitales;
        }


        [HttpGet("{num_cama}")]
        public dynamic Get(int num_cama)
        {
            dynamic hospitales = (from d in _context.Hospitales where d.NumCama > num_cama select new { d.Nombre, d.Telefono, d.NumCama }).ToList();
            return hospitales;
        }
    }
}
