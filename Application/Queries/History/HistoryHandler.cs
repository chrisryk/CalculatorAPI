using Application.Interfaces;
using Application.Models;
using FluentResults;
using MediatR;

namespace Application.Queries.History
{
    public class HistoryHandler : IRequestHandler<HistoryQuery, Result<IList<OperationDto>>>
    {
        private readonly IOperationService _operationService;

        public HistoryHandler(IOperationService operationService)
        {
            _operationService = operationService;
        }
        public async Task<Result<IList<OperationDto>>> Handle(HistoryQuery request, CancellationToken cancellationToken)
        {
            return (await _operationService.GetAllOperations()).ToResult();
        }
    }
}
