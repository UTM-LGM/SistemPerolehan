using SIstemPermohonanPerolehanAPI.Data;
using SIstemPermohonanPerolehanAPI.IRepository;
using SIstemPermohonanPerolehanAPI.Model;

namespace SIstemPermohonanPerolehanAPI.Repository
{
    public class PermohonanPerolehanRepository:IPermohonanPerolehanRepository
    {
        private readonly ApplicationDbContext _context;

        public PermohonanPerolehanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PermohonanPerolehan> DaftarPermohonan (PermohonanPerolehan permohonan)
        {
            permohonan.CreatedDate = DateTime.Now;
            await _context.PermohonanPerolehan.AddAsync(permohonan);
            await _context.SaveChangesAsync();
            return permohonan;
        }
    }
}
