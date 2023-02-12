using Microsoft.AspNetCore.Mvc;
using TimeCapsule.Domain.Entities;
using TimeCapsule.Domain.Interfaces.JournalEntriesInterfaces;

namespace TimeCapsule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController : ControllerBase
    {
        private readonly IJournalEntryService _service;

        public JournalEntryController(IJournalEntryService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(IJournalEntryService));
        }

        //GET: api/JournalEntry
        [HttpGet]
        public async Task<IReadOnlyList<JournalEntry>> GetJournalEntries()
        {
            return await _service.ListAllJournalEntries();
        }

        // GET: api/JournalEntry/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JournalEntry>> GetJournalEntry(int id)
        {
            return await _service.GetJournalEntry(id);
        }

        // PUT: api/JournalEntry/5
        [HttpPut("{id}")]
        public async Task<ActionResult<JournalEntry>> PutJournalEntry(int id, JournalEntry journalEntry)
        {
            return await _service.UpdateJournalEntry(journalEntry);
        }

        // POST: api/JournalEntry
        [HttpPost]
        public async Task<ActionResult<JournalEntry>> PostJournalEntry(JournalEntry journalEntry)
        {
            return await _service.AddJournalEntry(journalEntry);
        }

        // DELETE: api/JournalEntry/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JournalEntry>> DeleteJournalEntry(JournalEntry journalEntry)
        {
             return await _service.DeleteJournalEntry(journalEntry);
        }

    }
}