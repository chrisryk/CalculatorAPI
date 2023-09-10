using MediatR;

namespace Application.Commands.SingleOperand
{
    public class SingleOperandCommand : IRequest<int>
    {
        public int Value { get; set; }
        public string Operator { get; set; }
    }
}
