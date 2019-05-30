using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Persistence;

namespace Booking.Application.RoomRental.Queries.GetRoomRentalList
{
    public class GetRoomRentalListQuery : IGetRoomRentalListQuery
    {
        public readonly BookingContext _context;

        public GetRoomRentalListQuery(BookingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoomRentalListModel>> Execute()
        {
            return await _context.RoomRentals.Select(r =>
                new RoomRentalListModel
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
