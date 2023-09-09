using MediatR;

namespace Application.Commands.Add
{
    public class AddCommand : IRequest<int>
    {
        public int FirstOperand { get; set; }
        public int SecondOperand { get; set; }
    }
}
