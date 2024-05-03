using Ardalis.Result;
using MediatR;

namespace tourism_system.Application.Abstraction
{
    public interface ICommand<T> : IRequest<Result<T>>
    {
    }

    public interface ICommand : IRequest<Result>
    { }
}
