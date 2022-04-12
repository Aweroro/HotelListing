using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country > Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Great Britain",
                    ShortName = "GB"
                },
                new Country
                {
                    Id = 2,
                    Name = "United Arab Emirates",
                    ShortName = "UAE"
                },
                new Country
                {
                    Id = 3,
                    Name = "Bahamas",
                    ShortName = "BS"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "The Resident Covent Garden",
                    Address = "London",
                    CountryId = 1,
                    Rating = 4.8
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Grand Mid-West",
                     Address = "Dubai",
                     CountryId = 3,
                     Rating = 4.7
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Comfort Suites",
                      Address = "George Town",
                      CountryId = 2,
                      Rating = 4.1
                  }
                );
        }
    }
}
