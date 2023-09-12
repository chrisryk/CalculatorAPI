using MediatR;

namespace Application.Commands.SingleOperand
{
    public class SingleOperandCommand : IRequest<long>
    {
        public long Value { get; set; }
        public string Operator { get; set; }
    }
}
