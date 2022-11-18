using Microsoft.EntityFrameworkCore;
using WebApiFinalEngelstajnSebastian.Model;

namespace WebApiFinalEngelstajnSebastian.Data
{
    public class DBHospitalAPIContext : DbContext
    {
        public DBHospitalAPIContext(DbContextOptions<DBHospitalAPIContext> options) : base(options) { }

        public DbSet<Doctor> doctores { get; set; }
        public DbSet<Hospital> hospitales { get; set; }
    }
}
