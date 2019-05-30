using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Queries.GetRoomRentalList
{
    public interface IGetRoomRentalListQuery
    {
        Task<IEnumerable<RoomRentalListModel>> Execute();
    }
}
