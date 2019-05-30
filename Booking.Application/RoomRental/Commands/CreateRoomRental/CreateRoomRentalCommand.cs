using Booking.Domain;
using Booking.Persistence;
using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Commands.CreateRoomRental
{
    public class CreateRoomRentalCommand : ICreateRoomRentalCommand 
    {
        public readonly BookingContext _context;

        public CreateRoomRentalCommand(BookingContext context)
        {
            _context = context;
        }        

        public async Task Execute(CreateRoomRentalModel model)
        {
            
            var entity = new Domain.RoomRental 
            {
                RoomId = model.RoomId,
                Email = model.Email,
                TenantName = model.TenantName,
                DateFrom = model.DateFrom,
                DateTo = model.DateTo,
                NumberOfPerson = model.NumberOfPerson
            };

            _context.RoomRentals.Add(entity);

            await _context.SaveChangesAsync();
        }

    }
}
