using Microsoft.AspNetCore.Mvc;
using TimeCapsule.Domain.Entities;
using TimeCapsule.Domain.Interfaces.JournalTypeInterfaces;

namespace TimeCapsule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalTypeController : ControllerBase
    {
        private readonly IJournalTypeService _service;

        public JournalTypeController(IJournalTypeService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(IJournalTypeService));
        }

        //GET: api/JournalType
        [HttpGet]
        public async Task<IReadOnlyList<JournalType>> GetJournalEntries()
        {
            return await _service.ListAllJournalEntries();
        }

        // GET: api/JournalType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JournalType>> GetJournalType(int id)
        {
            return await _service.GetJournalType(id);
        }

        // PUT: api/JournalType/5
        [HttpPut("{id}")]
        public async Task<ActionResult<JournalType>> PutJournalType(int id, JournalType JournalType)
        {
            return await _service.UpdateJournalType(JournalType);
        }

        // POST: api/JournalType
        [HttpPost]
        public async Task<ActionResult<JournalType>> PostJournalType(JournalType JournalType)
        {
            return await _service.AddJournalType(JournalType);
        }

        // DELETE: api/JournalType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JournalType>> DeleteJournalType(JournalType JournalType)
        {
            return await _service.DeleteJournalType(JournalType);
        }
    }
}