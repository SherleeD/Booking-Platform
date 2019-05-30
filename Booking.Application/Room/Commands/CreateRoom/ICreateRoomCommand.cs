using System.Threading.Tasks;

namespace Booking.Application.Room.Commands.CreateRoom
{
    public interface ICreateRoomCommand
    {
        Task Execute(CreateRoomModel model);
    }
}
