

using DemoTrip.Core.Interfaces;

namespace DemoTrip.Core.UseCases
{
    public class SearchFlightUseCase : ISearchFlightUseCase
    {
        private readonly IFlightRepository flightRepository;

        public SearchFlightUseCase(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }


        public SearchFlightResponseDto Execute(SearchFlightRequestDto request)
        {

            var flights =  flightRepository.GetAll();

            var flyFounded =  flights.Where(fly => fly.Origin == request.Origin && fly.Destination == request.Destination && fly.DepartureTime >= request.DateFrom).ToList();

            return new SearchFlightResponseDto()
            {
                Flights = flyFounded,
                Succes = flyFounded.Any(),
            };
        }
    }
}
