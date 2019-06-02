using Microsoft.EntityFrameworkCore;
using Booking.Domain;


namespace Booking.Persistence
{
    public class BookingContext : DbContext 
    {
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomRental> RoomRentals { get; set; }

        public BookingContext(DbContextOptions<BookingContext> options) : base(options) { }

    }

}
