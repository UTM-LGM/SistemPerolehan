using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIstemPermohonanPerolehanAPI.Model
{
    public class PermohonanPerolehan
    {
        [Key]
        public int Id { get; set; }
        public string Tajuk { get; set; }
        public string KetuaProjek { get; set; }
        public string Nilai { get; set; }
        public DateTime TarikhPermohonan { get; set; }
        public DateTime TarikhMulaProjek { get; set; }
        public string StatusPermohonan { get;set ; }
        public string VerifyBy { get; set; }
        public DateTime VerifyDate { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime AuthorizeDate { get; set;}
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("VotId")]
        public int VotId { get; set; }
        public Vot Vot { get; set; }

        [ForeignKey("JenisPerolehanId")]
        public int JenisPerolehanId { get; set; }
        public JenisPerolehan JenisPerolehan { get; set; }
    }
}
