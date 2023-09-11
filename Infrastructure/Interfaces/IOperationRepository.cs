using Core.Entities;

namespace Infrastructure.Interfaces
{
    public interface IOperationRepository
    {
        Task CreateAsync(Operation operation);
    }
}
