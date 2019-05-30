using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.Application.Room.Queries.GetRoomList
{
    public interface IGetRoomListQuery
    {
        Task<IEnumerable<RoomListModel>> Execute();
    }
}
