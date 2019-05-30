using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Commands.CreateRoomRental
{
    public interface ICreateRoomRentalCommand
    {
        Task Execute(CreateRoomRentalModel model);
    }
}
