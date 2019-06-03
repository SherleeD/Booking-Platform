using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Persistence;

namespace Booking.Application.RoomRental.Queries.GetAvailableRoom
{
    public class GetAvailableRoomListQuery : IGetAvailableRoomListQuery
    {
        public readonly BookingContext _context;

        public GetAvailableRoomListQuery(BookingContext context)
        {
            _context = context;
        }
       
        public async Task<IEnumerable<AvailableRoomListViewModel>> Execute()
        {
            return await _context.RoomRentals.Select(r =>
                new AvailableRoomListViewModel
                {                    
                    RoomRentalID = r.RoomRentalID,
                    RoomId = r.RoomId,
                    Email = r.Email,
                    TenantName = r.TenantName,
                    DateFrom = r.DateFrom,
                    DateTo = r.DateTo,
                    NumberOfPerson = r.NumberOfPerson
                }).ToListAsync();
        }
    }
}
