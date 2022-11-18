using Microsoft.EntityFrameworkCore;
using WebApiFinalPalazzoFlorencia.Models;

namespace WebApiFinalPalazzoFlorencia.Data
{
    public class DBHospitalContext :DbContext
    {
        public DBHospitalContext(DbContextOptions<DBHospitalContext>options):base(options){}

        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
