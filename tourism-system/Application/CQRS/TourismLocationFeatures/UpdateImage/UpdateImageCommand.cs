using tourism_system.Application.Abstraction;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.UpdateImage
{
    public record UpdateImageCommand(Guid id,IFormFile file) : ICommand<byte[]>;
     
    
}
