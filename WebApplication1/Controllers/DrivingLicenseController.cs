using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrivingLicenseController : ControllerBase
    {
        private readonly DrivingLicenseService _service;

        public DrivingLicenseController(DrivingLicenseService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DrivingLicense>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("search")]
        public ActionResult<DrivingLicense> Search([FromQuery] string licenseNumber)
        {
            var license = _service.GetByLicenseNumber(licenseNumber);
            if (license == null) return NotFound();
            return Ok(license);
        }

        [HttpGet("{id}")]
        public ActionResult<DrivingLicense> Get(int id)
        {
            var license = _service.GetById(id);
            if (license == null) return NotFound();
            return Ok(license);
        }

        [HttpPost]
        public IActionResult Create([FromBody] DrivingLicense license)
        {
            _service.Add(license);
            return CreatedAtAction(nameof(Get), new { id = license.Id }, license);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] DrivingLicense license)
        {
            var existing = _service.GetById(id);
            if (existing == null) return NotFound();
            license.Id = id;
            _service.Update(license);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _service.GetById(id);
            if (existing == null) return NotFound();
            _service.Delete(id);
            return NoContent();
        }
    }
}
