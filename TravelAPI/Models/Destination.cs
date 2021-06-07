using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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
        public string Review { get; set; }

    }
}