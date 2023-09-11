using Core.Entities;

namespace Core.Interfaces
{
    public interface IOperationRepository
    {
        Task CreateAsync(Operation operation);
        Task<IList<Operation>> GetAllList();
    }
}
