using Core.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    internal class OperationRepository : IOperationRepository
    {
        private readonly AppDbContext _context;

        public OperationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Operation operation)
        {
            await _context.Operations.AddAsync(operation);
        }
    }
}
