using System.Collections.Generic;
using System.Threading.Tasks;
using TimeCapsule.Domain.Entities;

namespace TimeCapsule.Domain.Interfaces
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}