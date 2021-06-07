using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
  public class TravelAPIContext : DbContext
  {
    public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
        : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuiler builder)
    {
      builder.Entity<Destination>()
        .HasData(
          new Destination { DestinationId = 1, CountryName = "Canada", CityName = "Vancouver", TravelDate = 2008, 3, 1, 7, 0, 0, Review = "I love this destination. There was lots of fun things to do. The landmarks alone are worth the travel!" },
          new Destination { DestinationId = 2, CountryName = "Mexico", CityName = "Mexico City", TravelDate = 2018, 6, 10, 13, 0, 0, Review = "Everything was so colorful and the mural art was amazing. Definitely worth the travel to see some of the Aztec ancient sites!" },
          new Destination { DestinationId = 3, CountryName = "Italy", CityName = "Venezuela", TravelDate = 2015, 8, 18, 15, 0, 0, Review = "The food is amazing and the ancient buildings and churches are beautiful! There is also lots of art and sculptures to be seen. Make sure you bring a few pairs of walking shoes!" },
          new Destination { DestinationId = 4, CountryName = "Thailand", CityName = "Song Khon", TravelDate = 2017, 7, 2, 7, 0, 0, Review = "The weather was nice and warm. The food not only was cheap but also really tasty. Its worth spending money on a good hotel!" },
          new Destination { DestinationId = 5, CountryName = "New Zeland", CityName = "Auckland", TravelDate = 2014, 5, 23, 10, 0, 0, Review = "You have to visit for yourself. The food was really good in general. The valleys were breathtaking..." }
        );
    }
  }
}















