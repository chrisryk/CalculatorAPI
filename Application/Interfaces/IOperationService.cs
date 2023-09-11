using Core.Entities;

namespace Application.Interfaces
{
    public interface IOperationService
    {
        Task CreateOperationAsync(float firstValue, string calculationOperator, float result, float? secondValue = null);
    }
}
