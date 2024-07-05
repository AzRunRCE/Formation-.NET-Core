namespace DemoTrip.Core.UseCases
{
    public class SearchFlightRequestDto
    {
        public SearchFlightRequestDto()
        {
        }

        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DateFrom { get; set; }
    }
}