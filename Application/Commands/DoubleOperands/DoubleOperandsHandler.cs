using Application.Constants;
using Application.Interfaces;
using MediatR;

namespace Application.Commands.DoubleOperands
{
    public class DoubleOperandsHandler : IRequestHandler<DoubleOperandsCommand, float>
    {
        private readonly ICalculationService _calculationService;

        public DoubleOperandsHandler(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }
        public async Task<float> Handle(DoubleOperandsCommand request, CancellationToken cancellationToken)
        {
            return request.Operator switch
            {
                Operators.Addition => _calculationService.Add(request.FirstOperand, request.SecondOperand),
                Operators.Subtraction => _calculationService.Subtract(request.FirstOperand, request.SecondOperand),
                Operators.Multiplication => _calculationService.Multiply(request.FirstOperand, request.SecondOperand),
                Operators.Division => _calculationService.Divide(request.FirstOperand, request.SecondOperand),
                _ => throw new ArgumentException(Messages.IncorrectOperator),
            };
        }
    }
}
