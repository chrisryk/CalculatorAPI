using Application.Constants;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.DoubleOperands
{
    public class DoubleOperandsHandler : IRequestHandler<DoubleOperandsCommand, float>
    {
        private readonly ICalculationService _calculationService;
        private readonly IOperationService _operationService;

        public DoubleOperandsHandler(ICalculationService calculationService, IOperationService operationService)
        {
            _calculationService = calculationService;
            _operationService = operationService;
        }
        public async Task<float> Handle(DoubleOperandsCommand request, CancellationToken cancellationToken)
        {
            var result = request.Operator switch
            {
                Operators.Addition => _calculationService.Add(request.FirstOperand, request.SecondOperand),
                Operators.Subtraction => _calculationService.Subtract(request.FirstOperand, request.SecondOperand),
                Operators.Multiplication => _calculationService.Multiply(request.FirstOperand, request.SecondOperand),
                Operators.Division => _calculationService.Divide(request.FirstOperand, request.SecondOperand),
                _ => throw new ArgumentException(Messages.IncorrectOperator),
            };

            await _operationService.CreateOperationAsync(
                request.FirstOperand, request.Operator, result, request.SecondOperand);

            return result;
        }
    }
}
