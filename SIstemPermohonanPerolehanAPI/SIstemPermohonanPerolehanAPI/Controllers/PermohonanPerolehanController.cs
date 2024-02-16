using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIstemPermohonanPerolehanAPI.IRepository;
using SIstemPermohonanPerolehanAPI.Model;

namespace SIstemPermohonanPerolehanAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PermohonanPerolehanController : ControllerBase
    {
        private readonly IPermohonanPerolehanRepository _permohonanPerolehanRepository;

        public PermohonanPerolehanController(IPermohonanPerolehanRepository permohonanPerolehanRepository)
        {
            _permohonanPerolehanRepository = permohonanPerolehanRepository;
        }

        [HttpGet]
        public async Task<IActionResult> DaftarPermohonan([FromBody] PermohonanPerolehan permohonan)
        {
            var daftarPermohonan = await _permohonanPerolehanRepository.DaftarPermohonan(permohonan);
            return Ok(daftarPermohonan);
        }
    }
}
