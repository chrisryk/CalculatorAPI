using Application.Interfaces;
using MediatR;

namespace Application.Commands.Add
{
    public class AddHandler : IRequestHandler<AddCommand, int>
    {
        private readonly ICalcualtionService _calcualtionService;

        public AddHandler(ICalcualtionService calcualtionService)
        {
            _calcualtionService = calcualtionService;
        }
        public async Task<int> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            return _calcualtionService.Add(request.FirstOperand, request.SecondOperand);
        }
    }
}
