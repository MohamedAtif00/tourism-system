using Ardalis.Result;
using AutoMapper;
using tourism_system.Application.Abstraction;
using tourism_system.Application.DTO.TourismLocation;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.AddTourismLocation
{
    public class CreateTourismLocationCommandHandler : ICommandHandler<CreateTourismLocationCommand, TourismLocation>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateTourismLocationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<TourismLocation>> Handle(CreateTourismLocationCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var nearistRestourant =  _mapper.Map<LocationDto, Location>(request.nearestRestourant);
                var nearistMall =  _mapper.Map<LocationDto, Location>(request.nearestMall);
                var nearistHospital =  _mapper.Map<LocationDto, Location>(request.nearestHospital);
                var nearistPharmacy =  _mapper.Map<LocationDto, Location>(request.nearestPharmacy);
                var nearistHotel = _mapper.Map < LocationDto,Location>(request.nearestHotel);
                var a = _mapper.Map<BudgetDto, budget>(request.a);
                var b = _mapper.Map<BudgetDto, budget>(request.b);
                var c = _mapper.Map<BudgetDto, budget>(request.c);

                    byte[] file;
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        request.file.CopyTo(memoryStream);
                        file = memoryStream.ToArray();
                    }

                var tourismLocation = await _unitOfWork.TourismLocation.Add(TourismLocation.Create(request.name,request.description,request.tourismType,request.latitude,request.longitude,file,nearistHotel,nearistRestourant,nearistMall,nearistHospital,nearistPharmacy,a,b,c));

                await _unitOfWork.TourismLocation.Add(tourismLocation);

                int saving = await _unitOfWork.save();

                if (saving == 0) return Result.Error("No changes has been made");

                return Result.Success(tourismLocation);
            }catch (Exception ex) { 
                return Result.Error(ex.ToString());
            }
        }
    }
}
