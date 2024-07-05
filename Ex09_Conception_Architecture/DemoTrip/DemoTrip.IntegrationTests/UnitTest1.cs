using DemoTrip.Infrastructure;

namespace DemoTrip.IntegrationTests
{
    [TestClass]
    public class CSVFligthRepository_Tests
    {
        [TestMethod]
        public void ReadCSV_Should_Return_Flight()
        {

            var repo = new CSVFligthRepository("flights_with_names.csv");

            var flights = repo.GetAll();

            Assert.IsTrue(flights.Count > 0);
        }
    }
}