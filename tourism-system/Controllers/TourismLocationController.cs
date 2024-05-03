using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using tourism_system.Application.CQRS.TourismLocationFeatures.AddTourismLocation;
using tourism_system.Application.CQRS.TourismLocationFeatures.GetAllTourismLocation;
using tourism_system.Application.CQRS.TourismLocationFeatures.GetSingleTourismLocation;
using tourism_system.Application.CQRS.TourismLocationFeatures.UpdateImage;
using tourism_system.Application.CQRS.TourismLocationFeatures.UserBooking;
using tourism_system.Application.DTO.TourismLocation;
using tourism_system.Application.DTO.TourismLocation.request;
using tourism_system.Application.DTO.TourismLocation.response;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tourism_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourismLocationController : ControllerBase
    {
        private readonly  IMediator _mediator;
        private readonly IMapper _mapper;

        public TourismLocationController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: api/<TourismLocationController>
        [HttpGet("GetAll/{tourismType}")]
        public async Task<IActionResult> Get(TourismType tourismType)
        {
            var result = await _mediator.Send(new GetAllTourismLocationQuery(tourismType));

            List<GetAllTourismLocatationResponse> response = new();

            foreach (var item in result.Value)
            {
                var data = Convert.ToBase64String(item.image);
                var a =  _mapper.Map<budget,BudgetDto>(item.A);
                var b =  _mapper.Map<budget,BudgetDto>(item.B);
                var c =  _mapper.Map<budget,BudgetDto>(item.C);
                response.Add(new GetAllTourismLocatationResponse(item.Id.value.ToString(),item.Name,item.Description,item.TourismType,item.Latitude,item.Longitude, _mapper.Map<Location, LocationDto>(item.NearestHotel), _mapper.Map<Location,LocationDto>(item.NearestRestourant),_mapper.Map<Location,LocationDto>(item.NearestMall),_mapper.Map<Location,LocationDto>(item.NearestHospital),_mapper.Map<Location, LocationDto>(item.NearestPharmacy),data,a,b,c));
            }

            return Ok(Result.Success(response));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllTourismLocationWithoutQuery());

            List<GetAllTourismLocatationResponse> response = new();

            foreach (var item in result.Value)
            {
                var data = Convert.ToBase64String(item.image);
                var a = _mapper.Map<budget, BudgetDto>(item.A);
                var b = _mapper.Map<budget, BudgetDto>(item.B);
                var c = _mapper.Map<budget, BudgetDto>(item.C);
                response.Add(new GetAllTourismLocatationResponse(item.Id.value.ToString(), item.Name, item.Description, item.TourismType, item.Latitude, item.Longitude,_mapper.Map<Location,LocationDto>(item.NearestHotel), _mapper.Map<Location, LocationDto>(item.NearestRestourant), _mapper.Map<Location, LocationDto>(item.NearestMall), _mapper.Map<Location, LocationDto>(item.NearestHospital), _mapper.Map<Location, LocationDto>(item.NearestPharmacy), data, a, b, c));
            }

            return Ok(Result.Success(response));
        }


        // GET api/<TourismLocationController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetSingleTourismLocationQuery(id));

            return Ok(result);
        }

        // POST api/<TourismLocationController>
        [HttpPost("CreateTourismLocation")]
        public async Task<IActionResult> Post([FromForm] CreateTourismLocationRequest requst)
        {
            var result = await _mediator.Send(new CreateTourismLocationCommand(requst.Name,requst.Description,requst.TourismType,requst.Latitude,requst.Longitude,requst.nearestHotel,requst.NearestRestourant,requst.NearestMall,requst.NearestHospital,requst.NearestPharmacy,requst.image,requst.a,requst.b,requst.c));
            return Ok(result);
        }

        // POST api/<TourismLocationController>
        [HttpPost("UpdateImage")]
        public async Task<IActionResult> Post([FromForm]Guid locationId ,IFormFile requst)
        {
            var result = await _mediator.Send(new UpdateImageCommand(locationId,requst));
            return Ok(result);
        }

        // PUT api/<TourismLocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TourismLocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("Book")]
        public async Task<IActionResult> post([FromBody] UserBookingCommand request) 
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }
    }
}
