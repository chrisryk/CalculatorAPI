using Application.Interfaces;
using Core.Entities;
using Infrastructure.Interfaces;

namespace Application.Services
{
    public class OperationService : IOperationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOperationRepository _operationRepository;

        public OperationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _operationRepository = unitOfWork.OperationRepository;
        }

        public async Task CreateOperationAsync(float firstValue, string calculationOperator, float result, float? secondValue = null)
        {
            var operation = new Operation
            {
                FirstValue = firstValue,
                SecondValue = secondValue,
                Operator = calculationOperator,
                Result = result,
                CreatedAt = DateTime.Now,
            };

            await _operationRepository.CreateAsync(operation);
            await _unitOfWork.CompleteAsync();
        }
    }
}
