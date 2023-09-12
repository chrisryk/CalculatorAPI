using Application.Models;
using Core.Entities;

namespace Application.Interfaces
{
    public interface IOperationService
    {
        Task CreateOperationAsync(decimal firstValue, string calculationOperator, decimal result, decimal? secondValue = null);
        Task<IList<OperationDto>> GetAllOperations();
    }
}
