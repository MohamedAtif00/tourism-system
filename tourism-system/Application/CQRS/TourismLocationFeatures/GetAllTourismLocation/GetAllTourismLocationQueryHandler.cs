using Ardalis.Result;
using tourism_system.Application.Abstraction;
using tourism_system.Application.DTO.TourismLocation.response;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.GetAllTourismLocation
{
    public class GetAllTourismLocationQueryHandler : IQueryHandler<GetAllTourismLocationQuery, List<TourismLocation>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllTourismLocationQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<TourismLocation>>> Handle(GetAllTourismLocationQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var locations = await _unitOfWork.TourismLocation.GetAll(request.TourismType);
       

                if (locations == null) return Result.Error();

                return Result.Success(locations);
            }catch  (Exception ex)
            {
                return Result.CriticalError("System Error");
            }
        }
    }

    
}
