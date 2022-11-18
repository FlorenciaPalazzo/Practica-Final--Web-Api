using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using WebApiFinalPalazzoFlorencia.Data;
using WebApiFinalPalazzoFlorencia.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApiFinalPalazzoFlorencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly DBHospitalContext _context;
        public MedicoController(DBHospitalContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            List<Doctor> doctores = (from d in _context.Doctores select d).ToList();
            return doctores;
        }

        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            Doctor doctor = (from d in _context.Doctores where id == d.DoctorId select d).SingleOrDefault();
            return doctor;
        }

        [HttpPost]
        public Doctor Post( Doctor doctor)
        {
            _context.Doctores.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }

        [HttpDelete("{id}")]
        public Doctor Delete(int id)
        {
            Doctor doctorDelete = _context.Doctores.Find(id);
            if (doctorDelete == null)
            {
                NotFound();
            }
            _context.Remove(doctorDelete);
            _context.SaveChanges();
            return doctorDelete;
        }

        //Segunda Parte

        [HttpPut("{id}")]
        public ActionResult Put(int id, Doctor doctor)
        {
            if (id == doctor.DoctorId)
            {
                NotFound();
            }
            _context.Entry(doctor).State= EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet("especialidad/{especialidad}")]
        public List<Doctor> Get(string especialidad)
        {
            List<Doctor> espDoctor = (from e in _context.Doctores where e.Especialidad == especialidad select e).ToList();
            return espDoctor;
        }

        

    }
}
