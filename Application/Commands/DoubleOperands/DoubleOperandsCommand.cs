using MediatR;

namespace Application.Commands.DoubleOperands
{
    public class DoubleOperandsCommand : IRequest<decimal>
    {
        public decimal FirstOperand { get; set; }
        public decimal SecondOperand { get; set; }
        public string Operator { get; set; }
    }
}
