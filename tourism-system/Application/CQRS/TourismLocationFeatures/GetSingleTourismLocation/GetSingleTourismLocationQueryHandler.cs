using Ardalis.Result;
using tourism_system.Application.Abstraction;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.GetSingleTourismLocation
{
    public class GetSingleTourismLocationQueryHandler : IQueryHandler<GetSingleTourismLocationQuery, TourismLocation>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetSingleTourismLocationQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<TourismLocation>> Handle(GetSingleTourismLocationQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var location = await _unitOfWork.TourismLocation.GetById(TourismLocationId.Create(request.id));

                if (location == null) return Result.Error("this location is not exist");

                return Result.Success(location);

            }catch (Exception ex)
            {
                return Result.CriticalError("System Error");
            }
        }
    }
}
