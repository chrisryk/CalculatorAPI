using Core.Interfaces;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IOperationRepository OperationRepository { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            OperationRepository = new OperationRepository(context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
