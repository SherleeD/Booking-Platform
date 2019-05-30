using System;
using System.Collections.Generic;
using System.Linq;

using Booking.Domain;

namespace Booking.Persistence
{
    public class BookingInitializer
    {
        private static readonly Dictionary<int, Room> Rooms = new Dictionary<int, Room>();
        private static readonly Dictionary<int, RoomRental> RoomRentals = new Dictionary<int, RoomRental>();

        public static void Initialize(BookingContext  context)
        {
            if (context.Rooms.Any())
            {
                return; // Db has been seeded
            }

            SeedRooms(context);
        }

        public static void SeedRooms(BookingContext context)
        {
            var rooms = new[]
            {
                new Room { Title = "Room 1", ImagePath = "C:\\Booking", Price = 200,Description = "Simple room good for 2 person", Address = "123 Palanan Street Makati City", Capacity  = 2, Status = true },
                new Room { Title = "Room 2", ImagePath = "C:\\Booking", Price = 500,Description = "Simple room good for 4 person", Address = "123 Palanan Street Makati City", Capacity  = 4, Status = true  },
                new Room { Title = "Room 3", ImagePath = "C:\\Booking", Price = 800,Description = "Simple room good for 5 person", Address = "123 Palanan Street Makati City", Capacity  = 5, Status = true  },
                new Room { Title = "Room 4", ImagePath = "C:\\Booking", Price = 1000,Description = "Simple room good for 8 person", Address = "123 Palanan Street Makati City", Capacity  = 8, Status = true  },
                new Room { Title = "Room 5", ImagePath = "C:\\Booking", Price = 1500,Description = "Simple room good for 10 person", Address = "123 Palanan Street Makati City", Capacity  = 10, Status = true  }
            };

            context.Rooms.AddRange(rooms);

            context.SaveChanges();
        }


    }
}
