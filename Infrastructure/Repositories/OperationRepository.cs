using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IList<Operation>> GetAllList()
        {
            return await _context.Operations.ToListAsync();
        }
    }
}
