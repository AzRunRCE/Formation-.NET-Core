using DemoTrip.Core.Entities;
using DemoTrip.Core.Interfaces;

namespace DemoTrip.UnitTests
{
    internal class FakeFlightRepository : IFlightRepository
    {
        private readonly List<Flight> flights;

        public FakeFlightRepository(List<Flight> flights)
        {
            this.flights = flights;
        }

        public List<Flight> GetAll()
        {
            return flights;
        }
    }
}