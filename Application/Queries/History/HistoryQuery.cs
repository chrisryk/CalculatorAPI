using Application.Models;
using FluentResults;
using MediatR;

namespace Application.Queries.History
{
    public class HistoryQuery : IRequest<Result<IList<OperationDto>>>
    {
    }
}
