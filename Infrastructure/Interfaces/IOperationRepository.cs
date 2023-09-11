using Core.Entities;

namespace Infrastructure.Interfaces
{
    public interface IOperationRepository
    {
        Task AddAsync(Operation operation);
    }
}
