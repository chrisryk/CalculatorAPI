using Application.Constants;
using Application.Interfaces;
using MediatR;

namespace Application.Commands.SingleOperand
{
    public class SingleOperandHandler : IRequestHandler<SingleOperandCommand, long>
    {
        private readonly ICalculationService _calculationService;
        private readonly IOperationService _operationService;

        public SingleOperandHandler(ICalculationService calculationService, IOperationService operationService)
        {
            _calculationService = calculationService;
            _operationService = operationService;
        }
        public async Task<long> Handle(SingleOperandCommand request, CancellationToken cancellationToken)
        {
            var result = request.Operator switch
            {
                Operators.Factorial => _calculationService.Factorial(request.Value),
                Operators.Fibonacci => _calculationService.GetFibonacciAt(request.Value),
                _ => throw new ArgumentException(Messages.IncorrectOperator),
            };

            await _operationService.CreateOperationAsync(request.Value, request.Operator, result);

            return result;
        }
    }
}
