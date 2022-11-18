using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiFinalEngelstajnSebastian.Data;
using WebApiFinalEngelstajnSebastian.Model;

namespace WebApiFinalEngelstajnSebastian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DBHospitalAPIContext _context;
        public DoctorController(DBHospitalAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List <Doctor> doctores ()
        {
            List<Doctor> doctores = _context.doctores.ToList ();
            return doctores;
        }
        [HttpGet("{id}")]
        public Doctor GetId(int id)
        {
            var doctor = _context.doctores.Find(id);
            return doctor;
        }

        [HttpPost]
        public ActionResult Post(Doctor doctor)
        {
            _context.doctores.Add(doctor);
            _context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult <Doctor> Delete(int id)
        {
            var doctor = _context.doctores.Find(id);
            if(doctor == null)
            {
                return NotFound();
            }
            _context.doctores.Remove(doctor);
            _context.SaveChanges();
            return doctor;

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Doctor doctor)
        {
            if(id != doctor.DoctorId)
            {
                BadRequest();

            }
            _context.Entry(doctor).State = EntityState.Modified ;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet("especialidad/{especialidad}")]
        public List<Doctor> Get(string especialidad)
        {
            List<Doctor> espDoctor = (from e in _context.doctores where e.Especialidad == especialidad select e).ToList();
            return espDoctor;
        }










    }
}
