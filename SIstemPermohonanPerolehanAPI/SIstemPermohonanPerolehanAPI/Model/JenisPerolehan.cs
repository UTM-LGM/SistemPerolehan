using System.ComponentModel.DataAnnotations;

namespace SIstemPermohonanPerolehanAPI.Model
{
    public class JenisPerolehan
    {
        [Key]
        public int Id { get; set; }
        public string Jenis { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
