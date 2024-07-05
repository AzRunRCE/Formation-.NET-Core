using DemoTrip.Core.Entities;

namespace DemoTrip.Core.UseCases
{
    public class SearchFlightResponseDto
    {

        public bool Succes { get; set; }

        public List<Flight> Flights { get; set; } = new();
    }
}