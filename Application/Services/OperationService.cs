using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Interfaces;

namespace Application.Services
{
    public class OperationService : IOperationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOperationRepository _operationRepository;
        private readonly IMapper _mapper;

        public OperationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _operationRepository = unitOfWork.OperationRepository;
            _mapper = mapper;
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

        public async Task<IList<OperationDto>> GetAllOperations()
        {
            var operations = await _operationRepository.GetAllList();
            return _mapper.Map<List<OperationDto>>(operations);
        }
    }
}
