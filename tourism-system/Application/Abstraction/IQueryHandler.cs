using Ardalis.Result;
using MediatR;

namespace tourism_system.Application.Abstraction
{
    public interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery, Result<TResult>>
        where TQuery : IQuery<TResult>
        where TResult : notnull
    {
    }
}
