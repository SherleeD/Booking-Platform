using Microsoft.EntityFrameworkCore;
using Booking.Persistence;
using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Commands.UpdateRoomRental
{
    public class UpdateRoomRentalCommand : IUpdateRoomRentalCommand
    {
        public readonly BookingContext _context;

        public UpdateRoomRentalCommand(BookingContext context)
        {
            _context = context;
        }

        public async Task Execute(UpdateRoomRentalModel model)
        {
            var entity = await _context.RoomRentals.SingleAsync(r => r.RoomRentalID == model.RoomRentalID );

            entity.Email = model.Email;
            entity.TenantName = model.TenantName;
            entity.DateFrom = model.DateFrom;
            entity.DateTo = model.DateTo;
            entity.NumberOfPerson = model.NumberOfPerson;
           
            _context.RoomRentals.Update(entity);

            await _context.SaveChangesAsync();
        }

    }
}
