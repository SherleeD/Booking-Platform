using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Persistence;

namespace Booking.Application.RoomRental.Queries.GetRoomRentalDetail
{
    public class GetRoomRentalDetailQuery : IGetRoomRentalDetailQuery
    {
        private readonly BookingContext _context;

        public GetRoomRentalDetailQuery(BookingContext context)
        {
            _context = context;
        }

        public async Task<RoomRentalDetailModel> Execute(int id)
        {
            //int roomRentalID = int.Parse(id);
            var entity = await _context.RoomRentals.FindAsync(id);

            if (entity == null)
                return null;

            return new RoomRentalDetailModel
            {
                RoomRentalID = entity.RoomRentalID,
                RoomId = entity.RoomId,
                Email = entity.Email,
                TenantName = entity.TenantName,
                DateFrom = entity.DateFrom,
                DateTo = entity.DateTo,
                NumberOfPerson = entity.NumberOfPerson                
            };
        }
    }
}
