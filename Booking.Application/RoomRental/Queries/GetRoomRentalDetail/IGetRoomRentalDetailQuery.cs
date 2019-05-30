using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Queries.GetRoomRentalDetail
{
    public interface IGetRoomRentalDetailQuery
    {
        Task<RoomRentalDetailModel> Execute(string id);
    }
}
