using Ardalis.Result;
using tourism_system.Application.Abstraction;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.GetAllTourismLocation
{
    public class GetAllTourismLocationWithoutQueryHandler : IQueryHandler<GetAllTourismLocationWithoutQuery, List<TourismLocation>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllTourismLocationWithoutQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<TourismLocation>>> Handle(GetAllTourismLocationWithoutQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var locations = await _unitOfWork.TourismLocation.GetAllwithout();


                if (locations == null) return Result.Error();

                return Result.Success(locations);
            }
            catch (Exception ex)
            {
                return Result.CriticalError("System Error");
            }
        }
    }
}
