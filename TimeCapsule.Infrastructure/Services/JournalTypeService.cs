using TimeCapsule.Domain.Entities;
using TimeCapsule.Domain.Interfaces.JournalTypeInterfaces;

namespace TimeCapsule.Infrastructure.Services
{
    public class JournalTypeService : IJournalTypeService
    {
        private readonly IJournalTypeRepository _repository;
        public JournalTypeService(IJournalTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<JournalType> AddJournalType(JournalType type)
        {
            return await _repository.Add(type);
        }

        public async Task<JournalType> DeleteJournalType(JournalType type)
        {
            return await _repository.Delete(type);
        }

        public async Task<JournalType> GetJournalType(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<JournalType>> ListAllJournalEntries()
        {
            return await _repository.ListAllAsync();
        }

        public async Task<JournalType> UpdateJournalType(JournalType type)
        {
            return await _repository.Update(type);
        }
    }
}