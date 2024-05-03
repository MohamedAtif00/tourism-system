using Ardalis.Result;
using tourism_system.Application.Abstraction;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.UpdateImage
{
    public class UpdateImageCommandHandler : ICommandHandler<UpdateImageCommand, byte[]>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateImageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<byte[]>> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var location = await _unitOfWork.TourismLocation.GetById(TourismLocationId.Create(request.id));

                if (location == null) return Result.Error("this location is not exist");

                byte[] file;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    request.file.CopyTo(memoryStream);
                    file = memoryStream.ToArray();
                }

                location.UpdateImage(file);

                await _unitOfWork.TourismLocation.Update(location);

                int saving = await _unitOfWork.save();

                return Result.Success(file);
            }catch (Exception ex)
            {
                return Result.CriticalError("System Error");
            }
        }
    }
}
