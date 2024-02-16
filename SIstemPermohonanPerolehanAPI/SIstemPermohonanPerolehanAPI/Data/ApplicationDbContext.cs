using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIstemPermohonanPerolehanAPI.Model;

namespace SIstemPermohonanPerolehanAPI.Data
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<JenisPerolehan> JenisPerolehan { get; set; }
        public DbSet<Vot> Vot { get; set; }
        public DbSet<PermohonanPerolehan> PermohonanPerolehan { get; set; }
    }
}
