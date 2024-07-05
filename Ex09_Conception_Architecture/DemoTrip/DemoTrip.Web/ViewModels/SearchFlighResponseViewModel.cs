using DemoTrip.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoTrip.Web.ViewModels
{

    public class SearchFlighResponseViewModel
    {

        public List<Flight> Flights { get; set; } = new();
    }
}
