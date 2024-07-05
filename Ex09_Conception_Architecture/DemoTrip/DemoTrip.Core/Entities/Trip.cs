namespace DemoTrip.Core.Entities
{
    public class Trip
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Flight> Flights { get; set; }

    }
}
