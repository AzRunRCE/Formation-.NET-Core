using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoTrip.Web.ViewModels
{
  
    public class SearchFlighRequestViewModel
    {
        [Required]
        public string? Origin { get; set; }

        [Required]
        public string? Destination { get; set; }

        [Required]
        public DateTime? DateFrom { get; set; }
    }
}
