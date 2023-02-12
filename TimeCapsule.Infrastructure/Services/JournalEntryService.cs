using TimeCapsule.Domain.Entities;
using TimeCapsule.Domain.Interfaces.JournalEntriesInterfaces;

namespace TimeCapsule.Infrastructure.Services
{
    public class JournalEntryService : IJournalEntryService
    {
        private readonly IJournalEntryRepository _repository;
        public JournalEntryService(IJournalEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task<JournalEntry> AddJournalEntry(JournalEntry entry)
        {
            return await _repository.Add(entry);
        }

        public async Task<JournalEntry> DeleteJournalEntry(JournalEntry entry)
        {
            return await _repository.Delete(entry);
        }

        public async Task<JournalEntry> GetJournalEntry(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<JournalEntry>> ListAllJournalEntries()
        {
            return await _repository.ListAllAsync();
        }

        public async Task<JournalEntry> UpdateJournalEntry(JournalEntry entry)
        {
            return await _repository.Update(entry);
        }
    }
}