using tourism_system.Application.Abstraction;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.UserBooking
{
    public record UserBookingCommand(Guid userid,Guid locationid):ICommand<bool>;
    
    
}
