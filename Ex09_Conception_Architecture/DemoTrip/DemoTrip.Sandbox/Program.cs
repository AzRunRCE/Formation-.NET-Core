using DemoTrip.Core.Entities;
using System.Globalization;

public class Program
{
    private static readonly List<string> Destinations = new List<string> { "NYC", "LAX", "SFO",
        //"ORD", "ATL", "MIA", "DFW", "DEN", "SEA", "BOS", "LHR", 
        "CDG",
      /*  "AMS", "FRA", "HND", "DXB", "SYD"*/ };

    private static readonly Dictionary<string, string> DestinationNames = new Dictionary<string, string>
    {
        { "NYC", "New York City" },
        { "LAX", "Los Angeles" },
        { "SFO", "San Francisco" },
        //{ "ORD", "Chicago O'Hare" },
        //{ "ATL", "Atlanta" },
        //{ "MIA", "Miami" },
        //{ "DFW", "Dallas/Fort Worth" },
        //{ "DEN", "Denver" },
        //{ "SEA", "Seattle" },
        //{ "BOS", "Boston" },
        //{ "LHR", "London Heathrow" },
        { "CDG", "Paris Charles de Gaulle" },
        //{ "AMS", "Amsterdam" },
        //{ "FRA", "Frankfurt" },
        //{ "HND", "Tokyo Haneda" },
        //{ "DXB", "Dubai" },
        //{ "SYD", "Sydney" }
    };

    public static void Main()
    {
        CreateFilght();
        CreateHotels();
    }




    public static void CreateFilght()
    {
        var flights = new List<Flight>();

        var random = new Random();
        for (int i = 1; i <= 100; i++)
        {
            var origin = Destinations[random.Next(Destinations.Count)];
            var destination = Destinations.Except(new List<string> { origin }).ElementAt(random.Next(Destinations.Count - 1));
            var departureTime = DateTime.Now.AddDays(random.Next(1, 365));
            var arrivalTime = departureTime.AddHours(random.Next(2, 15));
            var price = Math.Round(random.NextDouble() * (1500 - 200) + 200, 2);

            flights.Add(new Flight
            {
                Id = i,
                Origin = origin,
                Destination = destination,
                DestinationName = DestinationNames[destination],
                OriginName = DestinationNames[origin],

                DepartureTime = departureTime,
                ArrivalTime = arrivalTime,
                Price = Convert.ToDecimal(price)
            });
        }

        var csvFilePath = "flights_with_names.csv";
        using (var writer = new StreamWriter(csvFilePath))
        {
            writer.WriteLine("Id,Origin,Destination,OriginName,DestinationName,DepartureTime,ArrivalTime,Price");
            foreach (var flight in flights)
            {
                writer.WriteLine($"{flight.Id};{flight.Origin};{flight.Destination};{flight.OriginName};{flight.DestinationName};{flight.DepartureTime:yyyy-MM-ddTHH:mm:ss};{flight.ArrivalTime:yyyy-MM-ddTHH:mm:ss};{flight.Price}");
            }
        }

        Console.WriteLine($"Flights have been generated and saved to {csvFilePath}");
    }


    public static void CreateHotels()
    {
        // List of hotel locations to include in the CSV
        var locations = new List<string> { "NYC", "LAX", "SFO", "CDG" };

        // Generate a list of hotels
        var hotels = new List<Hotel>();
        var random = new Random();

        for (int i = 1; i <= 20; i++)
        {
            string location = locations[random.Next(locations.Count)];
            DateTime checkInDate = DateTime.Now.AddDays(random.Next(1, 365));
            DateTime checkOutDate = checkInDate.AddDays(random.Next(1, 14));

            hotels.Add(new Hotel
            {
                Id = i,
                Name = $"Hotel {i}",
                Location = location,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                PricePerNight = (float)Math.Round(random.NextDouble() * (500 - 50) + 50, 2)
            });
        }

        // Generate the CSV content
        var csvFilePath = "hotels.csv";
        using (var writer = new StreamWriter(csvFilePath))
        {
            writer.WriteLine("Id,Name,Location,CheckInDate,CheckOutDate,PricePerNight");

            foreach (var hotel in hotels)
            {
                writer.WriteLine($"{hotel.Id};{hotel.Name};{hotel.Location};{hotel.CheckInDate.ToString("yyyy-MM-dd")};{hotel.CheckOutDate.ToString("yyyy-MM-dd")};{hotel.PricePerNight.ToString(CultureInfo.InvariantCulture)}");
            }
        }

        Console.WriteLine($"Hotels CSV has been generated and saved to {csvFilePath}");
    }
}
