using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Persistence;

namespace Booking.Application.Room.Queries.GetRoomDetail
{
    public class GetRoomDetailQuery : IGetRoomDetailQuery
    {
        private readonly BookingContext _context;

        public GetRoomDetailQuery(BookingContext context)
        {
            _context = context;
        }

        public async Task<RoomDetailModel> Execute(string id)
        {
            var entity = await _context.Rooms.FindAsync(id);

            if (entity == null)
                return null;

            return new RoomDetailModel
            {
                RoomId = entity.RoomId,
                Title = entity.Title,
                ImagePath = entity.ImagePath,
                RoomImage = entity.RoomImage,
                Price = entity.Price,
                Description = entity.Description,
                Address = entity.Address,
                Capacity = entity.Capacity,
                Status = entity.Status                
            };
        }


    }
}
