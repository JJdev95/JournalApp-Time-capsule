
using TimeCapsule.Domain.Entities;

namespace TimeCapsule.Domain.Interfaces.JournalTypeInterfaces
{
    public interface IJournalTypeService 
    {
        Task<JournalType> GetJournalType(int id);
        Task<IReadOnlyList<JournalType>> ListAllJournalEntries();
        Task<JournalType> AddJournalType(JournalType entity);
        Task<JournalType> UpdateJournalType(JournalType entity);
        Task<JournalType> DeleteJournalType(JournalType entity);
    }
}