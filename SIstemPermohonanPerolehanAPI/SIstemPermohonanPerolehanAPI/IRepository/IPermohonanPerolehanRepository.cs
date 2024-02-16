using SIstemPermohonanPerolehanAPI.Model;

namespace SIstemPermohonanPerolehanAPI.IRepository
{
    public interface IPermohonanPerolehanRepository
    {
        Task<PermohonanPerolehan> DaftarPermohonan(PermohonanPerolehan permohonan); 
    }
}
