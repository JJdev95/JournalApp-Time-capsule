using TimeCapsule.Domain.Entities;

namespace TimeCapsule.Domain.Interfaces.BaseInterfaces
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}