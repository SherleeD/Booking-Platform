using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Commands.DeleteRoomRental
{
    public interface IDeleteRoomRentalCommand
    {
        Task Execute(string id);
    }
}
