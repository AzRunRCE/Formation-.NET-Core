using DemoTrip.Core.Entities;

namespace DemoTrip.Core.Interfaces
{
    public interface IFlightRepository
    {
        List<Flight> GetAll();
    }
}