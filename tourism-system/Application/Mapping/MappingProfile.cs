using AutoMapper;
using tourism_system.Application.DTO.TourismLocation;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<budget, BudgetDto>().ReverseMap();
        }
    }
}
