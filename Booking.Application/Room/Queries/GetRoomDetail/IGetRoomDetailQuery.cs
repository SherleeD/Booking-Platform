using System.Threading.Tasks;

namespace Booking.Application.Room.Queries.GetRoomDetail
{
    public interface IGetRoomDetailQuery
    {
        Task<RoomDetailModel> Execute(int id);
    }
}
