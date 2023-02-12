using TimeCapsule.Domain.Entities;

namespace TimeCapsule.Domain.Interfaces.JournalEntriesInterfaces
{
    public interface IJournalEntryService
    {
        Task<JournalEntry> GetJournalEntry(int id);
        Task<IReadOnlyList<JournalEntry>> ListAllJournalEntries();
        Task<JournalEntry> AddJournalEntry(JournalEntry entity);
        Task<JournalEntry> UpdateJournalEntry(JournalEntry entity);
        Task<JournalEntry> DeleteJournalEntry(JournalEntry entity);
    }
}