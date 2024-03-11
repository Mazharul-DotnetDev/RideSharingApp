using BlazorAppServer.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppServer.DataContext
{
    public class RideShareDb : DbContext
    {
        public RideShareDb(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Ride> Rides { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RideSharingDb;Trusted_Connection=True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User { UserId = 1, Username = "JohnDoe", Phone = "123-456-7890" },
            new User { UserId = 2, Username = "JaneSmith", Phone = "987-654-3210" },
            new User { UserId = 3, Username = "AliceWonder", Phone = "555-555-5555" },
            new User { UserId = 4, Username = "BobBuilder", Phone = "999-999-9999" },
            new User { UserId = 5, Username = "EveHacker", Phone = "666-666-6666" },
            new User { UserId = 6, Username = "JohnDoe", Phone = "123-456-7890" },
            new User { UserId = 7, Username = "JaneSmith", Phone = "987-654-3210" },
            new User { UserId = 8, Username = "AliceWonder", Phone = "555-555-5555" },
            new User { UserId = 9, Username = "BobBuilder", Phone = "999-999-9999" },
            new User { UserId = 10, Username = "EveHacker", Phone = "666-666-6666" }
            });



            modelBuilder.Entity<Ride>().HasData(new Ride[]
            {
            new Ride
            {
                RideId = 1,
                DepartureLocation = "City A",
                Destination = "City B",
                DepartureTime = DateTime.Now.AddHours(1),
                VehicleType = "Car",
                RideDetails = "Comfortable sedan, music available",
                EstimatedFare = 50.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(3),
                UserId = 1 
            },
            new Ride
            {
                RideId = 2,
                DepartureLocation = "City C",
                Destination = "City D",
                DepartureTime = DateTime.Now.AddHours(2),
                VehicleType = "Car",
                RideDetails = "Spacious van, no smoking",
                EstimatedFare = 80.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(4),
                UserId = 2 
            },
            new Ride
            {
                RideId = 3,
                DepartureLocation = "City A",
                Destination = "City B",
                DepartureTime = DateTime.Now.AddHours(1),
                VehicleType = "Car",
                RideDetails = "Comfortable sedan, music available",
                EstimatedFare = 50.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(3),
                UserId = 3
            },
            new Ride
            {
                RideId = 4,
                DepartureLocation = "City C",
                Destination = "City D",
                DepartureTime = DateTime.Now.AddHours(2),
                VehicleType = "Car",
                RideDetails = "Spacious van, no smoking",
                EstimatedFare = 80.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(4),
                UserId = 4
            },
            new Ride
            {
                RideId = 5,
                DepartureLocation = "City A",
                Destination = "City B",
                DepartureTime = DateTime.Now.AddHours(1),
                VehicleType = "Car",
                RideDetails = "Comfortable sedan, music available",
                EstimatedFare = 50.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(3),
                UserId = 5
            },
            new Ride
            {
                RideId = 6,
                DepartureLocation = "City C",
                Destination = "City D",
                DepartureTime = DateTime.Now.AddHours(2),
                VehicleType = "Car",
                RideDetails = "Spacious van, no smoking",
                EstimatedFare = 80.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(4),
                UserId = 6
            },
            new Ride
            {
                RideId = 7,
                DepartureLocation = "City A",
                Destination = "City B",
                DepartureTime = DateTime.Now.AddHours(1),
                VehicleType = "Car",
                RideDetails = "Comfortable sedan, music available",
                EstimatedFare = 50.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(3),
                UserId = 7
            },
            new Ride
            {
                RideId = 8,
                DepartureLocation = "City C",
                Destination = "City D",
                DepartureTime = DateTime.Now.AddHours(2),
                VehicleType = "Car",
                RideDetails = "Spacious van, no smoking",
                EstimatedFare = 80.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(4),
                UserId = 8
            },
            new Ride
            {
                RideId = 9,
                DepartureLocation = "City A",
                Destination = "City B",
                DepartureTime = DateTime.Now.AddHours(1),
                VehicleType = "Car",
                RideDetails = "Comfortable sedan, music available",
                EstimatedFare = 50.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(3),
                UserId = 9
            },
            new Ride
            {
                RideId = 10,
                DepartureLocation = "City C",
                Destination = "City D",
                DepartureTime = DateTime.Now.AddHours(2),
                VehicleType = "Car",
                RideDetails = "Spacious van, no smoking",
                EstimatedFare = 80.00m,
                IsSmokingAllowed = false,
                RideDuration = TimeSpan.FromHours(4),
                UserId = 10
            }



            });
        }
    }
}
