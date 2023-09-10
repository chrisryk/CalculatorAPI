using MediatR;

namespace Application.Commands.DoubleOperands
{
    public class DoubleOperandsCommand : IRequest<float>
    {
        public float FirstOperand { get; set; }
        public float SecondOperand { get; set; }
        public string Operator { get; set; }
    }
}
