using Booking.Domain;
using Booking.Persistence;
using System.Threading.Tasks;
using System;

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
            //validate room capacity
            if (IsValidCapacity(model.RoomId, model.NumberOfPerson))
            {
                //validate booking date range

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

        public bool IsValidCapacity(int roomID, int numberOfPersons)
        {
            var result = _context.Rooms.Find(roomID);
            if (numberOfPersons <= result.Capacity)
            {
                return true;
            }

            return false;
        }

        public int BookingCount(int roomID, DateTime bookingDateFrom, DateTime bookingDateTo)
        {
            //SELECT * FROM [RoomRentals] WHERE @d2 >= DateFrom AND DateTo >= @d1 and RoomId=5
            var result = _context.RoomRentals.Find(roomID);
           
            return 0;
        }

    }
}
