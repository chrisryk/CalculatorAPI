using Core.Interfaces;

namespace Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IOperationRepository OperationRepository { get; }
        Task<int> CompleteAsync();
    }
}
