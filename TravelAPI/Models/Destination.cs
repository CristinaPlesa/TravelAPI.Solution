using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }

        [Required]
        public string CountryName { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public DateTime TravelDate { get; set; }
        [Required]
        public string Review { get; set; }

    }
}