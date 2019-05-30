using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Commands.UpdateRoomRental
{
    public interface IUpdateRoomRentalCommand
    {
        Task Execute(UpdateRoomRentalModel model);
    }
}