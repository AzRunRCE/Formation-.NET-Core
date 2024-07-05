using DemoTrip.Core.Interfaces;
using DemoTrip.Core.UseCases;
using DemoTrip.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoTrip.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly ISearchFlightUseCase searchFilghtUseCase;

        public FlightsController(ISearchFlightUseCase searchFilghtUseCase)
        {
            this.searchFilghtUseCase = searchFilghtUseCase;
        }

        // POST api/<FlightsController>
        [HttpPost("search")]
        public IActionResult Post([FromBody] SearchFlighRequestViewModel request)
        {


            if (ModelState.IsValid)
            {
                var response = searchFilghtUseCase.Execute(new SearchFlightRequestDto()
                {
                    DateFrom = request.DateFrom!.Value,
                    Destination = request.Destination!,
                    Origin = request.Origin!,
                });

                var responseVm = new SearchFlighResponseViewModel() { Flights = response.Flights };

                if (response.Succes)
                {
                    return Ok(responseVm);
                }
                return NotFound(responseVm);
            }
            return BadRequest();
     
        }

     
    }
}
