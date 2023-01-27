using Microsoft.EntityFrameworkCore;
using MVCClinica.Models;

namespace MVCClinica.Data
{
    public class DBClinicaMVCContext : DbContext
    {
        public DBClinicaMVCContext(DbContextOptions<DBClinicaMVCContext> options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }

    }
}
