using Ardalis.Result;
using tourism_system.Application.Abstraction;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Entity.UserTourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.UserBooking
{
    public class UserBookingCommandHandler : ICommandHandler<UserBookingCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserBookingCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<bool>> Handle(UserBookingCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var adding = await _unitOfWork.UserLocationRepository.Add(UserTourismLocation.Create(request.userid,TourismLocationId.Create(request.locationid)));

                int result = await _unitOfWork.save();

                if (result == 0) return Result.Error("no changes");

                return Result.Success(true);
            }catch (Exception ex)
            {
                return Result.CriticalError("System Error");
            }
        }
    }
}
