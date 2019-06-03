using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Queries.GetAvailableRoom
{
    public interface IGetAvailableRoomListQuery
    {
        Task<IEnumerable<AvailableRoomListViewModel>> Execute();
    }
}
