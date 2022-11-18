using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiFinalEngelstajnSebastian.Data;
using WebApiFinalEngelstajnSebastian.Model;
using System.Linq;

namespace WebApiFinalEngelstajnSebastian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly DBHospitalAPIContext _context;
        public HospitalController(DBHospitalAPIContext context)
        {
            _context = context;
        }
        [HttpGet]
        public dynamic Get()
        {
            dynamic hospitales = (from d in _context.hospitales select new { d.Nombre, d.Telefono, d.Num_Cama }).ToList();
            return hospitales;
        }


        [HttpGet("{num_cama}")]
        public dynamic Get(int num_cama)
        {
            dynamic hospitales = (from d in _context.hospitales where d.Num_Cama > num_cama select new { d.Nombre, d.Telefono, d.Num_Cama }).ToList();
            return hospitales;
        }
    }
}
