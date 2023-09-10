using Application.Constants;
using Application.Interfaces;
using MediatR;

namespace Application.Commands.SingleOperand
{
    public class SingleOperandHandler : IRequestHandler<SingleOperandCommand, int>
    {
        private readonly ICalculationService _calculationService;

        public SingleOperandHandler(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }
        public async Task<int> Handle(SingleOperandCommand request, CancellationToken cancellationToken)
        {
            return request.Operator switch
            {
                Operators.Factorial => _calculationService.Factorial(request.Value),
                Operators.Fibonacci => _calculationService.GetFibonacciAt(request.Value),
                _ => throw new ArgumentException(Messages.IncorrectOperator),
            };
        }
    }
}
