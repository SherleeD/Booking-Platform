using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Persistence;

namespace Booking.Application.Room.Queries.GetRoomList
{
    public class GetRoomListQuery : IGetRoomListQuery
    {
        public readonly BookingContext _context;

        public GetRoomListQuery(BookingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoomListModel>> Execute()
        {
            return await _context.Rooms.Select(r =>
                new RoomListModel
                {
                    RoomId = r.RoomId,
                    Title = r.Title 
                }).ToListAsync();
        }

    }
}
