namespace DemoTrip.Core.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public string OriginName { get; set; }
        public string DestinationName { get; set; }
    }
}