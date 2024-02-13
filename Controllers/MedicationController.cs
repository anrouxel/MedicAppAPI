using Asp.Versioning;
using MedicAppAPI.Models;
using MedicAppAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicAppAPI.Controllers
{
    [ApiVersion(1.0)]
    [ApiController]
    [Route("[controller]")]
    public class MedicationController
    {
        private readonly ILogger<MedicationController> _logger;

        private readonly MedicationService _medicationService;

        public MedicationController(ILogger<MedicationController> logger, MedicationService medicationService)
        {
            _logger = logger;
            _medicationService = medicationService;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult> Add(Medication medication)
        {
            await _medicationService.CreateAsync(medication);
            return new OkResult();
        }

        [Route("[action]")]
        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<ActionResult> AddAll(List<Medication> medications)
        {
            await _medicationService.CreateAsync(medications);
            return new OkResult();
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var medications = await _medicationService.GetAsync();
            return new OkObjectResult(medications);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetByCISCode(long CISCode)
        {
            var medication = await _medicationService.GetAsync(CISCode);
            return new OkObjectResult(medication);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult> UpdateDatabase(List<Medication> medications)
        {
            await _medicationService.ClearAsync();
            await _medicationService.CreateAsync(medications);
            return new OkResult();
        }
    }
}