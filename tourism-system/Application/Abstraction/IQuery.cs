using Ardalis.Result;
using MediatR;

namespace tourism_system.Application.Abstraction
{
    public interface IQuery<T> : IRequest<Result<T>>
    {
    }
}
